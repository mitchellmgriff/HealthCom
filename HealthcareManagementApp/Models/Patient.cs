namespace HealthcareManagementApp.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public string EmergencyContactName { get; set; }
        public int EmergencyPhone { get; set; }

        public string Sex { get; set; }
        public int MedicalId { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
