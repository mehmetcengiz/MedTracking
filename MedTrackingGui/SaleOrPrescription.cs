using System;
using MedTrackingGui.Model;

namespace MedTrackingGui {
	public class SaleOrPrescription {
		public Sale Sale { get; } = null;
		public Prescription Prescription { get; } = null;
		public DateTime DateofTime { get; } // TODO This is unnecessary

		public SaleOrPrescription(Sale sale, DateTime dateofTime) {
			Sale = sale;
			this.DateofTime = dateofTime;
		}

		public SaleOrPrescription(Prescription prescription, DateTime dateofTime) {
			Prescription = prescription;
			this.DateofTime = dateofTime;
		}

	}
}
