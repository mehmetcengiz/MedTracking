using MedTrackingGui.Model;

namespace MedTrackingGui.Service {
	public static class PharmacyService {
		public static Pharmacy GetPharmacyById(int id) {
			string query = $@"SELECT * FROM Pharmacy WHERE Id = {id}";
			var results = DBOperations.ExecuteQuery(query);

			return results.Count == 0 ? null : new Pharmacy(results[0]);
		}
	}
}
