using System.Collections.Generic;

namespace MedTrackingGui.Model {
    public class Doctor {
        public int DiplomaNumber { get; private set; }
        public string Name { get; private set; }
        public string  Surname { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }

        public Doctor(int diplomaNumber, string name, string surname, string phone, string address) {
            DiplomaNumber = diplomaNumber;
            Name = name;
            Surname = surname;
            Phone = phone;
            Address = address;
        }

        public Doctor(List<object> parameters)
            : this((int) parameters[0], (string) parameters[1],(string) parameters[2],
                  (string) parameters[3],(string) parameters[4]) {
        }

    }
}