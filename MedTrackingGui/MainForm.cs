using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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
      //var givenProducts = new List<GivenProduct>(60); // 60 = 30 + 30

      foreach (var sale in sales) {
        salesOrPrescriptions.Add(new SaleOrPrescription(sale,sale.SoldAt));
      }
      foreach (var prescription in prescriptions) {
        salesOrPrescriptions.Add(new SaleOrPrescription(prescription,prescription.CreatedAt));
      }
      List<SaleOrPrescription> sortedSaleOrPrescriptions = salesOrPrescriptions.OrderByDescending(o => o.DateofTime).ToList();


      //TODO add list to view.


        //foreach (var givenProduct in givenProducts) {
        //  listViewSales.Items.Add(givenProduct.GetListViewItem());
        //}
    }
  }
}
