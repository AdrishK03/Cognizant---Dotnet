using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi_Handson.Filters;
using WebApi_Handson.Models;

namespace WebApi_Handson.Controllers;

[ApiController]
[Route("api/[controller]")]
[ServiceFilter(typeof(CustomAuthFilter))]
public class EmployeeController : ControllerBase
{
    private static List<Employee> employees = GetStandardEmployeeList();

    private static List<Employee> GetStandardEmployeeList()
    {
        return new List<Employee>
        {
            new Employee
            {
                Id=1,
                Name="Rahul",
                Salary=50000,
                Permanent=true,
                Department=new Department
                {
                    Id=1,
                    Name="IT"
                },
                Skills=new List<Skill>
                {
                    new Skill{Id=1,Name="C#"},
                    new Skill{Id=2,Name="SQL"}
                },
                DateOfBirth=new DateTime(1999,5,10)
            },

            new Employee
            {
                Id=2,
                Name="Priya",
                Salary=60000,
                Permanent=false,
                Department=new Department
                {
                    Id=2,
                    Name="HR"
                },
                Skills=new List<Skill>
                {
                    new Skill{Id=3,Name="Excel"}
                },
                DateOfBirth=new DateTime(1998,8,15)
            }
        };
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<List<Employee>> Get()
    {
        return Ok(employees);
    }
}