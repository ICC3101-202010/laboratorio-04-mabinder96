using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Storage : Machine
    {
        public Storage()
        {
            memory = 125;
            use = 0;
            name = "Almacenamiento";
        }
        public override int NewMemory()
        {
            memory += 125;
            Console.WriteLine("La nueva memoria de alamcenamiento es: " + memory);
            return memory;
        }
        static Random rnd = new Random();
        public override int NewUse()
        {
            use = rnd.Next(35, 45);
            if (use >= memory)
            {
                Console.WriteLine("Se ha usado: " + memory + " de la memoria disponible de almacenamiento. Ahora queda: 0");
                memory = 0;
            }
            else
            {
                memory -= use;
                Console.WriteLine("Se ha usado: " + use + " de la memoria disponible de almacenamiento. Ahora queda: " + memory);
            }
            return memory;
        }
        public override int GetMemory()
        {
            return memory;
        }
    }
}
