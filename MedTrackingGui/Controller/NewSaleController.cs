using System;
using System.Collections.Generic;
using MedTrackingGui.Model;
using MedTrackingGui.Service;

namespace MedTrackingGui.Controller {
	class NewSaleController {
		public List<string> GetMedicineNamesAndStockQuantities() {
			var medicinesInStock = MedicineService.GetAllMedicinesInStock();

			var results = new List<string>(medicinesInStock.Count);

			foreach (var medicine in medicinesInStock) {
				results.Add($@"{medicine.Name} - {medicine.Quantity}");
			}

			return results;
		}

		public void SaveSale(List<Tuple<string, int>> medicineBoxNamesAndQuantities) {
			List<MedicineBox> medicineBoxes = new List<MedicineBox>(medicineBoxNamesAndQuantities.Count);

			foreach (var medicineBoxNameAndQuantity in medicineBoxNamesAndQuantities) {
				medicineBoxes.AddRange(MedicineBoxService.GetUnsoldMedicineBoxesByMedicineName(medicineBoxNameAndQuantity.Item1, medicineBoxNameAndQuantity.Item2));
			}

			var newSaleId = SalesService.SaveNewAndGetSaleId();

			foreach (var medicineBox in medicineBoxes) {
				MedicineBoxService.UpdateMedicineBoxSaleId(medicineBox, newSaleId);
			}
		}
	}
}
