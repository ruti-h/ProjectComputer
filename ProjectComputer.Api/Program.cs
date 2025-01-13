using ProjectComputer.Core.Repositories;
using ProjectComputer.Core.Service;
using ProjectComputer.Data;
using ProjectComputer.Data.Repository;
using ProjectComputer.Service;
using ProjectComputer.Service.Service;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CusromerService>();

builder.Services.AddScoped<IComputerRepository, ComputerRepository>();
builder.Services.AddScoped<IComputerService, ComputerService>();

builder.Services.AddScoped<IRentingRepository, RentingRepository>();
builder.Services.AddScoped<IRentingService, RentingService>();

builder.Services.AddDbContext<DataContext>();

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