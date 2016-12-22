using System.Collections.Generic;
using MedTrackingGui.Model;

namespace MedTrackingGui.Service {
	public static class MedicineBoxService {
		public static List<MedicineBox> GetMedicineBoxesByPrescriptionId(int prescriptionId) {
			string query = $@"SELECT * FROM MedicineBox WHERE PrescriptionId = {prescriptionId}";
			var results = DBOperations.ExecuteQuery(query);

			if (results.Count == 0) {
				return new List<MedicineBox>(0);
			}

			var medicineBoxes = new List<MedicineBox>(results.Count);

			foreach (var result in results) {
				medicineBoxes.Add(new MedicineBox(result));
			}

			return medicineBoxes;
		}

		public static List<MedicineBox> GetMedicineBoxesBySaleId(int saleId) {
			string query = $@"SELECT * FROM MedicineBox WHERE SaleId = {saleId}";
			var results = DBOperations.ExecuteQuery(query);

			if (results.Count == 0) {
				return new List<MedicineBox>(0);
			}

			var medicineBoxes = new List<MedicineBox>(results.Count);

			foreach (var result in results) {
				medicineBoxes.Add(new MedicineBox(result));
			}

			return medicineBoxes;
		}

		public static int GetMedicineQuantityByMedicineId(int medicineId) {
			string query = $@"SELECT COUNT(QrCode) FROM MedicineBox WHERE MedicineId = {medicineId} AND SaleId IS NULL AND PrescriptionId IS NULL";
			var results = DBOperations.ExecuteQuery(query);

			return int.Parse(results[0][0].ToString());
		}
	}
}
