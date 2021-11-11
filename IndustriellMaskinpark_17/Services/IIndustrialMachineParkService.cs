using IndustriellMaskinpark_17.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace IndustriellMaskinpark_17.Services
{
    public interface IIndustrialMachineParkService
    {
        Task<List<IndustrialMachinepark>> GetMachinesAsync();
        Task<HttpResponseMessage> UpdateMachine(IndustrialMachinepark machine);
        Task<IndustrialMachinepark>AddMachine(IndustrialMachinepark machine);
    }
}
