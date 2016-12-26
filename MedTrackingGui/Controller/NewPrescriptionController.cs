using System;
using System.Collections.Generic;
using MedTrackingGui.Model;
using MedTrackingGui.Service;

namespace MedTrackingGui.Controller {
	class NewPrescriptionController {
		public List<string> GetPatientFullNames() {
			var patients = PatientService.GetAllPatients();

			var results = new List<string>(patients.Count);

			foreach (var patient in patients) {
				results.Add(patient.FullName);
			}

			return results;
		}

		public List<string> GetDoctorFullNames() {
			var doctors = DoctorService.GetAllDoctors();

			var results = new List<string>(doctors.Count);

			foreach (var doctor in doctors) {
				results.Add(doctor.FullName);
			}

			return results;
		}

		public List<string> GetMedicineNamesAndStockQuantities() {
			var medicinesInStock = MedicineService.GetAllMedicinesInStock();

			var results = new List<string>(medicinesInStock.Count);

			foreach (var medicine in medicinesInStock) {
				results.Add($@"{medicine.Name} - {medicine.Quantity}");
			}

			return results;
		}

		public void SavePrescription(string patientFullName, string doctorFullName, List<Tuple<string, int>> medicineBoxNamesAndQuantities) {
			int patientId = PatientService.GetIdByFullName(patientFullName);
			int doctorDiplomaNumber = DoctorService.GetDiplomaNumberByFullName(doctorFullName);
			List<MedicineBox> medicineBoxes = new List<MedicineBox>(medicineBoxNamesAndQuantities.Count);

			foreach (var medicineBoxNameAndQuantity in medicineBoxNamesAndQuantities) {
				medicineBoxes.AddRange(MedicineBoxService.GetUnsoldMedicineBoxesByMedicineName(medicineBoxNameAndQuantity.Item1, medicineBoxNameAndQuantity.Item2));
			}

			var newPrescriptionId = PrescriptionsService.SaveNewAndGetPrescriptionId(patientId, doctorDiplomaNumber);

			foreach (var medicineBox in medicineBoxes) {
				MedicineBoxService.UpdateMedicineBoxPrescriptionId(medicineBox,newPrescriptionId);
			}
		}
	}
}
