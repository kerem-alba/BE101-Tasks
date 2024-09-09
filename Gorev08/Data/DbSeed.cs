using Gorev8.Data.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore;

namespace Gorev8.Data
{
    public static class DbSeed
    {
        public static async Task SeedAsync(AppDbContext dbContext)
        {

            var classrooms = new[] { "FS101", "FS102", "FS103", "G060", "G061", "G062" };

            //BOGUS
            var fakeStudents = new Faker<StudentEntity>()
                .RuleFor(s => s.Name, f => f.Person.FullName)
                .RuleFor(s => s.GPA, f => Math.Round(f.Random.Double(0, 4), 2))
                .RuleFor(s => s.Classroom, f => f.PickRandom(classrooms))
                .Generate(20);

            //birden çok nesneyi dbcontexte eklemek için:
            await dbContext.Students.AddRangeAsync(fakeStudents);
            await dbContext.SaveChangesAsync();

        }
    }
}
