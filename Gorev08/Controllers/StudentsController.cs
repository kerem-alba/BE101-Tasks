using Gorev8.Data;
using Gorev8.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gorev8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        //asp.net core ile DbContext'ten istekte bulunulur. Constructor method ile istekte bulunulur.
        public StudentsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            //Contexti bir fielda atarız, böylece null olmaz, crud işlemlerinde de kullanılabilir.
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var students = await _dbContext.Students
                .ToListAsync();

            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var student = await _dbContext.Students
                .FirstOrDefaultAsync(x => x.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] StudentEntity student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); 
            }
            _dbContext.Students.Add(student);

            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = student.Id }, student);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromForm] int id,
            [FromBody] StudentEntity student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != student.Id)
            {
                return BadRequest();
            }

            _dbContext.Entry(student).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _dbContext.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            _dbContext.Students.Remove(student);

            await _dbContext.SaveChangesAsync();

            return NoContent();
        }


    }
}
