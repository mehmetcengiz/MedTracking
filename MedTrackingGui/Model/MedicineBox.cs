using System;
using System.Collections.Generic;
using MedTrackingGui.Service;

namespace MedTrackingGui.Model {
	public class MedicineBox {
		public int QrCode { get; private set; }

		public Prescription Prescription => _prescriptionId.HasValue ? PrescriptionsService.GetPrescriptionById(_prescriptionId.Value) : null;

		public Sale Sale => _saleId.HasValue ? SalesService.GetSaleById(_saleId.Value) : null;
		public Medicine Medicine => MedicineService.GetMedicineById(_medicineId);
		public Pharmacy Pharmacy => PharmacyService.GetPharmacyById(_pharmacyId);
		public Supplier Supplier => SupplierService.GetSupplierById(_supplierId);
		public DateTime ArrivedAt { get; private set; }
		public double AcquisitionCost { get; private set; }

		private int? _prescriptionId;
		private int? _saleId;
		private readonly int _medicineId;
		private readonly int _pharmacyId;
		private readonly int _supplierId;

		public MedicineBox(int qrCode, int? prescriptionId, int? saleId, int medicineId, int pharmacyId, int supplierId,
			DateTime arrivedAt, double acquisitonCost) {
			QrCode = qrCode;
			_prescriptionId = prescriptionId;
			_saleId = saleId;
			_medicineId = medicineId;
			_pharmacyId = pharmacyId;
			_supplierId = supplierId;

			ArrivedAt = arrivedAt;
			AcquisitionCost = acquisitonCost;
		}

		public MedicineBox(IReadOnlyList<object> parameters)
			: this(
				(int) parameters[0], parameters[1] as int?, parameters[2] as int?, (int) parameters[3],
				(int) parameters[4], (int) parameters[5], DateTime.Parse(parameters[6].ToString()),
				(double) parameters[7]) {}
	}
}
