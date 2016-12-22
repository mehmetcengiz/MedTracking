using MedTrackingGui.Model;

namespace MedTrackingGui.Service {
	public static class DoctorService {
		public static Doctor GetDoctorByDiplomaNumber(int doctorDiplomaNumber) {
			string query = $@"SELECT * FROM Doctor WHERE DiplomaNumber = {doctorDiplomaNumber}";
			var results = DBOperations.ExecuteQuery(query);

			return results.Count == 0 ? null : new Doctor(results[0]);
		}
	}
}
