using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using MedTrackingGui.Controller;

namespace MedTrackingGui {
	public partial class NewPrescription : Form {
		private readonly NewPrescriptionController _newPrescriptionController = new NewPrescriptionController();

		public NewPrescription() {
			InitializeComponent();
		}

		private void NewPrescription_Load(object sender, EventArgs e) {
			listViewMedicines.Items.Clear();

			var patientFullNames = _newPrescriptionController.GetPatientFullNames();
			var doctorsFullNames = _newPrescriptionController.GetDoctorFullNames();
			var medicineNames = _newPrescriptionController.GetMedicineNamesAndStockQuantities();

			foreach (var patientFullName in patientFullNames) {
				cbPatientFullNames.Items.Add(patientFullName);
			}
			foreach (var doctorsFullName in doctorsFullNames) {
				cbDoctorFullNames.Items.Add("Dr. " + doctorsFullName);
			}
			foreach (var medicineName in medicineNames) {
				cbMedicines.Items.Add(medicineName);
			}
		}

		private void btnAddMedicineToList_Click(object sender, EventArgs e) {
			// Gather medicine's information to add
			var medicineIndex = cbMedicines.SelectedIndex;
			var medicineName = cbMedicines.SelectedItem.ToString().Split('-')[0].TrimEnd(' ');
			var medicineQuantity = int.Parse(cbMedicines.SelectedItem.ToString().Split('-')[1].TrimEnd(' '));
			var medicineNeeded = int.Parse(nudQuantity.Value.ToString(CultureInfo.CurrentCulture));

			// Add the medicine to the list with gathered info
			var addedMedicine = new ListViewItem((listViewMedicines.Items.Count + 1).ToString());
			addedMedicine.SubItems.Add(medicineName);
			addedMedicine.SubItems.Add(medicineNeeded.ToString());

			listViewMedicines.Items.Add(addedMedicine);

			// Reset inputs
			cbMedicines.SelectedIndex = 0;
			cbMedicines.Text = @"";
			nudQuantity.Text = @"0";

			// Update remaining qty and remove the medicine from combobox if qty zeroed out
			medicineQuantity -= medicineNeeded;

			if (medicineQuantity == 0) {
				cbMedicines.Items.RemoveAt(medicineIndex);
			} else {
				cbMedicines.Items[medicineIndex] = $@"{medicineName} - {medicineQuantity}";
			}
		}

		private void cbMedicines_SelectedIndexChanged(object sender, EventArgs e) {
			// Disable the add button if no medicine is selected
			if (cbMedicines.Text.Equals(string.Empty)) {
				btnAddMedicineToList.Enabled = false;

				return;
			}

			// Get quantity for the medicine and set as numeric up/down's maximum
			var qty = int.Parse(cbMedicines.SelectedItem.ToString().Split('-')[1].TrimEnd(' '));

			nudQuantity.Maximum = qty;

			// Enable the add button if other (numeric up/downs value is greater than 0) conditions also met
			if (int.Parse(nudQuantity.Value.ToString(CultureInfo.CurrentCulture)) > 0) {
				btnAddMedicineToList.Enabled = true;
			}
		}

		private void nudQuantity_ValueChanged(object sender, EventArgs e) {
			if (int.Parse(nudQuantity.Value.ToString(CultureInfo.CurrentCulture)) == 0) {
				// Disable the add button if numeric up/down's value is 0...
				btnAddMedicineToList.Enabled = false;
			} else if (!cbMedicines.Text.Equals(string.Empty)) {
				// ... if not enable the add button if other (is there any medicine selected) conditions also met
				btnAddMedicineToList.Enabled = true;
			}
		}
	}
}
