using System.Collections.Generic;

namespace MedTrackingGui.Model {
	public class Supplier {
		public int Id { get; private set; }
		public string Name { get; private set; }
		public string Phone { get; private set; }
		public string Address { get; private set; }

		public Supplier(int id, string name, string phone, string address) {
			Id = id;
			Name = name;
			Phone = phone;
			Address = address;
		}

		public Supplier(List<object> parameters)
			: this((int) parameters[0], (string) parameters[1], (string) parameters[2], (string) parameters[3]) {}
	}
}
