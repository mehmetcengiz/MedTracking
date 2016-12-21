using System;
using MedTrackingGui.Model;

namespace MedTrackingGui {
  class SaleOrPrescription {
    private Sale _sale = null;
    private Prescription _prescription = null;
    private DateTime _dateofTime;

    public SaleOrPrescription(Sale sale,DateTime dateofTime) {
        _sale = sale;
        this._dateofTime = dateofTime;
    }

    public SaleOrPrescription(Prescription prescription, DateTime dateofTime) {
        _prescription = prescription;
        this._dateofTime = dateofTime;

    }

      public DateTime DateofTime {
          get { return _dateofTime; }
      }
  }
}
