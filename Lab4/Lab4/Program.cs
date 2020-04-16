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
            //Creo los constructores de cada proceso
            CentralComputer centralcomputerfirst = new CentralComputer();
            Packing packing = new Packing();
            Reception reception = new Reception();
            Storage storage = new Storage();
            QualityCheck qualityCheck = new QualityCheck();
            ObjectAssembly objectAssembly = new ObjectAssembly();
            
            //Agrego los constructores a la lista de la máquina central
            centralcomputerfirst.AddMachins(reception);
            centralcomputerfirst.AddMachins(storage);
            centralcomputerfirst.AddMachins(objectAssembly);
            centralcomputerfirst.AddMachins(qualityCheck);
            centralcomputerfirst.AddMachins(packing);

            //Enciendo todas las máquinas
            centralcomputerfirst.SwitchedOn();

            //Pongo las máquinas a trabajar
            int i = 10;
            while (i>0) 
            {
                reception.Receive();
                storage.Store();
                objectAssembly.ObjectAssemble();
                qualityCheck.Check();
                packing.Pack();
                centralcomputerfirst.Rebbot();
                Thread.Sleep(6000);
                Console.WriteLine("\n");
                i -= 1;
            }

            //Cuando las máquinas cumplen el ciclo de trabajo, que en este caso es 1 minuto, apago las máquinas
            centralcomputerfirst.SwitchedOff();
        }
    }
}
