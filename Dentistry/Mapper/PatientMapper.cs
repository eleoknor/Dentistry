using Dentistry.DTOs;
using Dentistry.Models;

namespace Dentistry.Mapper
{
    public class PatientMapper
    {
        public static PatientDTO PacientToDTO(Patient pacient)
        {
            return new PatientDTO
            {
                FirstName = pacient.FirstName,
                LastName = pacient.LastName,
                Age = pacient.Age,
                DateOfBirth = pacient.DateOfBirth,
                Email = pacient.Email,
                PhoneNumber = pacient.PhoneNumber
            };

        }
    }
}
