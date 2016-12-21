using MedTrackingGui.Model;

namespace MedTrackingGui.Service {
  public static class MedicineService {
    public static Medicine GetMedicineById(int id) {
      string query = $@"SELECT * FROM Medicine WHERE Id = {id}";
      var results = DBOperations.ExecuteQuery(query);

      return results.Count == 0 ? null : new Medicine(results[0]);
    }
  }
}
