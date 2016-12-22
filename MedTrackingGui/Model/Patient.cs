using System.Collections.Generic;

namespace MedTrackingGui.Model {
	public class Patient {
		public int Id { get; private set; }
		public string Name { get; }
		public string Surname { get; }
		public string Phone { get; private set; }
		public string Address { get; private set; }

		public string FullName {
			get { return $@"{Name} {Surname}"; }
		}

		public Patient(int id, string name, string surname, string phone, string address) {
			Id = id;
			Name = name;
			Surname = surname;
			Phone = phone;
			Address = address;
		}

		public Patient(IReadOnlyList<object> parameters)
			: this((int) parameters[0], (string) parameters[1], (string) parameters[2],
				(string) parameters[3], parameters[4] as string) {}
	}
}
