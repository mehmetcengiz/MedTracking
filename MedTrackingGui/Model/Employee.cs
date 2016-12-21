﻿using System.Collections.Generic;
using MedTrackingGui.Service;

namespace MedTrackingGui.Model {
  public class Employee {
    public int Id { get; }
    public Pharmacy Pharmacy { get; }
    public string Name { get; }
    public string Surname { get; }
    public string Phone { get; }

    public string FullName {
      get { return $@"{Name} {Surname}"; }
    }

    public Employee(int id, int pharmacyId, string name, string surname, string phone) {
      Id = id;
      Pharmacy = PharmacyService.GetPharmacyById(pharmacyId);
      Name = name;
      Surname = surname;
      Phone = phone;
    }

    public Employee(IReadOnlyList<object> parameters)
      : this((int) parameters[0], (int) parameters[1], (string) parameters[2],
        (string) parameters[3], (string) parameters[4]) {}
  }
}
