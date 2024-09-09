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

//Dependency Injection : EfCore ile veritabaný baðlantýsý kurmak için
//Baðýmlýlýklarý yönetme sorumluluðunu sýnýftan alýr ve bu sorumluluðu servis saðlayýcýsýna býrakýr.
//EF Core kendisinden istendiði zaman dbContext oluþtursun
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

//Async paralel çalýþýr ve daha verimlidir. Await bekletirken sýradaki kod çalýþmaya devam eder.
//Scope bir oyun alaný açar, program içinde çalýþan bir programdýr. Bir istek gelmiþ gibi gösterip response bekleriz. Response döndüðünde oluþturulan herþey kaybolur.
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
