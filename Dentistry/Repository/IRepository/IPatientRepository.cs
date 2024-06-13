using Dentistry.Models;

namespace Dentistry.Repository.IRepository
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patient>> GetAllPatientsAsync();
    }
}
