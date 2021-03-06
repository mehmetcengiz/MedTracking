﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using MedTrackingGui.Controller;

namespace MedTrackingGui {
	public partial class NewSaleForm : Form {
		private readonly NewSaleController _newSaleController = new NewSaleController();

		private bool IsDirty => listViewMedicines.Items.Count > 0;

		private void EnableSaveButton() {
			btnSave.Enabled = listViewMedicines.Items.Count > 0;
		}

		public NewSaleForm() {
			InitializeComponent();
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

		private void NewSale_Load(object sender, EventArgs e) {
			listViewMedicines.Items.Clear();

			var medicineNames = _newSaleController.GetMedicineNamesAndStockQuantities();

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

			EnableSaveButton();

			DialogResult = DialogResult.None;
		}

		private void btnSave_Click(object sender, EventArgs e) {
			List<Tuple<string, int>> medicines = new List<Tuple<string, int>>(listViewMedicines.Items.Count);

			foreach (ListViewItem item in listViewMedicines.Items) {
				medicines.Add(new Tuple<string, int>(item.SubItems[1].Text, int.Parse(item.SubItems[2].Text)));
			}

			_newSaleController.SaveSale(medicines);

			DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			if (IsDirty) {
				if (MessageBox.Show(this, @"Changes will be disposed upon close. Are you sure to close the dialog?",
					    @"Cancel New Sale",
					    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					DialogResult = DialogResult.Cancel;
				} else {
					DialogResult = DialogResult.None;
				}
			}
		}

		private void NewSale_FormClosing(object sender, FormClosingEventArgs e) {
			if (IsDirty && e.CloseReason == CloseReason.UserClosing) {
				if (MessageBox.Show(this, @"Changes will be disposed upon close. Are you sure to close the dialog?",
					    @"Cancel New Sale",
					    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
					e.Cancel = true;
				}
			}
		}
	}
}
