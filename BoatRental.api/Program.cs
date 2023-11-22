using BoatRental.core.Interfaces;
using BoatRental.ef;
using BoatRental.ef.Repositories;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);


//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer("Data Source=ENG-IBRAHIM-SHA;Integrated Security=True;Database=lastDB;Trusted_Connection=True;TrustServerCertificate=true"));


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Log.Logger= new LoggerConfiguration()
      .MinimumLevel.Information()
      .WriteTo.Console()
      .WriteTo.File("logs/mylog-.txt",rollingInterval:RollingInterval.Minute)
      .CreateLogger();
      //.ReadFrom.Configuration(builder.Configuration).CreateLogger(); 
    

builder.Host.UseSerilog();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();