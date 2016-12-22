using System;
using System.Collections.Generic;
using System.Globalization;
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

		public GivenProduct(int index, SaleOrPrescription saleOrPrescription) {
			Index = index;

			List<MedicineBox> medicines;

			if (saleOrPrescription.Prescription == null) {
				Type = @"Sale";
				EmployeeFullName = saleOrPrescription.Sale.Employee.FullName;
				PatientFullName = @"";
				Date = saleOrPrescription.Sale.SoldAt;

				medicines = saleOrPrescription.Sale.MedicineBoxes;
			} else {
				Type = @"Prescription";
				EmployeeFullName = saleOrPrescription.Prescription.Employee.FullName;
				PatientFullName = saleOrPrescription.Prescription.Employee.FullName;
				Date = saleOrPrescription.Prescription.CreatedAt;

				medicines = saleOrPrescription.Prescription.MedicineBoxes;
			}

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
			result.SubItems.Add(Date.ToString(CultureInfo.InvariantCulture));
			result.SubItems.Add(TotalMedicine.ToString());
			result.SubItems.Add($@"{TotalPrice.ToString(CultureInfo.CurrentCulture)} ₺");

			return result;
		}
	}
}
