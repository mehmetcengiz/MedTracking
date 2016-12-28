using System;
using System.Windows.Forms;
using MedTrackingGui.Service;

namespace MedTrackingGui {
	public partial class LoginForm : Form {
		public LoginForm() {
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e) {
			if (AuthService.DoLogin(txtBoxUserName.Text, txtBoxPassword.Text)) {
				// TODO Create Employee, Pharmacy and OTHER MODEL classes
				// TODO After successful login, instantiate Employee as User and Pharmacy

				MainForm mainform = new MainForm();
				mainform.Show();
				Hide();
			} else {
				MessageBox.Show(@"LoginForm Failed ! Username or Password is incorrect");
			}
		}

		private bool ConfirmQuit() {
			return (
				MessageBox.Show(this, @"Do you really want to quit from the application?", @"Quit Confirmation",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			if (ConfirmQuit()) {
				Application.Exit();
			}
		}

		private void LoginForm_FormClosing(object sender, FormClosingEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				e.Cancel = !ConfirmQuit();
			}
		}
	}
}
