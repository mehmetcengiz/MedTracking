using System;
using System.Collections.Generic;
using MedTrackingGui.Service;

namespace MedTrackingGui.Model {
    public class Prescription {
        public int Id { get; private set; }
        public Employee Employee { get; private set; }
        public Patient Patient { get; private set; }
        public Doctor Doctor { get; private set; }
        public Pharmacy Pharmacy { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Prescription(int id, int employeeId, int patientId, int doctorDiplomaNumber, int pharmacyId, DateTime createdAt) {
            Id = id;
            Employee = EmployeeService.GetEmployeeById(employeeId);
            Patient = PatientService.GetPatientById(patientId);
            Doctor = DoctorService.GetDoctorByDiplomaNumber(doctorDiplomaNumber);
            Pharmacy = PharmacyService.GetPharmacyById(pharmacyId);
            CreatedAt = createdAt;
        }

        public Prescription(List<object> parameters)
            : this((int) parameters[0], (int) parameters[1], (int) parameters[2],
                  (int) parameters[3], (int) parameters[4], DateTime.Parse(parameters[5].ToString())) {
        }
    }
}
