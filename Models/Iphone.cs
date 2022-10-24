using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengePOOSCellularSystem.Models
{
    internal class Iphone : Smartphone
    {
        public Iphone(string number, string? model, string? iMEI, int memory) : base(number, model, iMEI, memory)
        {

        }
        public override void InstallApp(string name)
        {
            Console.WriteLine($"Installing app... \nApp {name.ToUpper()} successfully installed!!");
        }
    }
}
