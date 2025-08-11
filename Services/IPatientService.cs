using System;
using System.Collections.Generic;
using PMS_WEBAPI.Models;

namespace PMS_WEBAPI.Services
{
    public interface IPatientService
    {
        IEnumerable<Patient> GetAll();
        Patient? GetById(Guid id);
        Patient Add(Patient patient);
    }
}
