using BAL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class City : Form
    {
        public DALcity dal;
        public BALCity bal = new BALCity();
        private int row;
        public City()
        {
            InitializeComponent();
            dal = new DALcity();
        }

        public void reset()
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_search.Clear();

            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            btn_confirm.Enabled = false;
            btn_cancel.Enabled = false;
            txt_name.Enabled = true;

            try
            {
                DataTable dt = bal.GetAllCity();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
            } catch (Exception ex)
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
                DataTable dt = dal.SearchCity(text);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource= dt;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message)
;            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên thành phố", "Thông báo");
            } else
            {
                try
                {
                    DTOCity city = new DTOCity(txt_name.Text.Trim());
                    dal.AddCity(city);
                    reset();
                    MessageBox.Show("Thêm thành công", "Thông báo");
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(txt_id.Text.ToString());
                dal.DeleteCity(ID);
                MessageBox.Show("Xóa thành công", "Thông báo");
                reset();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            txt_id.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            btn_add.Enabled = false;
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
            txt_name.Enabled = false;
            btn_cancel.Enabled = false;
            btn_confirm.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_delete.Enabled = false;
            btn_confirm.Enabled = true;
            btn_cancel.Enabled = true;
            txt_name.Enabled = true;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                DTOCity city = new DTOCity(int.Parse(txt_id.Text.ToString()), txt_name.Text.Trim());
                dal.EditCity(city);
                reset();
                MessageBox.Show("Chỉnh sửa thành công", "Thông báo");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            btn_add.Enabled = false;
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
            txt_name.Enabled = false;
            btn_confirm.Enabled = false;
            btn_cancel.Enabled = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
