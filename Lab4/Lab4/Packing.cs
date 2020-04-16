using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Packing : Machine
    {
        public Packing()
        {
            memory = 100; ;
            use = 0;
            name = "Empaque";
            
        }
        public override int NewMemory()
        {
            memory += 100;
            Console.WriteLine("La nueva memoria de empaque es: " + memory);
            return memory;
        }
        static Random rnd = new Random();
        public override int NewUse()
        {
            use = rnd.Next(45, 65);
            if (use >= memory)
            {
                Console.WriteLine("Se ha usado: " + memory + " de la memoria disponible de empaque. Ahora queda: 0");
                memory = 0;
            }
            else
            {
                memory -= use;
                Console.WriteLine("Se ha usado: " + use + " de la memoria disponible de empaque. Ahora queda: " + memory);
            }
            return memory;
        }
        public override int GetMemory()
        {
            return memory;
        }
    }
}
