using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MedicineReminderApp
{
    public class Medicine
    {
        // بيانات الهوية
        public int Id { get; set; }
        public string Name { get; set; }

        // بيانات الجرعة والمواعيد
        public int DoseAmount { get; set; }
        public TimeSpan ReminderTime { get; set; }


        // بيانات المخزن (Inventory)
        public int Quantity { get; set; }
        public int MinQuantity { get; set; }


        //بيانات ال time
        public int Hour { get; set; }
        public int Minute { get; set; }

        public Medicine(string name, int hour, int minute,int dose)
        {
            this.Name = name;
            this.Hour = hour;
            this.Minute = minute;
            DoseAmount = dose;
        }
       

        
        public bool IsLowStock() => Quantity <= MinQuantity;

        public override string ToString()
        {
            return $"Name: {Name} || Dose: {DoseAmount} || Qtuantity: {Quantity} || Time: {Hour:D2}:{Minute:D2}";
        }
    }
}