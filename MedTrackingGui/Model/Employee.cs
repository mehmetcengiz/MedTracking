using System.Collections.Generic;
using MedTrackingGui.Service;

namespace MedTrackingGui.Model {
    public class Employee {
        public int Id { get; }
        public Pharmacy Pharmacy { get; }
        public string Name { get; }
        public string Surname { get; }
        public string Phone { get; }

        public Employee(int id, int pharmacyId, string name, string surname, string phone) {
            this.Id = id;
            this.Pharmacy = PharmacyService.GetPharmacyById(pharmacyId);
            this.Name = name;
            this.Surname = surname;
            this.Phone = phone;
        }

        public Employee(List<object> parameters)
            : this((int) parameters[0], (int) parameters[1], (string) parameters[2],
                  (string) parameters[3], (string) parameters[4]) {
        }
    }
}
