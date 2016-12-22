using System;
using System.Collections.Generic;
using MedTrackingGui.Model;

namespace MedTrackingGui.Service {
	public static class MedicineService {
		public static Medicine GetMedicineById(int id) {
			string query = $@"SELECT * FROM Medicine WHERE Id = {id}";
			var results = DBOperations.ExecuteQuery(query);

			return results.Count == 0 ? null : new Medicine(results[0]);
		}

		public static List<Medicine> GetAllMedicines(int limit = 1000) {
			var query = $@"SELECT TOP {limit} * FROM Medicine";
			var results = DBOperations.ExecuteQuery(query);

			if (results.Count == 0) {
				return null;
			}

			var medicines = new List<Medicine>(results.Count);

			foreach (var result in results) {
				medicines.Add(new Medicine(result));
			}

			return medicines;
		}

		public static List<Medicine> GetAllMedicinesInStock(int limit = 1000) {
			var query = $@"
SELECT TOP {limit} Medicine.Id, Medicine.ManufacturerId, Medicine.[Name], Medicine.Price, Medicine.Ingredients, COUNT(*) AS QTY
FROM Medicine
WHERE Medicine.Id IN (
	SELECT MedicineBox.MedicineId
	FROM MedicineBox
	WHERE MedicineBox.PrescriptionId IS NULL AND MedicineBox.SaleId IS NULL
)
GROUP BY Medicine.Id, Medicine.ManufacturerId, Medicine.[Name], Medicine.Price, Medicine.Ingredients
";
			var results = DBOperations.ExecuteQuery(query);

			if (results.Count == 0) {
				return null;
			}

			var medicines = new List<Medicine>(results.Count);

			foreach (var result in results) {
				medicines.Add(new Medicine(result));
			}

			return medicines;
		}
	}
}
