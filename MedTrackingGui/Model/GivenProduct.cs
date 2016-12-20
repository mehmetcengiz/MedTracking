using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MedTrackingGui.Model {
    public class GivenProduct {
        public int Index { get; private set; }
        public string Type { get; private set; }
        public string EmployeeNameAndSurname { get; private set; }
        public string PatientNameAndSurname { get; private set; }
        public DateTime Date { get; private set; }
        public int TotalMedicine { get; private set; }
        public float TotalPrice { get; private set; }

        public GivenProduct(int index, string type, string employeeNameAndSurname, string patientNameAndSurname, DateTime date, int totalMedicine, float totalPrice) {
            Index = index;
            Type = type;
            EmployeeNameAndSurname = employeeNameAndSurname;
            PatientNameAndSurname = patientNameAndSurname;
            Date = date;
            TotalMedicine = totalMedicine;
            TotalPrice = totalPrice;
        }

        public ListViewItem GetListViewItem() {
            var result = new ListViewItem {Text = Index.ToString()};

            result.SubItems.Add(Type);
            result.SubItems.Add(EmployeeNameAndSurname);
            result.SubItems.Add(PatientNameAndSurname);
            result.SubItems.Add(Date.ToString());
            result.SubItems.Add(TotalMedicine.ToString());
            result.SubItems.Add(TotalPrice.ToString());

            return result;
        }
    }
}
