using Dentistry.DTOs;

namespace Dentistry.Services.IServices
{
    public interface IPatientService
    {
        Task<IEnumerable<PatientDTO>> GetAllPatientsAsync();
        Task<PatientDTO> GetPatientByIdAsync(int id);
        Task<PatientDTO> AddPatientAsync(PatientDTO patient);
        Task<PatientDTO> UpdatePatientAsync(int id, PatientDTO patient);
        Task<bool> DeletePatientAsync(int id);
    }
}
