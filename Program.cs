using System.IO;
using Microsoft.AspNetCore.Hosting;
using CD-Organizer.Models;

namespace CDOrganizer.Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

                host.Run();

        }
    }
}
