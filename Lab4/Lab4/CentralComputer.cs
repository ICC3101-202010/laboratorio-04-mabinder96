using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class CentralComputer :ISwitchedOn,ISwitchedOff,IRebbot
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

        //Uso la interfaz para reiniciar las máquinas, dándole la opción al trabajador de elegir la máquina que desee reiniciar (BONUS)
        public void Rebbot()
        {
            Console.WriteLine("Seleccione máquina que desee reiniciar");
            Console.WriteLine("Opción 1: Recepción de piezas\nOpción 2: Almacenamiento\nOpción 3: Ensamblaje del objeto\nOpción 4: Verificación de calidad\nOpción 5: Empaque");
            string election = Console.ReadLine();
            string name;
            if (election == "1") name = "Recepción de piezas";
            else if (election == "2") name = "Almacenamiento";
            else if (election == "3") name = "Ensamblaje del objeto";
            else if (election == "4") name = "Verificación de calidad";
            else if (election == "5") name = "Empaque";
            else
            {
                Console.WriteLine("Carácter ingresado inválido");
                name = null;
            }
            if (name != null)
            {
                foreach (Machine i in machines)
                {
                    if (i.Name == name)
                    {
                        Console.WriteLine("Reiniciando máquina: " + i.Name);
                        i.NewMemory(name);
                    }
                }
            }
        }

        //Creo un método que le entrega al trabajado un mensaje de que se llenó la memoria de la máquina
        public void Message(string name)
        {
            Console.WriteLine("Se ha llenado la máquina: " + name);
        }
    }
}
