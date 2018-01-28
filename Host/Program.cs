using Orleans.Runtime.Configuration;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Hosting;
using Orleans.Storage;

namespace OrleansSiloHost
{
    public class Program
    {
        public static int Main(string[] args)
        {
            return RunMainAsync().Result;
        }

        private static async Task<int> RunMainAsync()
        {
            try
            {
                var host = await StartSilo();
                Console.WriteLine("Press Enter to terminate...");
                Console.ReadLine();

                await host.StopAsync();

                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 1;
            }
        }

        private static async Task<ISiloHost> StartSilo()
        {
            // define the cluster configuration
            var config = ClusterConfiguration.LocalhostPrimarySilo();
            //config.AddMemoryStorageProvider();
            var connectionStr = "DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;" +
            "AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;" +
            "BlobEndpoint=http://127.0.0.1:10000/devstoreaccount1;" +
            "TableEndpoint=http://127.0.0.1:10002/devstoreaccount1;" +
            "QueueEndpoint=http://127.0.0.1:10001/devstoreaccount1;";

            config.AddAzureBlobStorageProvider(connectionString: connectionStr);

            var builder = new SiloHostBuilder()
                .UseConfiguration(config)
                .ConfigureApplicationParts(parts => parts.AddApplicationPart(typeof(EmployeeGrain).Assembly).WithReferences())
                .ConfigureApplicationParts(parts => parts.AddApplicationPart(typeof(ManagerGrain).Assembly).WithReferences())
                .ConfigureLogging(logging => logging.AddConsole());

            var host = builder.Build();
            await host.StartAsync();
            return host;
        }
    }
}