using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class ReportDateTime : Form
    {
        private DALReport dalReport;
        public ReportDateTime()
        {
            InitializeComponent();
            dalReport = new DALReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = (cb_case.SelectedItem.ToString() == "Ca sáng") ? 1 : 2;
            DataTable dt = dalReport.getBillCase(x);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }

        public void reset()
        {
            resetSelectedIndex();
            cb_case.Enabled = true;
            dateTimePicker1.Enabled = false;
            cb_month.Enabled = false;
            cb_quarter.Enabled = false;
            cb_year.Enabled = false;

            try
            {
                DataTable dt = dalReport.getBillCase(1);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void resetSelectedIndex ()
        {
            dateTimePicker1.Value = dateTimePicker1.MaxDate;
            cb_year.SelectedIndex = 0;
            cb_case.SelectedIndex = 0;
            cb_month.SelectedIndex = 0;
            cb_quarter.SelectedIndex = 0;
            cb_method.SelectedIndex = 0;
        }
        private void ReportDateTime_Load(object sender, EventArgs e)
        {
            cb_method.Items.Add("Theo ca");
            cb_method.Items.Add("Theo ngày");
            cb_method.Items.Add("Theo tháng");
            cb_method.Items.Add("Theo quý");
            cb_method.Items.Add("Theo năm");
            cb_case.Items.Add("Ca sáng");
            cb_case.Items.Add("Ca chiều");

            dateTimePicker1.MaxDate = DateTime.Today;
            DateTime currentDate = DateTime.Now;
            int currentMonth = currentDate.Month;
            int currentQuarter = (currentDate.Month - 1) / 3 + 1;
            int i = currentMonth;
            cb_year.Items.Add(currentDate.Year);
            while (i > 0)
            {
                DateTime month = new DateTime(currentDate.Year, i, 1);
                cb_month.Items.Add(month.ToString("MM/yyyy"));
                i--;
            }

            for (int j = currentQuarter; j > 0; j--)
            {
                string quarter = $"Quý {j}/{currentDate.Year}";
                cb_quarter.Items.Add(quarter);
            }

            for (int k = currentDate.Year - 1; k > currentDate.Year - 5; k--)
            {
                for (int j = 12; j > 0; j--)
                {
                    DateTime month = new DateTime(k, j, 1);
                    cb_month.Items.Add(month.ToString("MM/yyyy"));
                }
                for (int j = 4; j > 0; j--)
                {
                    string quarter = $"Quý {j}/{k}";
                    cb_quarter.Items.Add(quarter);
                }
                cb_year.Items.Add(k);
            }
            reset();
        }

        public void getDatabyDate()
        {
            try
            {
                DataTable dt = dalReport.getBillDateTime(dateTimePicker1.Value);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getDatabyMonth()
        {
            string selectedMonth = cb_month.SelectedItem.ToString();
            DateTime datetime = DateTime.ParseExact(selectedMonth, "MM/yyyy", CultureInfo.InvariantCulture);
            int month = datetime.Month;
            int year = datetime.Year;
            try
            {
                DataTable dt = dalReport.getBillMonth(month, year);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getDatabyQuarter()
        {
            string selectedQuarter = cb_quarter.SelectedItem.ToString();
            string[] quarterYear = selectedQuarter.Split('/');
            int quarterValue = int.Parse(quarterYear[0].Split(' ')[1]);
            int yearValue = int.Parse(quarterYear[1]);
            try
            {
                DataTable dt = dalReport.getBillQuarter(quarterValue, yearValue);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getDatabyYear()
        {
            try
            {
                int year = int.Parse(cb_year.SelectedItem.ToString());
                DataTable dt = dalReport.getBillYear(year);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_method_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cb_method.SelectedIndex)
            {
                case 0:
                    reset();
                    break;
                case 1:
                    resetSelectedIndex();
                    dateTimePicker1.Enabled = true;
                    cb_case.Enabled = false;
                    cb_month.Enabled = false;
                    cb_quarter.Enabled = false;
                    cb_year.Enabled = false;
                    getDatabyDate();
                    break;
                case 2:
                    resetSelectedIndex();
                    cb_month.Enabled = true;
                    dateTimePicker1.Enabled = false;
                    cb_case.Enabled = false;
                    cb_quarter.Enabled = false;
                    cb_year.Enabled = false;
                    getDatabyMonth();
                    break;

                case 3:
                    resetSelectedIndex();
                    cb_month.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    cb_case.Enabled = false;
                    cb_quarter.Enabled = true;
                    cb_year.Enabled = false;
                    getDatabyQuarter();
                    break;
                case 4:
                    resetSelectedIndex();
                    cb_month.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    cb_case.Enabled = false;
                    cb_quarter.Enabled = false;
                    cb_year.Enabled = true;
                    getDatabyYear();
                    break;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            getDatabyDate();
        }

        private void cb_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDatabyMonth();
        }

        private void cb_quarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDatabyQuarter();
        }

        private void cb_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDatabyYear();
        }
    }
}
