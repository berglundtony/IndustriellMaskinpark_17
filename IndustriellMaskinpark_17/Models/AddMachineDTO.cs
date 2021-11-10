using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndustriellMaskinpark_17.Models
{
    public class AddMachineDTO
    {
        public string MachineId { get; set; }
        public string MachineName { get; set; }
        public bool Status { get; set; }
        public string Data { get; set; }
    }
}
