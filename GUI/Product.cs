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
    public partial class Product : Form
    {
        public DALProduct dal;
        private int row;
        private string imagePath;
        public Product()
        {
            InitializeComponent();
            dal = new DALProduct();
        }

        public void show(bool bl)
        {
            txt_name.Enabled = bl;
            txt_price.Enabled = bl;
            pictureBox1.Enabled = bl;
            btn_addImage.Enabled = bl;
        }

        public void reset()
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_search.Clear();
            txt_price.Clear();
            show(true);

            pictureBox1.ImageLocation = null;
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            btn_confirm.Enabled = false;
            btn_cancel.Enabled = false;
            txt_name.Enabled = true;

            try
            {
                DataTable dt = dal.getAllProduct();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
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

        public void updateImage(DTOProduct product)
        {
            if (pictureBox1.ImageLocation != null)
            {
                try
                {
                    if (product.Image != "" && product.Image != null)
                    {
                        File.Delete($@"D:\VS\repos\AppTest\Image\Product\{product.Image}");
                    }
                    FileInfo fileInfo = new FileInfo(imagePath);
                    string folderPath = @"D:\VS\repos\AppTest\Image\Product";
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    // cut string
                    int lastDotIndex = imagePath.LastIndexOf('.');
                    string extension = imagePath.Substring(lastDotIndex);

                    // save image
                    string newImagePath = Path.Combine(folderPath, $"{product.ID}" + extension);
                    fileInfo.CopyTo(newImagePath, true);
                    product.Image = $"{product.ID}" + extension;
                    dal.EditProduct(product);
                    pictureBox1.ImageLocation = newImagePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void deleteImage()
        {

        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txt_search.Text.Trim().ToString();
                DataTable dt = dal.SearchProduct(text);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message)
;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Trim() == ""
                || txt_price.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            } else if (!General.checkNumber(txt_price.Text.Trim()))
            {
                MessageBox.Show("Vui vòng nhập giá đúng đúng định dạng số", "Thông báo");
            } else
            {
                DTOProduct product = new DTOProduct(txt_name.Text.Trim(), int.Parse(txt_price.Text.Trim()));
                int id;
                try
                {
                    id = dal.AddProductReturnID(product);
                    product.ID = id;
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                updateImage(product);
                reset();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(txt_id.Text.ToString());
                dal.DeleteProduct(ID);
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
            try
            {
                txt_id.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                txt_name.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                txt_price.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
                if (dataGridView1.Rows[row].Cells[3].Value.ToString() != "")
                {
                    pictureBox1.ImageLocation = $@"D:\VS\repos\AppTest\Image\Product\{dataGridView1.Rows[row].Cells[3].Value}";
                }
                else
                {
                    pictureBox1.ImageLocation = null;
                }
                show(false);
                btn_add.Enabled = false;
                btn_edit.Enabled = true;
                btn_delete.Enabled = true;
                btn_cancel.Enabled = false;
                btn_confirm.Enabled = false;
            } catch (Exception ex)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            showInfo();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_delete.Enabled = false;
            btn_confirm.Enabled = true;
            btn_cancel.Enabled = true;
            txt_name.Enabled = true;
            txt_price.Enabled = true;
            btn_addImage.Enabled = true;
            pictureBox1.Enabled = true;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                DTOProduct product = new DTOProduct(int.Parse(txt_id.Text.ToString()), txt_name.Text.Trim(), int.Parse(txt_price.Text.Trim()));
                product.Image = dataGridView1.Rows[row].Cells[3].Value.ToString();
                updateImage(product);
                reset();
                MessageBox.Show("Chỉnh sửa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}

