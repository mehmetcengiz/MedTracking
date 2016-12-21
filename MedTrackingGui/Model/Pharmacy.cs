using System.Collections.Generic;

namespace MedTrackingGui.Model {
  public class Pharmacy {
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string PharmacistName { get; private set; }
    public string PharmacistSurname { get; private set; }
    public string Phone { get; private set; }
    public string Address { get; private set; }

    public Pharmacy(int id, string name, string pharmacistName, string pharmacistSurname, string phone, string address) {
      Id = id;
      Name = name;
      PharmacistName = pharmacistName;
      PharmacistSurname = pharmacistSurname;
      Phone = phone;
      Address = address;
    }

    public Pharmacy(IReadOnlyList<object> parameters)
      : this((int) parameters[0], (string) parameters[1], (string) parameters[2],
        (string) parameters[3], (string) parameters[4], (string) parameters[5]) {}
  }
}
