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

		public static IEnumerable<MedicineBox> GetUnsoldMedicineBoxesByMedicineName(string medicineName, int quantity) {
			int medicineId = MedicineService.GetIdByMedicineName(medicineName);

			// TODO Get quantity times medicine box which has sale and pres. id's are both null
			string query = $@"SELECT TOP {quantity} * FROM MedicineBox WHERE MedicineId = {medicineId} AND SaleId IS NULL AND PrescriptionId IS NULL";
			var results = DBOperations.ExecuteQuery(query);

			if (results.Count == 0) {
				return new List<MedicineBox>(0);
			}

			List<MedicineBox> medicineBoxes = new List<MedicineBox>(results.Count);

			foreach (var result in results) {
				medicineBoxes.Add(new MedicineBox(result));
			}

			return medicineBoxes;
		}

		public static void UpdateMedicineBoxPrescriptionId(MedicineBox medicineBox, int newPrescriptionId) {
			string query = $@"UPDATE MedicineBox SET PrescriptionId= {newPrescriptionId} WHERE QrCode={medicineBox.QrCode}";
			var results = DBOperations.ExecuteQuery(query);

		}
	}
}
