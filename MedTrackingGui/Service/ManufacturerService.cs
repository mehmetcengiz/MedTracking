using MedTrackingGui.Model;

namespace MedTrackingGui.Service {
  public static class ManufacturerService {
    public static Manufacturer GetManufacturerById(int id) {
      string query = $@"SELECT * FROM Manufacturer WHERE Id = {id}";
      var results = DBOperations.ExecuteQuery(query);

      return results.Count == 0 ? null : new Manufacturer(results[0]);
    }
  }
}
