using System.Collections.Generic;

namespace MedTrackingGui.Model {
    public class Patient {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }

        public Patient(int id, string name, string surname, string phone, string address) {
            Id = id;
            Name = name;
            Surname = surname;
            Phone = phone;
            Address = address;
        }

        public Patient(List<object> parameters)
            : this((int) parameters[0], (string) parameters[1], (string) parameters[2],
                  (string) parameters[3], (string) parameters[4]) {
        }
    }
}
