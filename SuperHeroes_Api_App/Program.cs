using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SuperHeroes_Api_App;
using SuperHeroes_Api_App.Data;
using SuperHeroes_Api_App.Interfaces;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


var cs = builder.Configuration.GetConnectionString("default");
// Configure services
builder.Services.AddDbContext<DataContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("default")));


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<Seed>();
builder.Services.AddScoped<ISuperHeroInterface, ServiceSuperHero>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();  // Ensure authentication is used
app.UseAuthorization();

app.MapControllers();

app.Run();
