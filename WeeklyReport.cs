using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineReminderApp
{
    public  class WeeklyReport : ReportManager 
    {
        public string FileName = "WeeklyReport.txt";
        public WeeklyReport()
        {
           
            LoadReport();
        }

        // Method to save report using (+) 
        public void SaveReport()
        {
            try
            {
                using (StreamWriter Writer = new StreamWriter("WeeklyReport.txt", false, System.Text.Encoding.UTF8))
                {
                    // Print header
                    Writer.WriteLine("------------------------------");
                    Writer.WriteLine("      MEDICINE WEEKLY REPORT  ");
                    Writer.WriteLine("------------------------------");

                    foreach (var item in WeeklyArray)
                    {
                        // Using only (+) for strings
                        Writer.WriteLine(item.NameDay + " : " + item.MedicineName + " : " + item.MedicineStatus);
                        Writer.WriteLine("------------------------------");
                    }

                    // Add stats at the bottom
                    string summary = CalculateWeeklyStats();
                    Writer.WriteLine(summary);
                    Writer.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Method to calculate stats (Fire and Snow icons)
        public string CalculateWeeklyStats()
        {
            int totalOnTime = 0;
            int currentStreak = 0;

            for (int i = 0; i < WeeklyArray.Length; i++)
            {
                if (WeeklyArray[i].MedicineStatus == ReportManager.DoseStatus.TakeOnTime)
                {
                    totalOnTime = totalOnTime + 1;
                    currentStreak = currentStreak + 1;
                }
                else
                {
                    currentStreak = 0;
                }
            }

            string streakIcons = "";
            if (currentStreak == 0)
            {
                streakIcons = "❄️ Keep Trying";
            }
            else
            {
                for (int i = 1; i <= currentStreak; i++)
                {
                    streakIcons = streakIcons + "🔥";
                }
            }

            return "Total Progress: " + totalOnTime + "/7 | Streak: " + currentStreak + " " + streakIcons;
        }
        // method to read
        public void LoadReport()
        {
            try
            {
                if (File.Exists("WeeklyReport.txt"))
                {
                    using (StreamReader Reader = new StreamReader("WeeklyReport.txt"))
                    {
                        string Line;
                        int i = 0;
                        while ((Line = Reader.ReadLine()) != null && i < WeeklyArray.Length)
                        {
                            // skip empty lines or summary lines
                            if (string.IsNullOrWhiteSpace(Line)|| Line.StartsWith("-")|| Line.Contains("MEDICINE"))
                        continue;

                            // divide the line into parts
                            string[] parts = Line.Split(':');

                            if (parts.Length >= 3)
                            {
                                WeeklyArray[i].NameDay = parts[0].Trim();
                                WeeklyArray[i].MedicineName = parts[1].Trim();

                                // convert text to enum for status
                                string statusText = parts[2].Trim();
                                if (Enum.TryParse(statusText, out ReportManager.DoseStatus savedStatus))
                                {
                                    WeeklyArray[i].MedicineStatus = savedStatus;
                                }
                            }
                            i++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // method to show all medecine in Deafult if not the user specify the medicie
        public void FillReportWithPatientData(Patient patient, string specificMedicine = "All")
        {
            string medicineToDisplay;

            if (specificMedicine == "All")
            {
                // if user didn't enter medicine we add all medicine
                medicineToDisplay = string.Join(",", patient.MyMedicines.GetAll().Select(m => m.Name));
            }
            else
            {
                // if user enter medecine
                medicineToDisplay = specificMedicine;
            }
            // if no medicines 
            if (string.IsNullOrEmpty(medicineToDisplay))
            {
                medicineToDisplay = "No Medicines Found ";
            }
            foreach (var day in WeeklyArray)
            {
                day.MedicineName = medicineToDisplay;
                day.MedicineStatus = DoseStatus.pending;
            }
        }
        public void AddNewMedicineToReport(string medicineName)
        {
            
            for (int i = 0; i < WeeklyArray.Length; i++)
            {
               
                if (string.IsNullOrEmpty(WeeklyArray[i].MedicineName))
                {
                    WeeklyArray[i].MedicineName = medicineName;
                }
                else if (!WeeklyArray[i].MedicineName.Contains(medicineName))
                {
                    WeeklyArray[i].MedicineName += " & " + medicineName;
                }

                WeeklyArray[i].MedicineStatus = ReportManager.DoseStatus.pending;
            }
            SaveReport();
        }
        public void RemoveMedicineFromReport(string medicineName)
        {

            foreach (var day in WeeklyArray)
            {


                if (day.MedicineName == medicineName)
                {
                    day.MedicineName = "";
                    day.MedicineStatus = ReportManager.DoseStatus.pending;
                }
            }
            SaveReport();
        }
    }
  
}
