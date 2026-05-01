using MedecineReminderApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineReminderApp
{
     public class MedicineManager

    {
        private WeeklyReport report = new WeeklyReport();
        
        private List<Medicine> _allMedicines = new List<Medicine>();
        private int _idCounter = 1;

        public Storage Storage
        {
            get => default;
            set
            {
            }
        }

        public Email Email
        {
            get => default;
            set
            {
            }
        }

        public void AddMedicine(Medicine newMed)
        {
            newMed.Id = _idCounter++;
            _allMedicines.Add(newMed);
            report.AddNewMedicineToReport(newMed.Name);
        }

   
        public void RemoveMedicine(string name)
        {
            var item = _allMedicines.FirstOrDefault(m => m.Name == name);
            if (item != null)
            {
                _allMedicines.Remove(item);
                report.RemoveMedicineFromReport(name);
              
                List<string> dataToSave = _allMedicines.Select(x =>
                   $"{x.Name},{x.Quantity},{x.Hour},{x.Minute}").ToList();
                Storage storageService = new Storage("Medicine.txt");
                
                storageService.Save(dataToSave);
            }
        }
      
        public void TakeDose(string name, int amount, string receiverEmail)
        {
            var med = _allMedicines.FirstOrDefault(n => n.Name == name);

            if (med != null && med.Quantity > 0)
            {
                
                if (med.Quantity >= amount)
                {
                    med.Quantity -= amount;
                }

                
                MessageBox.Show($"After: {med.Quantity}");

             
                if (med.Quantity <= 5)
                {
                    Email emailService = new Email();
                    string receiver = Timer.emergencyEmail;
                    emailService.SendInventoryAlert(receiver, med.Quantity);
                }

               
                List<string> dataToSave = _allMedicines.Select(x =>
                 $"{x.Name},{x.Quantity},{x.Hour},{x.Minute},{x.DoseAmount}").ToList();
                Storage storageService = new Storage("Medicine.txt");
                storageService.Save(dataToSave, false);

                
            }
        }

     
        public List<Medicine> GetAll()
        {
            return _allMedicines;
        }

       
   
        public void LoadDataFromStorage()
        {
            Storage storageService = new Storage("Medicine.txt");
            List<string> loadedData = storageService.Load();

            if (loadedData != null)
            {
                _allMedicines.Clear();

                foreach (var line in loadedData)
                {

                    if (line.Contains(","))
                    {
                        var parts = line.Split(',');
                        
                        if (parts.Length >= 5)
                        {
                            string name = parts[0];
                            int qty = int.Parse(parts[1]);
                            int hr = int.Parse(parts[2]);
                            int min = int.Parse(parts[3]);
                           
                           int dose = int.Parse(parts[4]);

                            Medicine newMed = new Medicine(name, hr, min,dose);

                           
                            newMed.Quantity = qty;

                            _allMedicines.Add(newMed);
                        }
                    }
                }

            }
        }
        public void SaveDataToStorage()
        {
            Storage storageService = new Storage("Medicine.txt");
         
            List<string> dataToSave = _allMedicines.Select(x =>
                $"{x.Name},{x.Quantity},{x.Hour},{x.Minute},{x.DoseAmount}").ToList();

            storageService.Save(dataToSave);
        }











    }
}
