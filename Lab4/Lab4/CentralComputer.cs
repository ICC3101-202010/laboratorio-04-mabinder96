using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class CentralComputer:ISwitchedOn,ISwitchedOff,IRebbot
    {

        //Creo constructor vacío del computador central
        public CentralComputer()
        {
        }
      
        //Creo una lista que va a almacenar todas los procesos de la máquina
        List<Machine> machines = new List<Machine>();

        //Creo un método que agrega los distintos procesos a mi lista
        public void AddMachins(Machine machine)
        {
            machines.Add(machine);
        }

        //Uso la interfaz para encender las máquinas
        public void SwitchedOn()
        {
            foreach (Machine i in machines)
            {
                Console.WriteLine("Encendido máquina: " + i.Name + ". Memoria disponible: " + i.GetMemory()+"\n");
            }

        }

        //Uso la interfaz para apagar las máquinas
        public void SwitchedOff()
        {
            foreach (Machine i in machines)
            {
                Console.WriteLine("Apagado máquina: " + i.Name+"\n");
            }
            Console.ReadKey();
        }

        //Uso la interfaz para reiniciar las máquinas
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
    }
}
