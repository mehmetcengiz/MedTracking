using System.Collections.Generic;
using System.Linq;
using MedTrackingGui.Model;
using MedTrackingGui.Service;

namespace MedTrackingGui.Controller {
	class MainFormController {
		public List<GivenProduct> GetLastGivenProductsForThePharmacy() {
			//Get List of Sale and List of Prescriptions
			var sales = SalesService.GetLastSalesForThePharmacy(count: 30);
			var prescriptions = PrescriptionsService.GetLastPrescriptionsForThePharmacy(count: 30);

			//Merge Sales and List to Single List
			var salesOrPrescription = MergeSalesAndPrescriptions(sales, prescriptions);

			//Sort the List
			var sortedSalesOrPrescriptions = SortSalesOrPrescriptionByDate(salesOrPrescription);

			//Change type to GivenProduct from Sorted SalesOrPrescriptions List
			var givenProducts = new List<GivenProduct>(30);

			for (int index = 0; index < givenProducts.Capacity; index++) {
				givenProducts.Add(new GivenProduct(index + 1, sortedSalesOrPrescriptions[index]));
			}

			return givenProducts;

		}

		private List<SaleOrPrescription> MergeSalesAndPrescriptions(List<Sale> sales, List<Prescription> prescriptions) {
			List<SaleOrPrescription> salesOrPrescription =
				new List<SaleOrPrescription>(sales.Count + prescriptions.Count);

			foreach (var sale in sales) {
				salesOrPrescription.Add(new SaleOrPrescription(sale, sale.SoldAt));
			}
			foreach (var prescription in prescriptions) {
				salesOrPrescription.Add(new SaleOrPrescription(prescription, prescription.CreatedAt));
			}

			return salesOrPrescription;
		}

		private List<SaleOrPrescription> SortSalesOrPrescriptionByDate(List<SaleOrPrescription> salesOrPrescriptions) {

			var sortedSaleOrPrescriptions =
				salesOrPrescriptions.OrderByDescending(o => o.DateofTime).ToList();
			return sortedSaleOrPrescriptions;
		}
	}
}
