using System;
using System.Threading.Tasks;
using Orleans;
using Orleans.Concurrency;
using Orleans.Providers;

[Reentrant]
[StorageProvider(ProviderName = "AzureBlobStore")]
public class EmployeeGrain : Grain<EmployeeState>, IEmployee
{
    public Task<int> GetLevel()
    {
        return Task.FromResult(State.Level);
    }

    public Task Promote(int newLevel)
    {
        State.Level = newLevel;
        return base.WriteStateAsync();
    }

    public Task<IManager> GetManager()
    {
        return Task.FromResult(State.Manager);
    }

    public Task SetManager(IManager manager)
    {
        State.Manager = manager;
        return base.WriteStateAsync();
    }

    public async Task Greeting(GreetingData data)
    {
        Console.WriteLine("{0} said: {1} ", data.From, data.Message);

        if (data.Count >= 3)
        {
            return;
        }

        var fromGrain = GrainFactory.GetGrain<IEmployee>(data.From);
        await fromGrain.Greeting(new GreetingData {
            From = this.GetPrimaryKey(),
            Message = "Thanks!",
            Count = data.Count + 1
        });
    }
}