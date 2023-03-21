using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HealthcareManagementApp.Models
{
    public class HealthDbContext : IdentityDbContext
    {
        public HealthDbContext(DbContextOptions<HealthDbContext> options) : base(options)
        {

        }



        public DbSet<Patient> Patients { get; set; }
        public DbSet<MedicalInformation> MedicalInformation { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

    }
}
