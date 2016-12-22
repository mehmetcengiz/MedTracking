using System.Collections.Generic;

namespace MedTrackingGui.Model {
    public class Manufacturer {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Manufacturer(int id, string name) {
            Id = id;
            Name = name;
        }

        public Manufacturer(List<object> parameters)
            : this((int) parameters[0], (string) parameters[1]) {
        }
    }
}
