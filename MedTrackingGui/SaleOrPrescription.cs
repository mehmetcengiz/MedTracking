using MedTrackingGui.Model;

namespace MedTrackingGui {
    class SaleOrPrescription {
        private Sale _sale = null;
        private Prescription _prescription = null;

        public SaleOrPrescription(Sale sale) {
            this._sale = sale;
        }

        public SaleOrPrescription(Prescription prescription) {
            this._prescription = prescription;
        }
    }
}
