using System;
using System.Windows.Forms;
using MedTrackingGui.Controller;
using MedTrackingGui.Service;

namespace MedTrackingGui {
	public partial class MainForm : Form {
		private readonly MainFormController _mainFormController = new MainFormController();

		public MainForm() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			PopulateList();
		}

		private void PopulateList() {
			listViewSales.Items.Clear();

			var givenProducts = _mainFormController.GetLastGivenProducts();

			foreach (var givenProduct in givenProducts) {
				listViewSales.Items.Add(givenProduct.GetListViewItem());
			}
		}

		private void ShowSelectedInfo() {
			if (listViewSales.SelectedItems.Count == 0) {
				return;
			}

			var type = listViewSales.SelectedItems[0].SubItems[1].Text;
			var id = int.Parse(listViewSales.SelectedItems[0].Tag.ToString());

			if (type.Equals("Sale")) {
				var showSaleInfo = new ShowSaleInfo(SalesService.GetSaleById(id));
				showSaleInfo.ShowDialog(this);
				showSaleInfo.Dispose();
			} else {
				var showPrescriptionInfo = new ShowPrescriptionInfo(PrescriptionsService.GetPrescriptionById(id));
				showPrescriptionInfo.ShowDialog(this);
				showPrescriptionInfo.Dispose();
			}
		}

		private void listViewSales_DoubleClick(object sender, EventArgs e) {
			ShowSelectedInfo();
		}

		private void listViewSales_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				ShowSelectedInfo();
			}
		}

		private void btnNewSale_Click(object sender, EventArgs e) {
			var newSale = new NewSaleForm();

			if (newSale.ShowDialog(this) == DialogResult.OK) {
				PopulateList();
			}

			newSale.Dispose();
		}

		private void btnNewPrescription_Click(object sender, EventArgs e) {
			var newPrescription = new NewPrescription();

			if (newPrescription.ShowDialog(this) == DialogResult.OK) {
				PopulateList();
			}

			newPrescription.Dispose();
		}

		private bool ConfirmQuit() {
			return (
				MessageBox.Show(this, @"Do you really want to quit from the application?", @"Quit Application",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				e.Cancel = !ConfirmQuit();
			}
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
			Application.Exit();
		}

		private void btnSearchEmployee_Click(object sender, EventArgs e) {
			var searchEmployee = new SearchEmployee();

			searchEmployee.ShowDialog(this);
			searchEmployee.Dispose();
		}
	}
}
