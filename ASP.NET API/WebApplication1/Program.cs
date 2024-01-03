
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using System.Net;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var connStrg = builder.Configuration.GetConnectionString("MySqlConn");
            builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(connStrg, ServerVersion.AutoDetect(connStrg)));

            builder.Services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.KnownProxies.Add(IPAddress.Parse("192.168.1.122"));
            });

            var myAllows = "_myAllow";

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: myAllows,
                    policy =>
                    {
                        policy.WithOrigins("http://127.0.0.1:5500").AllowAnyHeader()
                        .AllowAnyMethod();
                    });
            });

            builder.Services.AddConnections();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            app.MapGet("/", () => "192.168.1.122");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(myAllows);

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
