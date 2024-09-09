using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private static readonly List<Student> _students;
    private static int _index;

    static StudentsController()
    {
        _students = new List<Student>()
        {
            new Student { Id = 1, FirstName = "Kerem", LastName = "Albayrak" ,Classroom="5-A", StudentNo = "1427"}
        };
        _index = _students.Count + 1;
    }

    [HttpGet("showall")]
    public IActionResult GetAll()
    {
        return Ok(_students);
    }

    [HttpGet("showbyid/{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var student = _students.Find(x => x.Id == id);
        if (student == null)
        {
            return NotFound();
        }
        return Ok(student);
    }

    [HttpPost]
    public IActionResult Register([FromForm] StudentCreateModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        if (!string.IsNullOrEmpty(model.StudentNo))
        {
            var existingNo = _students.Find(s => s.StudentNo == model.StudentNo);
            if (existingNo != null)
            {
                return BadRequest("This student number is already taken. Please choose another one.");
            }
        }

        Student student = new Student()
        {
            Id = _index++,
            FirstName = model.FirstName,
            LastName = model.LastName,
            Classroom = model.Classroom,
            StudentNo = model.StudentNo
        };
        _students.Add(student);
        return Ok(student);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] int id)
    {
        var student = _students.Find(x => x.Id == id);
        if (student == null)
        {
            return NotFound("Student not found");
        }
        _students.Remove(student);
        return Ok(student);
    }

}
