namespace HealthcareManagementApp.Models
{
    public class MedicalInformation
    {

        public int Id { get; set; }
        public string? Allergies { get; set; }

        public string? CarePlan { get; set; }
        public string? PrimaryDoc { get; set; }

        public string? Medications { get; set; }

        public string? LabResults { get; set; }

        public string? EduLinks { get; set; }
    }
}
