using System;
using System.Collections.Generic;
using MedTrackingGui.Service;

namespace MedTrackingGui.Model {
    public class Sale {
        public int Id { get; private set; }
        public Employee Employee { get; private set; }
        public Pharmacy Pharmacy { get; private set; }
        public DateTime SoldAt { get; private set; }

        public List<MedicineBox> MedicineBoxes { get; private set; }

        public Sale(int id, int employeeId, int pharmacyId, DateTime soldAt) {
            Id = id;
            Employee = EmployeeService.GetEmployeeById(employeeId);
            Pharmacy = PharmacyService.GetPharmacyById(pharmacyId);
            SoldAt = soldAt;

            MedicineBoxes = MedicineBoxService.GetMedicineBoxesBySaleId(id);
        }

        public Sale(IReadOnlyList<object> parameters)
            : this(
                (int) parameters[0], (int) parameters[1], (int) parameters[2], DateTime.Parse(parameters[3].ToString())) {
        }
    }
}
