using MedTrackingGui.Model;

namespace MedTrackingGui.Service {
    static class AuthService {
        private static Employee _loggedInEmployee;

        public static Employee GetLoggedInEmployee() {
            return _loggedInEmployee;
        }

        public static bool DoLogin(string username, string password) {
            string query = $@"SELECT * FROM Employee WHERE Name = {username} AND Surname = {password}";

            var result = DBOperations.ExecuteQuery(query);

            if (result.Count == 0) {
                return false;
            }

            var employee = result[0];

            // TODO Assign logged in user
            _loggedInEmployee = new Employee((int) employee[0], (int) employee[1],
                (string) employee[2], (string) employee[3],
                (string) employee[4]);

            return true;
        }

        // TODO Implement DoLogOut method
    }
}
