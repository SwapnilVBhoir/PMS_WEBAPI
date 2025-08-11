using System;
using Xunit;
using PMS_WEBAPI.Services;
using System.Linq;

namespace PMS_WEBAPI.Tests
{
    public class PatientServiceTests
    {
        [Fact]
        public void GetAll_ReturnsSeededPatients()
        {
            var svc = new PatientService();
            var all = svc.GetAll().ToList();
            Assert.True(all.Count >= 2);
        }

        [Fact]
        public void Add_AddsPatient()
        {
            var svc = new PatientService();
            var p = new PMS_WEBAPI.Models.Patient { FirstName = "Test", LastName = "User", DateOfBirth = DateTime.UtcNow };
            var added = svc.Add(p);
            Assert.NotEqual(Guid.Empty, added.Id);
        }
    }
}
