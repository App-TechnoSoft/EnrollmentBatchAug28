using EDental.Data.Models;
using EDental.Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDental.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DoctorsController(IDoctorsRepository doctorsRepository) : ControllerBase
{
    IDoctorsRepository doctorsRepository = doctorsRepository;

    [HttpGet]
    public IActionResult Get()
    {
        var doctors = doctorsRepository.Get();
        return Ok(doctors);
    }

    [HttpPost]
    public IActionResult Post(Doctor doctor)
    {
        var result = doctorsRepository.Insert(doctor);
        return Ok(result);
    }
}
