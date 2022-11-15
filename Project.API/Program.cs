using System.Configuration;
using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Application;
using Project.Core.Models;
using Project.Data;
using Project.Domain.Entities.Identity;

var builder = WebApplication.CreateBuilder(args);
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    config.AddJsonFile("Settings/tokenSettings.json", false, true);
    config.AddJsonFile("Settings/appsettings.json", false, true);
    config.AddCommandLine(args);
});
builder.Services.Configure<TokenSettings>(builder.Configuration.GetSection("tokenSettings"));
builder.Services.AddControllers();
builder.Services.ConfigureDependencyInjections(builder.Configuration, new DependencyInjectionOptions()
{
    AutoMapperAssemblies = new Assembly[]
    {
        typeof(Program).Assembly,
        typeof(DependencyInjection).Assembly,

    },
    SwaggerAssembly = Assembly.GetExecutingAssembly()
});

var app = builder.Build();

app.UseCors();
// Configure the HTTP request pipeline.
app.UseSwagger(c =>
{
    c.SerializeAsV2 = true;
    c.RouteTemplate = "api/swagger/{documentName}/swagger.json";

});
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/api/swagger/v1/swagger.json", "Project.API v1");
    c.RoutePrefix = "api/swagger";
});

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();