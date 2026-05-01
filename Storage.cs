using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MedicineReminderApp

{
    public class Storage
    {
       
        private string fileName;
        public Storage(string name)
        { 
            this.fileName = name;
        }
       
        public void Save(List<string> information, bool append = false)
        {
            try
            {
                if (append)
                {
                   
                    File.AppendAllLines(fileName, information);
                }
                else
                {
                    
                    File.WriteAllLines(fileName, information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       
        public List<string> Load()
        {
            try
            {
                if (File.Exists(fileName))
                {
                    string[] data = File.ReadAllLines(fileName);
                    return new List<string>(data);
                }
                else
                {
                    return new List<string>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حصل خطأ أثناء تحميل البيانات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }
        }
    }
}
