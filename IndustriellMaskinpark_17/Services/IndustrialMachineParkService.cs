using IndustriellMaskinpark_17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IndustriellMaskinpark_17.Services
{
    public class IndustrialMachineParkService : IIndustrialMachineParkService
    {
        private readonly HttpClient _httpClient;

        public IndustrialMachineParkService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<IndustrialMachinepark>> GetMachinesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<IndustrialMachinepark>>("sample-data/machinepark.json");
        }

        public async Task<HttpResponseMessage> UpdateMachine(IndustrialMachinepark machine)
        {
            machine.Completed = machine.Completed ? false : true;
            var response = await _httpClient.PutAsJsonAsync<IndustrialMachinepark>($"api/maskinpark/{machine.MachineId}", machine);

            if (!response.IsSuccessStatusCode)
            {
                machine.Completed = machine.Completed ? false : true;
            }

            return response;
        }

        public async Task<IndustrialMachinepark> AddMachine(IndustrialMachinepark machine)
        {
            machine.MachineId = Guid.NewGuid().ToString("n");
            var machineJson = new StringContent(JsonSerializer.Serialize(machine), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/maskinpark", machineJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<IndustrialMachinepark>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

    }
}
