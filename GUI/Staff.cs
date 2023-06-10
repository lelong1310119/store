using DAL;
using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.IO;

namespace GUI
{
    public partial class Staff : Form
    {
        DALStaff dal;
        BALStaff bal = new BALStaff();
        private int row;
        private string imagePath;
        public Staff()
        {
            InitializeComponent();
            dal = new DALStaff();
        }

        public void load() {
            try
            {
                DataTable dt = bal.GetAllStaff();
                dgv_staff.DataSource = null;
                dgv_staff.DataSource = dt;
                rad_Male.Checked = true;
                btn_addStaff.Enabled = true;    
                btn_delete.Enabled = false;
                btn_edit.Enabled = false;
                btn_confirm.Enabled = false;
                btn_cancel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Staff_Load(object sender, EventArgs e)
        {
            load();
        }

        public void show(bool bl)
        {
            txt_name.Enabled = bl;
            txt_address.Enabled = bl;
            txt_phone.Enabled = bl;
            groupBox2.Enabled = bl;
            dtp_received.Enabled = bl;
            rad_Male.Enabled = bl;
            rad_FeMale.Enabled = bl;
            pictureBox1.Enabled = bl;
            btn_addImage.Enabled = bl;
        }

        public void reset()
        {
            txt_name.Clear();
            txt_address.Clear();
            txt_phone.Clear();
            txt_id.Clear();
            dtp_received.Value = DateTime.Now;
            rad_Male.Checked = true;
            pictureBox1.ImageLocation = null;

            load();
            show(true);
        }

        private void dgv_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            try
            {
                txt_id.Text = dgv_staff.Rows[row].Cells[0].Value.ToString();
                txt_name.Text = dgv_staff.Rows[row].Cells[1].Value.ToString();
                dtp_received.Value = Convert.ToDateTime(dgv_staff.Rows[row].Cells[2].Value);
                txt_address.Text = dgv_staff.Rows[row].Cells[3].Value.ToString();
                txt_phone.Text = dgv_staff.Rows[row].Cells[4].Value.ToString();
                if (dgv_staff.Rows[row].Cells[5].Value.ToString() == "Nam")
                {
                    rad_Male.Checked = true;
                }
                else
                {
                    rad_FeMale.Checked = true;
                }
                if (dgv_staff.Rows[row].Cells[6].Value.ToString() != "") {
                    pictureBox1.ImageLocation = $@"D:\VS\repos\AppTest\Image\Staff\{dgv_staff.Rows[row].Cells[6].Value}";
                } else
                {
                    pictureBox1.ImageLocation = null;
                }
                show(false);
                btn_addStaff.Enabled = false;
                btn_delete.Enabled = true;
                btn_edit.Enabled = true;
                btn_confirm.Enabled = false;
                btn_cancel.Enabled = false;
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_addImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files( *.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png) | *.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = null;
                pictureBox1.ImageLocation = openFileDialog.FileName;
                imagePath = openFileDialog.FileName;
            }
        }

        public void updateImage(DTOStaff staff)
        {
           try
            {
                if (staff.Image != "" && staff.Image != null)
                {
                    File.Delete($@"D:\VS\repos\AppTest\Image\Staff\{staff.Image}");
                }
                FileInfo fileInfo = new FileInfo(imagePath);
                string folderPath = @"D:\VS\repos\AppTest\Image\Staff";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // cut string
                int lastDotIndex = imagePath.LastIndexOf('.');
                string extension = imagePath.Substring(lastDotIndex);

                // save image
                string newImagePath = Path.Combine(folderPath, $"{staff.ID}" + extension);
                fileInfo.CopyTo(newImagePath, true);
                staff.Image = $"{staff.ID}" + extension;
                dal.EditStaff(staff);
                pictureBox1.ImageLocation = newImagePath;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_addStaff_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Trim() == ""
                || txt_address.Text.Trim() == ""
                || txt_phone.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin.\nVui lòng nhập đầy đủ thông tin.", "Thông báo");
            } else if (!General.checkNumber(txt_phone.Text.Trim()))
            {
                MessageBox.Show("Vui vòng nhập số điện thoại đúng đúng định dạng", "Thông báo");
            } else
            {
                DTOStaff staff = new DTOStaff(txt_name.Text.Trim(), dtp_received.Value, txt_address.Text.Trim(), txt_phone.Text.Trim(), rad_Male.Checked == true ? "Nam" : "Nữ");
                int id;
                try
                {
                    id = dal.AddStaffReturnID(staff);
                    staff.ID = id;
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                updateImage(staff);
                reset();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_id.Text = dgv_staff.Rows[row].Cells[0].Value.ToString();
            txt_name.Text = dgv_staff.Rows[row].Cells[1].Value.ToString();
            dtp_received.Value = Convert.ToDateTime(dgv_staff.Rows[row].Cells[2].Value);
            txt_address.Text = dgv_staff.Rows[row].Cells[3].Value.ToString();
            txt_phone.Text = dgv_staff.Rows[row].Cells[4].Value.ToString();
            if (dgv_staff.Rows[row].Cells[5].Value.ToString() == "Nam")
            {
                rad_Male.Checked = true;
            }
            else
            {
                rad_FeMale.Checked = true;
            }
            if (dgv_staff.Rows[row].Cells[6].Value.ToString() != "")
            {
                pictureBox1.ImageLocation = $@"D:\VS\repos\AppTest\Image\Staff\{dgv_staff.Rows[row].Cells[6].Value}";
            } else
            {
                pictureBox1.ImageLocation = null;
            }
            btn_delete.Enabled = true;
            btn_edit.Enabled = true;
            btn_confirm.Enabled = false;
            btn_cancel.Enabled = false;
            show(false);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
            btn_confirm.Enabled = true;
            btn_cancel.Enabled = true;
            try
            {
                show(true);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                DTOStaff staff = new DTOStaff(int.Parse(txt_id.Text.Trim().ToString()), txt_name.Text.Trim(), dtp_received.Value, txt_address.Text.Trim(), txt_phone.Text.Trim(), rad_Male.Checked == true ? "Nam" : "Nữ");
                staff.Image = dgv_staff.Rows[row].Cells[6].Value.ToString();
                updateImage(staff);
                MessageBox.Show("Sửa thành công", "Thông báo");
                reset();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.ImageLocation != null)
                {
                    string path = pictureBox1.ImageLocation;
                    pictureBox1.ImageLocation = null;
                    File.Delete(path);
                }
                dal.DeleteStaff(int.Parse(txt_id.Text.ToString()));
                MessageBox.Show("Xóa thành công", "Thông báo");
                reset();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txt_search.Text.Trim().ToString();
                DataTable dt = dal.SearchStaff(text);
                dgv_staff.DataSource = null;
                dgv_staff.DataSource = dt;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
