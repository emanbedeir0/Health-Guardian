using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineReminderApp
{
    public partial class WeeklyReportForm : Form
    {
        public WeeklyReportForm()
        {
            InitializeComponent();

        }

        private void WeeklyReportForm_Load(object sender, EventArgs e)
        {
            
            WeeklyReport report = new WeeklyReport();
            report.LoadReport();
            dataGridView1.DataSource = null;
            
            dataGridView1.DataSource = report.WeeklyArray.ToList();

          

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
       
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["MedicineName"].HeaderText = "Medicine Name";
            dataGridView1.Columns["MedicineStatus"].HeaderText = "Status";
            var stats = report.CalculateWeeklyStats();
            streak.Text = report.CalculateWeeklyStats();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void streak_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
