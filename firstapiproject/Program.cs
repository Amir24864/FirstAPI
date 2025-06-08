using First_Project;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.Run();

[ApiController]
[Route("api/cars")]
public class CarController : ControllerBase
{
    private static readonly List<Car> Cars = new()
    {
        new FamilyCar(),
        new YouthCar(),
        new WomenCar()
    };

    [HttpGet]
    public IActionResult GetCars()
    {
        return Ok(Cars.Select(c => new { c.Name, Engine = c.Engine.Model, Wheel = c.Wheel.Type }));
    }
}
