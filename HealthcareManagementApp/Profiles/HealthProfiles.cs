using AutoMapper;
using HealthcareManagementApp.Models;
using HealthcareManagementApp.ViewModels;

namespace HealthcareManagementApp.Profiles
{
    public class HealthProfiles : Profile
    {
        public HealthProfiles()
        {
            CreateMap<Patient, PatientViewModel>();
        }
    }
}
