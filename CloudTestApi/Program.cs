using CloudTestApi.Database;
using CloudTestApi.Services;
using CloudTestApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloudTestApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Configuration
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, true)
                .AddEnvironmentVariables();

            var connection = builder.Configuration.GetConnectionString("CloudTest");
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<CloudTestContext>(options => options.UseSqlServer(connection, b => b.MigrationsAssembly("CloudTestApi.Database")));
            builder.Services.AddScoped<ICitiesService, CitiesService>();

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
        }
    }
}


