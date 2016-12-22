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
			var givenProducts = _mainFormController.GetLastGivenProducts();

			//TODO add list to view.
			foreach (var givenProduct in givenProducts) {
				listViewSales.Items.Add(givenProduct.GetListViewItem());
			}
		}
	}
}
