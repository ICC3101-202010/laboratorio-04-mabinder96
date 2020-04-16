using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            CentralComputer centralcomputerfirst = new CentralComputer();
            Packing packing = new Packing();
            Reception reception = new Reception();
            Storage storage = new Storage();
            QualityCheck qualityCheck = new QualityCheck();
            ObjectAssembly objectAssembly = new ObjectAssembly();
            centralcomputerfirst.AddMachins(reception);
            centralcomputerfirst.AddMachins(storage);
            centralcomputerfirst.AddMachins(objectAssembly);
            centralcomputerfirst.AddMachins(qualityCheck);
            centralcomputerfirst.AddMachins(packing);

            centralcomputerfirst.SwitchedOn();
            int i = 10;
            while (i>0) //Cuando son las 20:00 dejan de funcionar las máquinas
            {
                centralcomputerfirst.UseMachine();
                centralcomputerfirst.Rebbot();
                Thread.Sleep(5000);
                Console.WriteLine("\n");
                i -= 1;
            }
            centralcomputerfirst.SwitchedOff();
        }
    }
}
