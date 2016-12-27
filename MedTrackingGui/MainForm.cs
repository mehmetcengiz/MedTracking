using System;
using System.Windows.Forms;
using MedTrackingGui.Controller;

namespace MedTrackingGui {
	public partial class MainForm : Form {
		MainFormController _mainFormController;

		public MainForm() {
			_mainFormController = new MainFormController();
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			PopulateList();
		}

		private void PopulateList() {
			var givenProducts = _mainFormController.GetLastGivenProducts();

			foreach (var givenProduct in givenProducts) {
				listViewSales.Items.Add(givenProduct.GetListViewItem());
			}
		}
		private void btnNewPrescription_Click(object sender, EventArgs e) {
			var newPrescription = new NewPrescription();

			if (newPrescription.ShowDialog(this) == DialogResult.OK) {
				PopulateList();
			}

			newPrescription.Dispose();
		}
	}
}
