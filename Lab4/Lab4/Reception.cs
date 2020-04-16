using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    //Creo el constructor de la clase Reception, el cual hereda los atributos de la clase astracta máquina
    class Reception :Machine
    {
        public Reception()
        {
            memory = 150;
            use = 0;
            name = "Recepción de piezas";
        }

        //Uso el método NewMemory() heredado de la clase máquina, el cual me permite reiniciar la memoria
        public override int NewMemory(string name)
        {
            memory += 150;
            Console.WriteLine("La nueva memoria de recepción es: " + memory);
            return memory;
        }

        //Creo el método Receive(), donde va a funcionar el proceso utilizando un número Random gastar memoria
        static Random rnd = new Random();
        public int Receive()
        {
            use = rnd.Next(20, 30);
            if (use >= memory)
            {
                Console.WriteLine("Se ha usado: " + memory + " de la memoria disponible de recepción. Ahora queda: 0");
                memory = 0;
            }
            else
            {
                memory -= use;
                Console.WriteLine("Se ha usado: " + use + " de la memoria disponible de recepción. Ahora queda: " + memory);
            }
            return memory;
        }

        //Uso el método GetMemory() heredado de la clase máquina, el cual me retorna la memoria disponible
        public override int GetMemory()
        {
            return memory;
        }
    }
}
