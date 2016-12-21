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

      var sales = new List<Sale>(results.Capacity);

      foreach (var result in results) {
        sales.Add(new Sale(result));
      }

      return sales;
    }
  }
}
