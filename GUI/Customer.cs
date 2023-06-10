using BAL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI
{
    public partial class Customer : Form
    {
        public DALCustomer dal;
        private int row;
        public Customer()
        {
            InitializeComponent();
            dal = new DALCustomer();
        }

        public void show(bool bl)
        {
            txt_name.Enabled = bl;
            txt_address.Enabled = bl;
            txt_phone.Enabled = bl;
            cb_city.Enabled = bl;
        }

        public void reset()
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_search.Clear();
            txt_address.Clear();
            txt_phone.Clear();
            show(true);

            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            btn_confirm.Enabled = false;
            btn_cancel.Enabled = false;
            try
            {
                DataTable dt = dal.getAllCustomer();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
                DALcity dal2 = new DALcity();
                DataTable dt2 = dal2.getAllcity();
                cb_city.DataSource = dt2;
                cb_city.DisplayMember = "TenThanhPho";
                cb_city.ValueMember = "MaTP";
                cb_city.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void City_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txt_search.Text.Trim().ToString();
                DataTable dt = dal.SearchCustomer(text);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message)
;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(txt_id.Text.ToString());
                dal.DeleteCustomer(ID);
                MessageBox.Show("Xóa thành công", "Thông báo");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void showInfo()
        {
            txt_id.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            txt_address.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            txt_phone.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            cb_city.SelectedValue = dataGridView1.Rows[row].Cells[4].Value;
            show(false);
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
            btn_cancel.Enabled = false;
            btn_confirm.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            showInfo();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
            btn_confirm.Enabled = true;
            btn_cancel.Enabled = true;
            show(true);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(!General.checkNumber(txt_phone.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại đúng định dạng", "Thông báo");
            } else
            {
                try
                {
                    DTOCustomer customer = new DTOCustomer(int.Parse(txt_id.Text.ToString()), txt_name.Text.Trim(), txt_address.Text.Trim(), txt_phone.Text.Trim(), int.Parse(cb_city.SelectedValue.ToString()));
                    dal.EditCustomer(customer);
                    reset();
                    MessageBox.Show("Chỉnh sửa thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            showInfo();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}

