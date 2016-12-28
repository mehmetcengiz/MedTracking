using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MedTrackingGui {
	public static class DBOperations {
		private static SqlConnection _sqlConnection;

		public static void Initialize() {
			_sqlConnection =
				//new SqlConnection("Data Source=DESKTOP-RUKSM9K;Initial Catalog=medtracking;Integrated Security=True");
				//new SqlConnection("Data Source=DESKTOP-QAE100K;Initial Catalog=medtracking;Integrated Security=True");
		}

		public static List<List<object>> ExecuteQuery(string query) {
			var command = new SqlCommand {
				CommandType = CommandType.Text,
				CommandText = query
			};

			var result = new List<List<object>>();

			_sqlConnection.Open();
			command.Connection = _sqlConnection;

			SqlDataReader reader;

			try {
				 reader = command.ExecuteReader();
			} catch (Exception e) {
				_sqlConnection.Close();

				throw e;
			}

			// ReSharper disable once TooWideLocalVariableScope
			List<object> tempColumns;

			while (reader.Read()) {
				var tempRowLength = reader.FieldCount;
				tempColumns = new List<object>(tempRowLength);

				for (var i = 0; i < tempRowLength; i++) {
					tempColumns.Add(reader[i]);
				}

				result.Add(tempColumns);
			}

			_sqlConnection.Close();
			return result;
		}

		public static List<List<object>> ExecuteStoredProcedure(string name, List<Tuple<string, string, SqlDbType>> parameters) {
			var command = new SqlCommand {
				CommandType = CommandType.StoredProcedure,
				CommandText = name
			};

			foreach (var parameter in parameters) {
				command.Parameters.Add($@"@{parameter.Item1}", parameter.Item3).Value = parameter.Item2;
			}

			var result = new List<List<object>>();

			_sqlConnection.Open();
			command.Connection = _sqlConnection;
			var reader = command.ExecuteReader();

			// ReSharper disable once TooWideLocalVariableScope
			List<object> tempColumns;

			while (reader.Read()) {
				var tempRowLength = reader.FieldCount;
				tempColumns = new List<object>(tempRowLength);

				for (var i = 0; i < tempRowLength; i++) {
					tempColumns.Add(reader[i]);
				}

				result.Add(tempColumns);
			}

			_sqlConnection.Close();
			return result;
		}
	}
}
