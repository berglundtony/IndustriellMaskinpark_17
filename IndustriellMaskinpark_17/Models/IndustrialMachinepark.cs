using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IndustriellMaskinpark_17.Models
{
    public class IndustrialMachinepark
    {
        public string MachineName { get; set; }
        public string MachineId { get; set; }
        public bool Status { get; set; }
        public string Data { get; set; }
        public bool Completed { get; set; }
    }
}
