using System.Collections.Generic;

namespace MedTrackingGui.Model {
  public class Doctor {
    public int DiplomaNumber { get; private set; }
    public string Name { get; }
    public string Surname { get; }
    public string Phone { get; private set; }
    public string Address { get; private set; }

    public string FullName {
      get { return $@"{Name} {Surname}"; }
    }

    public Doctor(int diplomaNumber, string name, string surname, string phone, string address) {
      DiplomaNumber = diplomaNumber;
      Name = name;
      Surname = surname;
      Phone = phone;
      Address = address;
    }

    public Doctor(IReadOnlyList<object> parameters)
      : this((int) parameters[0], (string) parameters[1], (string) parameters[2],
        (string) parameters[3], (string) parameters[4]) {}
  }
}
