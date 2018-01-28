using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Orleans;
using Orleans.Providers;

[StorageProvider(ProviderName = "AzureBlobStore")]
public class ManagerGrain : Grain<ManagerState>, IManager
{
    public override Task OnActivateAsync()
    {
        _me = this.GrainFactory.GetGrain<IEmployee>(this.GetPrimaryKey());
        return base.OnActivateAsync();
    }

    public Task<List<IEmployee>> GetDirectReports()
    {
        return Task.FromResult(State.Reports);
    }

    public async Task AddDirectReport(IEmployee employee)
    {
        if(State.Reports == null)
        {
            State.Reports = new List<IEmployee>();
        }

        State.Reports.Add(employee);
        await employee.SetManager(this);
        await employee.SetManager(this);
        var data = new GreetingData { From = this.GetPrimaryKey(), Message = "Welcome to my team!" };
        await employee.Greeting(data);
        Console.WriteLine("{0} said: {1}", data.From.ToString(),data.Message);

        await base.WriteStateAsync();
    }

    public Task<IEmployee> AsEmployee()
    {
        return Task.FromResult(_me);
    }

    private IEmployee _me;
}