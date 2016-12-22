using System.Collections.Generic;
using MedTrackingGui.Model;

namespace MedTrackingGui.Service {
	class PatientService {
		public static Patient GetPatientById(int id) {
			string query = $@"SELECT * FROM Patient WHERE Id = {id}";
			var results = DBOperations.ExecuteQuery(query);

			return results.Count == 0 ? null : new Patient(results[0]);
		}

		public static List<Patient> GetAllPatients(int limit = 1000) {
			string query = $@"SELECT TOP {limit} * FROM Patient";
			var results = DBOperations.ExecuteQuery(query);

			if (results.Count == 0) {
				return null;
			}

			List<Patient> patients = new List<Patient>(results.Count);

			foreach (var result in results) {
				patients.Add(new Patient(result));
			}

			return patients;
		}
	}
}
