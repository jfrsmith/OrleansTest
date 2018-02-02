using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Runtime;
using Orleans.Runtime.Configuration;

namespace client
{
    public class Program
    {
        static int Main(string[] args)
        {
            return RunMainAsync().Result;
        }

        private static async Task<int> RunMainAsync()
        {
            try
            {
                using(var client = await StartClientWithRetries())
                {
                    await DoClientWork(client);
                    Console.ReadKey();
                }
                return 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 1;
            }
        }

        public static async Task<IClusterClient> StartClientWithRetries(int initializeAttemptsBeforeFailing = 5)
        {
            int attempt = 0;
            IClusterClient client;
            while(true)
            {
                try
                {
                    var config = ClientConfiguration.LocalhostSilo();
                    client = new ClientBuilder()
                        .UseConfiguration(config)
                        .ConfigureApplicationParts(parts => parts.AddApplicationPart(typeof(IHello).Assembly).WithReferences())
                        .ConfigureLogging(logging => logging.AddConsole())
                        .Build();
                    
                    await client.Connect();
                    Console.WriteLine("Client successfully connect to silo host");
                    break;
                }
                catch(SiloUnavailableException)
                {
                    attempt++;
                    Console.WriteLine($"Attempt {attempt} of {initializeAttemptsBeforeFailing} failed to initialize the Orleans client.");
                    if(attempt > initializeAttemptsBeforeFailing)
                    {
                        throw;
                    }
                    await Task.Delay(TimeSpan.FromSeconds(4));
                }
            }

            return client;
        }

        private static async Task DoClientWork(IClusterClient client)
        {
            var ids = new string[] {
                "42783519-d64e-44c9-9c29-399e3afaa625",
                "d694a4e0-1bc3-4c3f-a1ad-ba95103622bc",
                "9a72b0c6-33df-49db-ac05-14316edd332d",
                "6526a751-b9ac-4881-9bfb-836ecce2ca9f",
                "ae4b106f-3c96-464a-b48d-3583ed584b17",
                "b715c40f-d8d2-424d-9618-76afbc0a2a0a",
                "5ad92744-a0b1-487b-a9e7-e6b91e9a9826",
                "e23a55af-217c-4d76-8221-c2b447bf04c8",
                "2eef0ac5-540f-4421-b9a9-79d89400f7ab"
            };

            var e0 = client.GetGrain<IEmployee>(Guid.Parse(ids[0]));
            var e1 = client.GetGrain<IEmployee>(Guid.Parse(ids[1]));
            var e2 = client.GetGrain<IEmployee>(Guid.Parse(ids[2]));
            var e3 = client.GetGrain<IEmployee>(Guid.Parse(ids[3]));
            var e4 = client.GetGrain<IEmployee>(Guid.Parse(ids[4]));

            var m0 = client.GetGrain<IManager>(Guid.Parse(ids[5]));
            var m1 = client.GetGrain<IManager>(Guid.Parse(ids[6]));

            var m0e = m0.AsEmployee().Result;
            var m1e = m1.AsEmployee().Result;

            await m0e.Promote(10);
            await m1e.Promote(11);

            m0.AddDirectReport(e0).Wait();
            m0.AddDirectReport(e1).Wait();
            m0.AddDirectReport(e2).Wait();

            m1.AddDirectReport(m0e).Wait();
            m1.AddDirectReport(e3).Wait();

            m1.AddDirectReport(e4).Wait();

            await e0.Promote(55);

            await Task.CompletedTask;
        }
    }
}