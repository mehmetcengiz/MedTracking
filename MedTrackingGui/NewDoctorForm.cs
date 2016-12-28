using System;
using System.Windows.Forms;
using MedTrackingGui.Service;

namespace MedTrackingGui {
	public partial class NewDoctorForm : Form {
		private bool IsDirty
			=>
				tbDiplomaNumber.TextLength > 0 || tbName.TextLength > 0 || tbSurname.TextLength > 0 || tbPhone.TextLength > 0 ||
				tbAddress.TextLength > 0;

		private void EnableSaveButton() {
			btnSave.Enabled = tbDiplomaNumber.TextLength > 0 && tbName.TextLength > 0 && tbSurname.TextLength > 0 &&
			                  tbPhone.TextLength > 0 && tbAddress.TextLength > 0;
		}

		public NewDoctorForm() {
			InitializeComponent();
		}

		private void tbDiplomaNumber_TextChanged(object sender, EventArgs e) {
			EnableSaveButton();
		}

		private void tbName_TextChanged(object sender, EventArgs e) {
			EnableSaveButton();
		}

		private void tbSurname_TextChanged(object sender, EventArgs e) {
			EnableSaveButton();
		}

		private void tbPhone_TextChanged(object sender, EventArgs e) {
			EnableSaveButton();
		}

		private void tbAddress_TextChanged(object sender, EventArgs e) {
			EnableSaveButton();
		}

		private void btnSave_Click(object sender, EventArgs e) {
			var diplomaNumber = int.Parse(tbDiplomaNumber.Text);
			var name = tbName.Text;
			var surname = tbSurname.Text;
			var phone = tbPhone.Text;
			var address = tbAddress.Text;

			try {
				DoctorService.AddNewDoctor(diplomaNumber, name, surname, phone, address);

				MessageBox.Show(this, @"New doctor record created.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				DialogResult = DialogResult.OK;
			} catch (Exception exception) {
				MessageBox.Show(this, $@"Error occured while creating a new doctor record.\n{exception.Message}", @"Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			if (IsDirty) {
				if (MessageBox.Show(this, @"Changes will be disposed upon close. Are you sure to close the dialog?",
						@"Cancel Add New Doctor",
						MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					DialogResult = DialogResult.Cancel;
				} else {
					DialogResult = DialogResult.None;
				}
			}
		}

		private void NewDoctorForm_FormClosing(object sender, FormClosingEventArgs e) {
			if (IsDirty && e.CloseReason == CloseReason.UserClosing) {
				if (MessageBox.Show(this, @"Changes will be disposed upon close. Are you sure to close the dialog?",
						@"Cancel Add New Doctor",
						MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
					e.Cancel = true;
				}
			}
		}
	}
}
