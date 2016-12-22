using System;
using System.Collections.Generic;
using MedTrackingGui.Service;

namespace MedTrackingGui.Model {
    public class Prescription {
        public int Id { get; private set; }

        public Employee Employee => EmployeeService.GetEmployeeById(_employeeId);
        public Patient Patient => PatientService.GetPatientById(_patientId);
        public Doctor Doctor => DoctorService.GetDoctorByDiplomaNumber(_doctorDiplomaNumber);
        public Pharmacy Pharmacy => PharmacyService.GetPharmacyById(_pharmacyId);
        public DateTime CreatedAt { get; }
        public List<MedicineBox> MedicineBoxes { get; private set; }

        private readonly int _employeeId;
        private readonly int _patientId;
        private readonly int _doctorDiplomaNumber;
        private readonly int _pharmacyId;


        public Prescription(int id, int employeeId, int patientId, int doctorDiplomaNumber, int pharmacyId,
            DateTime createdAt) {
            Id = id;
            _employeeId = employeeId;
            _patientId = patientId;
            _doctorDiplomaNumber = doctorDiplomaNumber;
            _pharmacyId = pharmacyId;


            CreatedAt = createdAt;

            MedicineBoxes = MedicineBoxService.GetMedicineBoxesByPrescriptionId(id);
        }

        public Prescription(IReadOnlyList<object> parameters)
            : this((int) parameters[0], (int) parameters[1], (int) parameters[2],
                (int) parameters[3], (int) parameters[4], DateTime.Parse(parameters[5].ToString())) {
        }
    }
}
