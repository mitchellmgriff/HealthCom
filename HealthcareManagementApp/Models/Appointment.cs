namespace HealthcareManagementApp.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
         public Patient Patient { get; set; }

    }
}
