using System;
using System.Collections.Generic;
using System.Linq;
using PMS_WEBAPI.Models;

namespace PMS_WEBAPI.Services
{
    public class PatientService : IPatientService
    {
        private readonly List<Patient> _patients = new()
        {
            new Patient { Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(1985,5,20), Gender = "Male", Phone = "1234567890", Email = "john.doe@example.com" },
            new Patient { Id = Guid.Parse("22222222-2222-2222-2222-222222222222"), FirstName = "Jane", LastName = "Smith", DateOfBirth = new DateTime(1990,8,15), Gender = "Female", Phone = "9876543210", Email = "jane.smith@example.com" }
        };

        public IEnumerable<Patient> GetAll() => _patients;

        public Patient? GetById(Guid id) => _patients.FirstOrDefault(p => p.Id == id);

        public Patient Add(Patient patient)
        {
            if (patient.Id == Guid.Empty) patient.Id = Guid.NewGuid();
            _patients.Add(patient);
            return patient;
        }
    }
}
