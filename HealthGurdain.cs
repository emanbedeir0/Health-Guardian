using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MedicineReminderApp
{
  
    public class Person
    {
       
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                string email = value.ToLower().Trim(); 

                
                string pattern = @"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(email, pattern))
                {
                    throw new Exception("Invalid Email Format!");
                }

                if (email.Contains("@gmal.") || email.Contains("@gmaill.") || email.Contains("@gmial."))
                {
                    throw new Exception("Did you mean @gmail.com? Please check the spelling.");
                }

                if (email.EndsWith(".con") || email.EndsWith(".comm"))
                {
                    throw new Exception("Did you mean .com? Please check the spelling.");
                }

                _email = email;
            }
        }
        private string name; 

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty!");
                }
                if (value.Any(char.IsDigit))
                {
                    throw new Exception("Name cannot contain numbers!");
                }

                name = value;
            }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {


                if (value <= 0)
                    throw new Exception("Enter valid age :");
                age = value;
            }
        }
    }

    public class Patient : Person
    {
        public int Dose { get; set; }
        public MedicineManager MyMedicines = new MedicineManager();
    }

}
