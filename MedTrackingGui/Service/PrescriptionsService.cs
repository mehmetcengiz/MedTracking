using System.Collections.Generic;
using MedTrackingGui.Model;

namespace MedTrackingGui.Service {
    public static class PrescriptionsService {
        public static List<Prescription> GetLastPrescriptions(int count) {
            string query = $@"SELECT TOP {count} * FROM Prescription ORDER BY SoldAt DESC";
            var results = DBOperations.ExecuteQuery(query);

            if (results.Count == 0) {
                return new List<Prescription>(0);
            }

            List<Prescription> prescriptions = new List<Prescription>(results.Capacity);

            foreach (var result in results) {
                prescriptions.Add(new Prescription(result));
            }

            return prescriptions;
        }
    }
}