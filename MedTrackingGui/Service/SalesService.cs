using System;
using System.Collections.Generic;
using MedTrackingGui.Model;

namespace MedTrackingGui.Service {
	public static class SalesService {
		public static Sale GetSaleById(int id) {
			string query = $@"SELECT * FROM Sale WHERE Id = {id}";
			var results = DBOperations.ExecuteQuery(query);

			return results.Count == 0 ? null : new Sale(results[0]);
		}

		public static List<Sale> GetLastSales(int count) {
			string query = $@"SELECT TOP {count} * FROM Sale ORDER BY SoldAt DESC";
			var results = DBOperations.ExecuteQuery(query);

			if (results.Count == 0) {
				return new List<Sale>(0);
			}

			var sales = new List<Sale>(results.Count);

			foreach (var result in results) {
				sales.Add(new Sale(result));
			}

			return sales;
		}

		public static int SaveNewAndGetSaleId() {
			var currentDateTime = DateTime.Now;
			var currentEmployeeId = AuthService.GetLoggedInEmployee().Id;
			var currentPharmacyId = AuthService.GetLoggedInEmployee().Pharmacy.Id;

			string query = $@"INSERT INTO Sale VALUES ({currentEmployeeId}, {currentPharmacyId}, '{currentDateTime:yyyy-MM-dd HH:mm:ss.fff}') SELECT SCOPE_IDENTITY()";
			var results = DBOperations.ExecuteQuery(query);

			return int.Parse(results[0][0].ToString());
		}
	}
}
