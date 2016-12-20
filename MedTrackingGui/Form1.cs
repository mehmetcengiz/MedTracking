using System;
using System.Windows.Forms;
using MedTrackingGui.Service;

namespace MedTrackingGui
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (AuthService.DoLogin(txtBoxUserName.Text, txtBoxPassword.Text)) {
                // TODO Create Employee, Pharmacy and OTHER MODEL classes
                // TODO After successful login, instantiate Employee as User and Pharmacy

                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else {
                MessageBox.Show(@"Login Failed ! Username or Password is incorrect");
            }
        }
    }
}
