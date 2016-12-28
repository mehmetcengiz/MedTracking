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

		public static int GetIdByFullName(string patientFullName) {
			List<string> names = new List<string>(patientFullName.Split(' '));
			string surname = names[names.Count - 1];
			names.RemoveAt(names.Count - 1);
			string name = "";
			foreach (var s in names) {
				name += s + ' ';
			}
			name = name.TrimEnd(' ');

			string query = $@"SELECT Id FROM Patient WHERE Name = '{name}' AND Surname = '{surname}'";
			var results = DBOperations.ExecuteQuery(query);

			return results.Count == 0 ? -1 : (int) results[0][0];
		}

		public static void AddNewPatient(string name, string surname, string phone, string address) {
			string query = $@"INSERT INTO Patient VALUES ('{name}', '{surname}', '{phone}', '{address}')";
			var results = DBOperations.ExecuteQuery(query);
		}
	}
}
