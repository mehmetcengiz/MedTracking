using MedTrackingGui.Model;

namespace MedTrackingGui.Service {
    class PatientService {
        public static Patient GetPatientById(int id) {
            string query = $@"SELECT * FROM Patient WHERE Id = {id}";
            var results = DBOperations.ExecuteQuery(query);

            return results.Count == 0 ? null : new Patient(results[0]);
        }
    }
}
