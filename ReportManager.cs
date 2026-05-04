using MedicineReminderApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineReminderApp

{
    public class ReportManager
    {
        
        public List<WeeklyReport> AllReports  = new List<WeeklyReport>();

        //  enum for dose status
        public enum DoseStatus
        {
            pending,
            TakeOnTime,
            
        }
      



        
        public DayRecord[] WeeklyArray = new DayRecord[7];

        public ReportManager()
        {
            // Initialize the days
            for (int i = 0; i < WeeklyArray.Length; i++)
            {
                WeeklyArray[i] = new DayRecord();
            }

            
            WeeklyArray[0].NameDay = "Saturday";
            WeeklyArray[1].NameDay = "Sunday";
            WeeklyArray[2].NameDay = "Monday";
            WeeklyArray[3].NameDay = "Tuesday";
            WeeklyArray[4].NameDay = "Wednesday";
            WeeklyArray[5].NameDay = "Thursday";
            WeeklyArray[6].NameDay = "Friday";
        }
    }
    
    public class DayRecord
    {
        public string NameDay { get; set; }
        public ReportManager.DoseStatus MedicineStatus { get; set; }
        public string MedicineName { get; set; }
    }

}

