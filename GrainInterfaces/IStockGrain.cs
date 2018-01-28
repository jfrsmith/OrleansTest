using System;
using System.Threading.Tasks;
using Orleans;

public interface IStockGrain : IGrainWithStringKey
{
    Task<string> GetPrice();
}