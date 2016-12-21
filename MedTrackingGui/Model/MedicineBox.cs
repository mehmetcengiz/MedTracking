using System;
using System.Collections.Generic;
using MedTrackingGui.Service;

namespace MedTrackingGui.Model {
  public class MedicineBox {
    public int QrCode { get; private set; }
    public Prescription Prescription { get; private set; }
    public Sale Sale { get; private set; }
    public Medicine Medicine { get; private set; }
    public Pharmacy Pharmacy { get; private set; }
    public Supplier Supplier { get; private set; }
    public DateTime ArrivedAt { get; private set; }
    public double AcquisitionCost { get; private set; }

    public MedicineBox(int qrCode, int? prescriptionId, int? saleId, int medicineId, int pharmacyId, int supplierId,
      DateTime arrivedAt, double acquisitonCost) {
      QrCode = qrCode;

      if (prescriptionId.HasValue) {
        Prescription = PrescriptionsService.GetPrescriptionById(prescriptionId.Value);
      }

      if (saleId.HasValue) {
        Sale = SalesService.GetSaleById(saleId.Value);
      }

      Medicine = MedicineService.GetMedicineById(medicineId);
      Pharmacy = PharmacyService.GetPharmacyById(pharmacyId);
      Supplier = SupplierService.GetSupplierById(supplierId);
      ArrivedAt = arrivedAt;
      AcquisitionCost = acquisitonCost;
    }

    public MedicineBox(List<object> parameters)
      : this(
        (int) parameters[0], (int?) parameters[1], (int?) parameters[2], (int) parameters[3], (int) parameters[4],
        (int) parameters[5], DateTime.Parse(parameters[6].ToString()), (double) parameters[7]) {}
  }
}
