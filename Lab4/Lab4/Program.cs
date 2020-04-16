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
                if (reception.Receive() == 0) //Si la memoria se acaba
                {
                    centralcomputerfirst.Message(reception.Name); //El computador central recibe la información de la máquina
                    centralcomputerfirst.Rebbot(); //Y e da la opción al trabajador de reiniciar alguna máquina
                }
                if (storage.Store() == 0)
                {
                    centralcomputerfirst.Message(storage.Name);
                    centralcomputerfirst.Rebbot();
                }
                if (objectAssembly.ObjectAssemble() == 0)
                {
                    centralcomputerfirst.Message(objectAssembly.Name);
                    centralcomputerfirst.Rebbot();
                }
                if (qualityCheck.Check() == 0)
                {
                    centralcomputerfirst.Message(qualityCheck.Name);
                    centralcomputerfirst.Rebbot();
                }
                if (packing.Pack() == 0)
                {
                    centralcomputerfirst.Message(packing.Name);
                    centralcomputerfirst.Rebbot();
                }
                Console.WriteLine("\n");
                i -= 1;
            }

            //Cuando las máquinas cumplen el ciclo de trabajo, que en este caso, son 10 rondas, apago las máquinas
            centralcomputerfirst.SwitchedOff();
        }
    }
}
