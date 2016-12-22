using MedTrackingGui.Model;

namespace MedTrackingGui.Service {
    public static class SupplierService {
        public static Supplier GetSupplierById(int id) {
            string query = $@"SELECT * FROM Supplier WHERE Id = {id}";
            var results = DBOperations.ExecuteQuery(query);

            return results.Count == 0 ? null : new Supplier(results[0]);
        }
    }
}
