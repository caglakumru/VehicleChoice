
using VehicleChoice.Business.Abstract;
using VehicleChoice.Business.Concrete;
using VehicleChoice.DataAccsess.Abstract;
using VehicleChoice.DataAccsess.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ICarService, CarManager>();
builder.Services.AddSingleton<ICarRepository, CarRepository>();
builder.Services.AddSingleton<IBoatService, BoatManager>();
builder.Services.AddSingleton<IBoatRepository, BoatRepository>();
builder.Services.AddSingleton<IBusService, BusManager>();
builder.Services.AddSingleton<IBusRepository, BusRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
