using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MedTrackingGui.Model;
using MedTrackingGui.Service;

namespace MedTrackingGui {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            var sales = SalesService.GetLastSales(count: 30);
            var prescriptions = PrescriptionsService.GetLastPrescriptions(count: 30);

            var salesOrPrescriptions = new List<SaleOrPrescription>(60);

            foreach (var sale in sales) {
                salesOrPrescriptions.Add(new SaleOrPrescription(sale));
            }
            foreach (var prescription in prescriptions) {
                salesOrPrescriptions.Add(new SaleOrPrescription(prescription));
            }

            var givenProducts = new List<GivenProduct>();
            for (var i = 0; i < salesOrPrescriptions.Count; i++) {
                //givenProducts.Add(new GivenProduct(i + 1, salesOrPrescriptions[i]));
            }

            // TODO Combine `sales` and `prescriptions` into `givenProducts`
            
            foreach (var givenProduct in givenProducts) {
                listView1.Items.Add(givenProduct.GetListViewItem());
            }
        }
    }
}
