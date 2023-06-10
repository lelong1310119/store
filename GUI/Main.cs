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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            this.Hide();
            staff.ShowDialog();
            this.Show();
        }

        private void thànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            City city= new City();
            this.Hide();
            city.ShowDialog();
            this.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            this.Hide();
            product.ShowDialog();
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            this.Hide();
            customer.ShowDialog();
            this.Show();
        }

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBill createBill = new CreateBill();
            this.Hide();
            createBill.ShowDialog();
            this.Show();
        }

        private void theoThờiGianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDateTime reportDateTime = new ReportDateTime();
            this.Hide();
            reportDateTime.ShowDialog();
            this.Show();
        }
    }
}
