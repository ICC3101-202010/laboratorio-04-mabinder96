using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class CentralComputer:ISwitchedOn,ISwitchedOff,IRebbot
    {
        public CentralComputer()
        {
        }
      

        List<Machine> machines = new List<Machine>();
        public void AddMachins(Machine machine)
        {
            machines.Add(machine);
        }
        public void SwitchedOn()
        {
            foreach (Machine i in machines)
            {
                Console.WriteLine("Encendido máquina: " + i.Name + ". Memoria disponible: " + i.GetMemory()+"\n");
            }


        }
        public void SwitchedOff()
        {
            foreach (Machine i in machines)
            {
                Console.WriteLine("Apagado máquina: " + i.Name+"\n");
            }
            Console.ReadKey();
        }


        public void Rebbot()
        {
            foreach (Machine i in machines)
            {
                if (i.GetMemory() == 0)
                {
                    Console.WriteLine("Reiniciando máquina: " + i.Name);
                    i.NewMemory();
                }
            }
        }

        public void UseMachine()
        {
            foreach (Machine i in machines)
            {
                i.NewUse();
            }
        }
    }
}
