using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class CreateBill : Form
    {
        private DALCustomer dalcustomer;
        private DALBill dalbill;
        private DALBillDetail daldetail;
        private DALStaff dalstaff;
        private DALcity dalcity;
        private DALProduct dalProduct;
        private int row;
        List <DTODetailBill> billDetails;
        private int total = 0;
        private int MaKH;
        
        public CreateBill()
        {
            InitializeComponent();
            billDetails = new List<DTODetailBill>();
            dalcustomer = new DALCustomer();
            dalbill = new DALBill();
            daldetail = new DALBillDetail();
            dalstaff = new DALStaff();
            dalProduct = new DALProduct();
            dalcity = new DALcity();
        }

        public void showInfo(bool b)
        {
            txt_name.Enabled = b;
            txt_phone.Enabled = b;
            txt_address.Enabled = b;
            cb_city.Enabled = b;
            btn_add.Enabled = b;
            btn_getCustomer.Enabled = b;
        }

        public void reset()
        {
            DataTable dtStaff = dalstaff.getAllStaff();
            DataTable dtcity = dalcity.getAllcity();
            DataTable dtProduct = dalProduct.getAllProduct();
            cb_city.DataSource = dtcity;
            cb_city.DisplayMember = "TenThanhPho";
            cb_city.ValueMember = "MaTP";
            cb_city.SelectedIndex = 0;
            cb_staff.DataSource = dtStaff;
            cb_staff.DisplayMember = "HoTen";
            cb_staff.ValueMember = "MaNV";
            cb_staff.SelectedIndex = 0;
            cb_product.DataSource = dtProduct;
            cb_product.DisplayMember = "TenSP";
            cb_product.ValueMember = "MaSP";
            cb_product.SelectedIndex = 0;
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            var maSP = cb_product.SelectedValue;
            string gia = dtProduct.Select($"MaSP = '{maSP}'")[0]["Dongia"].ToString();
            txt_price.Text = gia;
            total = 0;
            billDetails.Clear();
            txt_total.Text = total.ToString();
        }
        private void Bill_Load(object sender, EventArgs e)
        {
            try
            {
                reset();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btn_getCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = dalcustomer.getCustomerfromPhone(txt_phone.Text.Trim());
                if (dt != null)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có thông tin khách hàng.\nVui lòng nhập thông tin", "Thông báo");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.row = e.RowIndex;
            try
            {
                MaKH = int.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
                txt_name.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                txt_address.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
                txt_phone.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
                cb_city.SelectedValue = dataGridView1.Rows[row].Cells[4].Value;
                txt_name.Enabled = false;
                txt_phone.Enabled = false;
                txt_address.Enabled = false;
                cb_city.Enabled = false;
                btn_getCustomer.Enabled = false;
                btn_save.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DTODetailBill detail = billDetails.Find(item => item.IDProduct == int.Parse(cb_product.SelectedValue.ToString()));
            if (detail != null)
            {
                detail.Quantity += int.Parse(quantity.Value.ToString());
            }
            else
            {
                DTODetailBill newDetail = new DTODetailBill(int.Parse(cb_product.SelectedValue.ToString()), int.Parse(quantity.Value.ToString()));
                billDetails.Add(newDetail);
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = billDetails;
            total += int.Parse(quantity.Value.ToString()) * int.Parse(txt_price.Text.ToString());
            txt_total.Text = total.ToString();
        }

        private void cb_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSP = cb_product.SelectedValue.ToString();
            DataRowView selectedRow = (DataRowView)cb_product.SelectedItem;
            string giaSP = selectedRow.Row["Dongia"].ToString();
            txt_price.Text = giaSP;
        }

        public void resetCustommer()
        {
            txt_name.Enabled = true;
            txt_phone.Enabled = true;
            txt_address.Enabled = true;
            cb_city.Enabled = true;
            btn_getCustomer.Enabled = true;
            btn_save.Enabled = true;

            txt_name.Clear();
            txt_address.Clear();
            txt_phone.Clear();
            cb_city.SelectedIndex = 0;
            dataGridView1.DataSource = null;
        }

        public void resetBill()
        {
            cb_product.SelectedIndex = 0;
            txt_price.Clear();
            txt_total.Clear();
            cb_staff.SelectedIndex = 0;
            dt_create.Value = DateTime.Now;
            dt_received.Value = DateTime.Now;
            quantity.Value = 1;
            dataGridView2.DataSource = null;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Trim() == ""
                || txt_address.Text.Trim() == ""
                || txt_phone.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            } else if (!General.checkNumber(txt_phone.Text.Trim())) {
                MessageBox.Show("Vui lòng nhập số điện thoại đúng định dạng");
            }
            else
            {
                try
                {
                    DTOCustomer customer = new DTOCustomer(txt_name.Text.Trim(), txt_address.Text.Trim(), txt_phone.Text.Trim(), int.Parse(cb_city.SelectedValue.ToString()));
                    int MaKH = dalcustomer.AddCustomerReturnID(customer);
                    showInfo(false);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                DTOBill bill = new DTOBill(MaKH, int.Parse(cb_staff.SelectedValue.ToString()), dt_create.Value, dt_received.Value);
                int MaHD = dalbill.AddBillReturnID(bill);
                foreach (DTODetailBill detail in billDetails)
                {
                    daldetail.AddBillDetail(detail, MaHD);
                }
                MessageBox.Show("Tạo hóa đơn thành công", "Thông báo");
                resetCustommer();
                resetBill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
