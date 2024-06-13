using Dentistry.Models;
using Dentistry.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Dentistry.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly DentistryContext _context;

        public PatientRepository(DentistryContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Patient>> GetAllPatientsAsync()
        {
            return await _context.Patients.ToListAsync();
        }
    }
}
