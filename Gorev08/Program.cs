using Gorev8.Data;
using Microsoft.EntityFrameworkCore;
using System.Globalization;



var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
    });
});

//Dependency Injection : EfCore ile veritaban� ba�lant�s� kurmak i�in
//Ba��ml�l�klar� y�netme sorumlulu�unu s�n�ftan al�r ve bu sorumlulu�u servis sa�lay�c�s�na b�rak�r.
//EF Core kendisinden istendi�i zaman dbContext olu�tursun
builder.Services.AddDbContext<AppDbContext>(option =>
{
    var connectionString = builder.Configuration.GetConnectionString("Default");
    if (connectionString is null)
    {
        throw new InvalidOperationException("Connection string could not be found.");
    }

    option.UseSqlServer(connectionString);
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();

app.UseAuthorization();

app.MapControllers();

//Async paralel �al���r ve daha verimlidir. Await bekletirken s�radaki kod �al��maya devam eder.
//Scope bir oyun alan� a�ar, program i�inde �al��an bir programd�r. Bir istek gelmi� gibi g�sterip response bekleriz. Response d�nd���nde olu�turulan her�ey kaybolur.
using (var scope = app.Services.CreateScope())
{
    using (var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>())
    {
        await dbContext.Database.EnsureDeletedAsync();
        await dbContext.Database.EnsureCreatedAsync();

        await DbSeed.SeedAsync(dbContext);
    }
}

app.Run();
