﻿using System.Collections.Generic;
using MedTrackingGui.Service;

namespace MedTrackingGui.Model {
  public class Medicine {
    public int Id { get; private set; }
    public Manufacturer Manufacturer { get; private set; }
    public string Name { get; private set; }
    public double Price { get; private set; }
    public string Ingredients { get; private set; }

    public Medicine(int id, int manufacturerId, string name, double price, string ingredients) {
      Id = id;
      Manufacturer = ManufacturerService.GetManufacturerById(manufacturerId);
      Name = name;
      Price = price;
      Ingredients = ingredients;
    }

    public Medicine(IReadOnlyList<object> parameters)
      : this(
        (int) parameters[0], (int) parameters[1], (string) parameters[2], (double) parameters[3], (string) parameters[4]
      ) {}
  }
}