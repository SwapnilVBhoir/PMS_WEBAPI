using Microsoft.AspNetCore.Mvc;
using PMS_WEBAPI.Models;
using PMS_WEBAPI.Services;
using System;

namespace PMS_WEBAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService _service;

        public PatientsController(IPatientService service)
        {
            _service = service;
        }

        // GET: api/patients
        [HttpGet]
        public IActionResult Get()
        {
            var patients = _service.GetAll();
            return Ok(patients);
        }

        // GET: api/patients/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var patient = _service.GetById(id);
            if (patient == null) return NotFound();
            return Ok(patient);
        }

        // POST: api/patients
        [HttpPost]
        public IActionResult Create([FromBody] Patient patient)
        {
            var created = _service.Add(patient);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }
    }
}
