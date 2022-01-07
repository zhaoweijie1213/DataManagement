using Com.Ctrip.Framework.Apollo.Logging;
using DataManagement.Entity;
using DataManagement.Model.Config;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = builder.Configuration;

builder.Services.AddControllers();

DatabaseConfigModel databaseConfig = configuration.GetSection("ConnectionStrings").Get<DatabaseConfigModel>();

//builder.Services.Configure<DatabaseConfigModel>(configuration.GetSection("ConnectionStrings"));
builder.Services.AddDbContextFactory<SystemDbContext>(options => 
{
    options.UseMySql(databaseConfig.System,new MySqlServerVersion(new Version(8, 0, 27)));
});

//≈‰÷√host
builder.Host.ConfigureAppConfiguration(config =>
        {
            //≈‰÷√apollo
            LogManager.UseConsoleLogging(Com.Ctrip.Framework.Apollo.Logging.LogLevel.Trace); 
            config.AddApollo(config.Build().GetSection("apollo"));
        })
        .ConfigureLogging(config =>
        {
            // π”√log4net
            config.AddLog4Net();
        });

//≈‰÷√application
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
