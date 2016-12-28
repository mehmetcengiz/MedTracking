using System;
using System.Globalization;
using System.Windows.Forms;
using MedTrackingGui.Model;

namespace MedTrackingGui {
	public partial class ShowSaleInfo : Form {
		public Sale Sale { get; }

		public ShowSaleInfo(Sale sale) {
			Sale = sale;

			InitializeComponent();
		}

		private void ShowSaleInfo_Load(object sender, EventArgs e) {
			listViewMedicines.Items.Clear();

			tbEmployeeFullName.Text = Sale.Employee.FullName;
			tbDateAndTime.Text = Sale.SoldAt.ToString(CultureInfo.CurrentCulture);

			for (int i = 0; i < Sale.MedicineBoxes.Count; i++) {
				listViewMedicines.Items.Add(new ListViewItem(new[] {
					(i + 1).ToString(),
					Sale.MedicineBoxes[i].Medicine.Name,
					$@"{Sale.MedicineBoxes[i].AcquisitionCost.ToString(CultureInfo.InvariantCulture)} ₺"
				}));
			}
		}

		private void btnOk_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
		}
	}
}
