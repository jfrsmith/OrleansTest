using System;
using System.Threading.Tasks;
using Orleans;

public class HelloGrain : Grain, IHello
{
    public Task<string> SayHello(string msg)
    {
        return Task.FromResult(string.Format("You said {0}, I say: Hello! ID: {1}", msg, this.GetPrimaryKey()));
    }

    public override Task OnActivateAsync()
    {
        Console.WriteLine("*** ACTIVATED GRAIN: {0} ***", this.GetPrimaryKey());
        return base.OnActivateAsync();
    }
}