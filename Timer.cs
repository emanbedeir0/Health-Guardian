using MedicineReminderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineReminderApp
{
    public partial class Timer
    {






        SoundPlayer player = new SoundPlayer(@"Alarm05.wav");
        bool isAlarmRunning = false;

        private Medicine med;
        private Email emailService = new Email ();
        private WeeklyReport report= new WeeklyReport ();
        private System.Windows.Forms.Timer checkTimer;

        private DateTime alarmStartTime;
        private bool emailSent = false;
        public int UserSelectedHour; 
        public int UserSelectedMinute;
        public static string emergencyEmail;
        public MedicineManager manager = new MedicineManager();

        public void InitTimerLogic(string userEmail, string medicineName)
        {
            
           emergencyEmail = userEmail;
            SetupMyProject (  userEmail, medicineName);
        }

        public void SetupMyProject(string userEmail, string medicineName)
        {

            Timer.emergencyEmail = userEmail;
            manager.LoadDataFromStorage();

            var CurrentMed = manager.GetAll().FirstOrDefault(m => m.Name == medicineName);
            int actualDose = 1;
            if (CurrentMed != null)
            {
                actualDose = CurrentMed.DoseAmount;
            }
            med = new Medicine(medicineName, UserSelectedHour, UserSelectedMinute, actualDose);

            emailService = new Email();
            string emergencyEmail = userEmail;
            report = new WeeklyReport();
            checkTimer = new System.Windows.Forms.Timer();
            checkTimer.Interval = 1000;
            checkTimer.Tick += CheckTimeTick;
            checkTimer.Start();

        }

        public void CheckTimeTick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            // Missed Dose (If 1 minute passed)
            if (isAlarmRunning && !emailSent && (DateTime.Now - alarmStartTime).TotalSeconds >= 60)
            {
              // Change emailSent to true FIRST to block any other logic
                emailSent = true;
                isAlarmRunning = false;

                player.Stop();

                // Close the MessageBox
                System.Windows.Forms.SendKeys.SendWait("{ENTER}");

                // Update Report to Missed
                report.LoadReport();
                int myTodayIndex = ((int)now.DayOfWeek + 1) % 7;
                report.WeeklyArray[myTodayIndex].MedicineStatus = ReportManager.DoseStatus.Missed;
                report.SaveReport();

                // Send Email
                if (!string.IsNullOrEmpty(Timer.emergencyEmail))
                {
                    emailService.SendPatientAlert(Timer.emergencyEmail);
                }
            }

            // Alarm Trigger
            if (now.Hour == UserSelectedHour && now.Minute == UserSelectedMinute && !isAlarmRunning && !emailSent)
            {
                isAlarmRunning = true;
                player.PlayLooping();
                alarmStartTime = DateTime.Now;

                System.Threading.Tasks.Task.Run(() =>
                {
                    DialogResult result = MessageBox.Show($"Time for: {med.Name}\nDose: {med.DoseAmount}", "Health Reminder", MessageBoxButtons.OK);

                   
                    if (result == DialogResult.OK && (DateTime.Now - alarmStartTime).TotalSeconds < 60 && isAlarmRunning)
                    {
                        player.Stop();
                        isAlarmRunning = false;
                        emailSent = true;

                        manager.LoadDataFromStorage();
                        manager.TakeDose(med.Name, med.DoseAmount, Timer.emergencyEmail);

                        report.LoadReport();
                        int myTodayIndex = ((int)DateTime.Now.DayOfWeek + 1) % 7;
                        report.WeeklyArray[myTodayIndex].MedicineName = med.Name + " (" + med.DoseAmount + ")";
                        report.WeeklyArray[myTodayIndex].MedicineStatus = ReportManager.DoseStatus.TakeOnTime;
                        report.SaveReport();
                    }
                    else
                    {
                        
                        player.Stop();
                    }
                });
            }

            if (now.Minute != UserSelectedMinute && !isAlarmRunning)
            {
                emailSent = false;
            }
        }
    }
 }





      