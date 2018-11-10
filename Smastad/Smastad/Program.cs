using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Smastad.Models;

namespace Smastad
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //CreateWebHostBuilder(args).Build().Run();

            var host = CreateWebHostBuilder(args);

           // using (var scope = host.Services.CreateScope())
            using (var scope = host.Build().Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<ApplicationDbContext>();
                    DBInitializer.EnsurePopulated(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }
            host.Build().Run();
    }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
  }
}
