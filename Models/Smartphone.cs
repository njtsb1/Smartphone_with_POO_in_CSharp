using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengePOOSCellularSystem.Models
{
    internal abstract class Smartphone
    {
        public string Number { get; set; }

        private string? Model;
        private string? IMEI;
        private int memory;

        public Smartphone(string number, string? model, string? iMEI, int memory)
        {
            Number = number;
            Model = model;
            IMEI = iMEI;
            this.memory = memory;
        }

        public void Turnon()
        {
            Console.WriteLine("Turning on...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Receiving call...");
        }
        public abstract void InstallApp(string name);
    }
}
