using IndustriellMaskinpark_17.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IndustriellMaskinpark_17.Services
{
    public interface IIndustrialMachineParkService
    {
        Task<List<IndustrialMachinepark>> GetMachinesAsync();
        Task UpdateMachine(IndustrialMachinepark machine);
        Task<IndustrialMachinepark>AddMachine(IndustrialMachinepark machine);
    }
}
