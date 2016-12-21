using System.Collections.Generic;
using MedTrackingGui.Model;

namespace MedTrackingGui.Service {
  public static class PrescriptionsService {
    public static Prescription GetPrescriptionById(int id) {
      string query = $@"SELECT * FROM Prescription WHERE Id = {id}";
      var results = DBOperations.ExecuteQuery(query);

      return results.Count == 0 ? null : new Prescription(results[0]);
    }

    public static List<Prescription> GetLastPrescriptions(int count) {
      string query = $@"SELECT TOP {count} * FROM Prescription ORDER BY CreatedAt DESC";
      var results = DBOperations.ExecuteQuery(query);

      if (results.Count == 0) {
        return new List<Prescription>(0);
      }

      var prescriptions = new List<Prescription>(results.Capacity);

      foreach (var result in results) {
        prescriptions.Add(new Prescription(result));
      }

      return prescriptions;
    }
  }
}
