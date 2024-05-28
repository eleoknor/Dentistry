using Dentistry.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using System.Globalization;

public class DentistryContext : DbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

    public DentistryContext(DbContextOptions<DentistryContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Patient>().HasData(
        new Patient { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@gmail.com", PhoneNumber = "07", DateOfBirth = DateTime.TryParseExact("01.02.1970", "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result) ? result : DateTime.MinValue, Age = 30 },
        new Patient { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@gmail.com", PhoneNumber = "02", DateOfBirth = DateTime.TryParseExact("01.15.1979", "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result2) ? result2 : DateTime.MinValue, Age = 27 });

        modelBuilder.Entity<Doctor>().HasData(
        new Patient { Id = 1, FirstName = "Doctor", LastName = "A", Email = "doc.a@gmail.com", PhoneNumber = "07", DateOfBirth = DateTime.TryParseExact("08.12.1950", "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime res) ? res : DateTime.MinValue, Age = 40 },
        new Patient { Id = 2, FirstName = "Doctor", LastName = "B", Email = "doc.b@gmail.com", PhoneNumber = "02", DateOfBirth = DateTime.TryParseExact("12.12.1929", "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime res2) ? res2 : DateTime.MinValue, Age = 45 });

        modelBuilder.Entity<Appointment>().HasData(
        new Appointment { Id = 1, AppointmentDate = DateTime.TryParseExact("28.05.2024", "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime res1) ? res1 : DateTime.MinValue, Description = "Consulatatie", DoctorId = 1, PatientId = 2 },
        new Appointment { Id = 2, AppointmentDate = DateTime.TryParseExact("10.06.2024", "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ress) ? ress : DateTime.MinValue, Description = "Consultatie lunara", DoctorId = 2, PatientId = 1 });
    }
}