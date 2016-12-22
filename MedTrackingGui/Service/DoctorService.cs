using System.Collections.Generic;
using MedTrackingGui.Model;

namespace MedTrackingGui.Service {
	public static class DoctorService {
		public static Doctor GetDoctorByDiplomaNumber(int doctorDiplomaNumber) {
			string query = $@"SELECT * FROM Doctor WHERE DiplomaNumber = {doctorDiplomaNumber}";
			var results = DBOperations.ExecuteQuery(query);

			return results.Count == 0 ? null : new Doctor(results[0]);
		}

		public static List<Doctor> GetAllDoctors(int limit = 1000) {
			string query = $@"SELECT TOP {limit} * FROM Doctor";
			var results = DBOperations.ExecuteQuery(query);

			if (results.Count == 0) {
				return null;
			}

			var doctors = new List<Doctor>(results.Count);

			foreach (var result in results) {
				doctors.Add(new Doctor(result));
			}

			return doctors;
		}
	}
}
