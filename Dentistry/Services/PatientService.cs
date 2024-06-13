using Dentistry.DTOs;
using Dentistry.Repository.IRepository;
using Dentistry.Services.IServices;
using Dentistry.Mapper;

namespace Dentistry.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public Task<PatientDTO> AddPatientAsync(PatientDTO patient)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePatientAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PatientDTO>> GetAllPatientsAsync()
        {
            var patients = await _patientRepository.GetAllPatientsAsync();
            return patients.Select(PatientMapper.PacientToDTO).ToList();
        }

        public Task<PatientDTO> GetPatientByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PatientDTO> UpdatePatientAsync(int id, PatientDTO patient)
        {
            throw new NotImplementedException();
        }
    }
}
