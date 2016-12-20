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

        public static List<List<object>> ExecuteQuery(string query)
        {
            // TODO Handle DB exception

            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = query
            };


            var result = new List<List<object>>();


            _sqlConnection.Open();
            command.Connection = _sqlConnection;
            var reader = command.ExecuteReader();

            List<object> tempColumns;
            IDataRecord tempRow;

            while (reader.Read())
            {
                tempRow = (IDataRecord)reader;
                var tempRowLength = tempRow.FieldCount;
                tempColumns = new List<object>(tempRowLength);

                for (var i = 0; i < tempRowLength; i++)
                {
                    tempColumns.Add(tempRow[i]);
                }

                result.Add(tempColumns);
            }

            _sqlConnection.Close();
            return result;
        }

        //public static bool DoLogin(string userName, string password) {
        //    var parameters = new Dictionary<string, string>(2) {
        //        {"userName", userName},
        //        {"password", password}
        //    };

        //    var result = ExecuteQuery(@"SELECT * FROM Employee WHERE Name = @userName AND Surname = @password",
        //        parameters);

        //    return result.Count != 0;
        //}

        //public static int GetPharmacyIdByEmployeeNameAndSurname(string userName, string password) {
        //    var parameters = new Dictionary<string, string>(2) {
        //        {"userName", userName},
        //        {"password", password}
        //    };

        //    var result = ExecuteQuery(@"SELECT Pharmacy.Id FROM Pharmacy INNER JOIN Employee ON Pharmacy.Id = Employee.PharmacyId WHERE Employee.Name = @userName AND Employee.Surname = @password",
        //        parameters);

        //    return (int) result[0][0];
        //}

        //public static bool AddNewMedicineGroup(string name) {
        //    return true;
        //}

        //public static Employee GetEmployeeByNameAndSurname(string name, string surname) {
        //    var parameters = new Dictionary<string, string>(2) {
        //        {"userName", name},
        //        {"password", surname}
        //    };

        //    var result = ExecuteQuery(@"SELECT * FROM Employee WHERE Name = @userName AND Surname = @password",
        //        parameters);

        //    if (result.Count == 0) {
        //        return null;
        //    }

        //    return null;
        //}
    }
}
