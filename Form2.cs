using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace MedicineReminderApp
{
    public partial class Form2 : Form
    {
         MedicineManager manager = new MedicineManager();
        
        string userEmailFromForm1;
        
        Timer alarmSystem = new Timer();
        public Form2(string email)
        {
            InitializeComponent();
            userEmailFromForm1 = email; 
            timer1.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            manager.LoadDataFromStorage();
           
          
            listBoxMedicines.Items.Clear();

            
            foreach (var med in manager.GetAll())
            {
               
                listBoxMedicines.Items.Add(med.ToString());
            }

            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textMedName.Text;
        
            int hour = (int)numHour.Value;
            int minute = (int)numMin.Value;

             int qty = (int)numQty.Value;
            int dose = (int)numDoseAmount.Value;
            Medicine newMed = new Medicine(name, hour, minute,dose);
            newMed.Quantity = (int)numQty.Value;
            Timer.emergencyEmail = userEmailFromForm1;
            manager.AddMedicine(newMed);
            manager.SaveDataToStorage();

            alarmSystem.UserSelectedHour = hour;
            alarmSystem.UserSelectedMinute = minute;

        
            alarmSystem.InitTimerLogic(Timer.emergencyEmail , name);

         
            listBoxMedicines.Items.Add(newMed.ToString());
           
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            alarmSystem.CheckTimeTick(sender, e);
        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        { 
            string selectedText = listBoxMedicines.SelectedItem.ToString();

            
            int index = listBoxMedicines.SelectedIndex;
            var med = manager.GetAll()[index]; 
          
            manager.RemoveMedicine(med.Name);

          
            RefreshListBox();
        }
        private void RefreshListBox()
        {
            listBoxMedicines.Items.Clear();
            foreach (var med in manager.GetAll())
            {
                listBoxMedicines.Items.Add(med.ToString()); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WeeklyReportForm reportForm = new WeeklyReportForm();
            reportForm.ShowDialog(); 
        }

        private void numDoseAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    
}
