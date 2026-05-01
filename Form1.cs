using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace MedicineReminderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            
            InitializeComponent();

            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Storage s = new Storage("Patient.txt");
                List<string> savedData = s.Load();
                if (savedData != null)
                {
                    foreach (var line in savedData)
                    {
                        if (line.StartsWith("Name: ")) nametext.Text = line.Replace("Name: ", "");
                        if (line.StartsWith("Age: ")) agetext.Text = line.Replace("Age: ", "");
                        if (line.StartsWith("Email: ")) emailtext.Text = line.Replace("Email: ", "");
                    }
                }
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Timer.emergencyEmail = emailtext.Text;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                string name = nametext.Text;
                string age = agetext.Text;
                string email = emailtext.Text;
                

                // Check if Email contains '@' and '.'
                
                string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

               
                if (!Regex.IsMatch(emailtext.Text, emailPattern))
                {
                    MessageBox.Show("Invalid Email Format! Please use English letters (e.g., patient@example.com).");
                    return; // وقف الكود وما تكملش حفظ
                }

                Patient currentPatient = new Patient();
                currentPatient.Name = name;
                currentPatient.Age = int.Parse(age); 

             
                List<string> dataToSave = new List<string>();
                dataToSave.Add("Name: " + currentPatient.Name);
                dataToSave.Add("Age: " + currentPatient.Age);
                dataToSave.Add("Email: " + emailtext.Text);

                Storage storage = new Storage("Patient.txt");
                storage.Save(dataToSave);

                MessageBox.Show("Data saved successfully!");
                Timer.emergencyEmail = emailtext.Text;

                Form2 nextForm = new Form2(emailtext.Text);
                nextForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Please ensure all data is entered correctly: " + ex.Message);
            }
        }
    }
}
