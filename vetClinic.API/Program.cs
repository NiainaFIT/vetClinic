using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using vetClinic.Services;
using vetClinic.Services.Database;
using vetClinic.Services.Interfaces;
using vetClinic.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddTransient<IProductService, DummyProductsService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ISearviceMeasureService, ServiceMeasureService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddAutoMapper(typeof(AutomapperEntryPoint));

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<VetStationDbContext>(options => options.UseSqlServer(connectionString));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
