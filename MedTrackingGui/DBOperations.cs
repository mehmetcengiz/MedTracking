using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MedTrackingGui {
    public static class DBOperations {
        private static SqlConnection _sqlConnection;

        public static void Initialize() {
            _sqlConnection =
                new SqlConnection("Data Source=DESKTOP-QAE100K;Initial Catalog=MedTrackingDB;Integrated Security=True");
        }

        public static List<List<object>> ExecuteQuery(string query) {
            return ExecuteQuery(query, new Dictionary<string, string>());
        }

        public static List<List<object>> ExecuteQuery(string query, Dictionary<string, string> parameters) {
            SqlCommand command = new SqlCommand {
                CommandType = CommandType.Text,
                CommandText = query
            };


            foreach (var parameter in parameters) {
                command.Parameters.Add(@"@" + parameter.Key, SqlDbType.VarChar).Value = parameter.Value;
            }

            var result = new List<List<object>>();
            List<object> tempColumns;
            IDataRecord tempRow;

            _sqlConnection.Open();
            command.Connection = _sqlConnection;
            var reader = command.ExecuteReader();

            while (reader.Read()) {
                tempRow = (IDataRecord) reader;
                var tempRowLength = tempRow.FieldCount;
                tempColumns = new List<object>(tempRowLength);

                for (var i = 0; i < tempRowLength; i++) {
                    tempColumns.Add(tempRow[i]);
                }

                result.Add(tempColumns);
            }

            _sqlConnection.Close();
            return result;
        }



        public static bool DoLogin(string userName, string password) {
            Dictionary<string, string> parameters = new Dictionary<string, string>(2) {
                {"userName", userName},
                {"password", password}
            };

            var result = ExecuteQuery(@"SELECT * FROM Employee WHERE Name = @userName AND Surname = @password", parameters);

            return result.Count != 0;
        }

        public static bool AddNewMedicineGroup(string name) {
            // TODO Implement here
            return true;
        }

        public static List<List<object>> GetAllEmployees() {
            return ExecuteQuery("SELECT * FROM Employee");
            /*
             * {1, 1, "John", "Doe", "5551234"} -> List<object>
             * ....
             * 
             */
        }
    }
}