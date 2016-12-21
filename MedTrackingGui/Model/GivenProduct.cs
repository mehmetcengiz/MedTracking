using System;
using System.Windows.Forms;

namespace MedTrackingGui.Model {
  public class GivenProduct {
    public int Index { get; }
    public string Type { get; }
    public string EmployeeFullName { get; }
    public string PatientFullName { get; }
    public DateTime Date { get; }
    public int TotalMedicine { get; }
    public double TotalPrice { get; }

    //public GivenProduct(int index, string type, string employeeFullName, string patientFullName,
    //  DateTime date, int totalMedicine, float totalPrice) {
    //  Index = index;
    //  Type = type;
    //  EmployeeFullName = employeeFullName;
    //  PatientFullName = patientFullName;
    //  Date = date;
    //  TotalMedicine = totalMedicine;
    //  TotalPrice = totalPrice;
    //}

    public GivenProduct(int index, Prescription prescription) {
      Index = index;
      Type = @"Prescription";
      EmployeeFullName = prescription.Employee.FullName;
      PatientFullName = prescription.Patient.FullName;
      Date = prescription.CreatedAt;

      var medicines = prescription.MedicineBoxes;
      TotalMedicine = medicines.Count;
      foreach (var medicine in medicines) {
        TotalPrice += medicine.Medicine.Price;
      }
    }

    public GivenProduct(int index, Sale sale) {
      Index = index;
      Type = @"Sale";
      EmployeeFullName = sale.Employee.FullName;
      PatientFullName = @"";
      Date = sale.SoldAt;

      var medicines = sale.MedicineBoxes;
      TotalMedicine = medicines.Count;
      foreach (var medicine in medicines) {
        TotalPrice += medicine.Medicine.Price;
      }
    }

    public ListViewItem GetListViewItem() {
      var result = new ListViewItem {Text = Index.ToString()};

      result.SubItems.Add(Type);
      result.SubItems.Add(EmployeeFullName);
      result.SubItems.Add(PatientFullName);
      result.SubItems.Add(Date.ToString());
      result.SubItems.Add(TotalMedicine.ToString());
      result.SubItems.Add(TotalPrice.ToString());

      return result;
    }
  }
}
