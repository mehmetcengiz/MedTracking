using MedTrackingGui.Model;

namespace MedTrackingGui.Service {
    public static class EmployeeService {
        public static Employee GetEmployeeById(int id) {
            string query = $@"SELECT * FROM Employee WHERE Id = {id}";
            var results = DBOperations.ExecuteQuery(query);

            return results.Count == 0 ? null : new Employee(results[0]);
        }
    }
}