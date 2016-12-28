using System;
using System.Globalization;
using System.Windows.Forms;
using MedTrackingGui.Model;

namespace MedTrackingGui {
	public partial class ShowPrescriptionInfo : Form {
		public Prescription Prescription { get; }

		public ShowPrescriptionInfo(Prescription prescription) {
			Prescription = prescription;

			InitializeComponent();
		}

		private void ShowPrescriptionInfo_Load(object sender, EventArgs e) {
			listViewMedicines.Items.Clear();

			tbEmployeeFullName.Text = Prescription.Employee.FullName;
			tbDoctorFullName.Text = Prescription.Doctor.FullName;
			tbPatientFullName.Text = Prescription.Patient.FullName;
			tbDateAndTime.Text = Prescription.CreatedAt.ToString(CultureInfo.CurrentCulture);

			for (int i = 0; i < Prescription.MedicineBoxes.Count; i++) {
				listViewMedicines.Items.Add(new ListViewItem(new [] {
					(i + 1).ToString(),
					Prescription.MedicineBoxes[i].Medicine.Name,
					$@"{Prescription.MedicineBoxes[i].AcquisitionCost.ToString(CultureInfo.InvariantCulture)} ₺"
				}));
			}
		}

		private void btnOk_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
		}
	}
}
