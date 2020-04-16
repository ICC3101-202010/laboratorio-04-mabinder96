using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class ObjectAssembly : Machine
    {
        static Random rnd = new Random();
        public ObjectAssembly()
        {
            memory = 200;
            use = 0;
            name = "Ensamblaje del objeto";
        }
        public override int NewMemory()
        {
            memory += 200;
            Console.WriteLine("La nueva memoria de ensamblaje del objeto es: " + memory);
            return memory;
        }
        public override int NewUse()
        {
            use = rnd.Next(50, 60);
            if (use >= memory)
            {
                Console.WriteLine("Se ha usado: " + memory + " de la memoria disponible de ensamblaje del objeto. Ahora queda: 0");
                memory = 0;
            }
            else
            {
                memory -= use;
                Console.WriteLine("Se ha usado: " + use + " de la memoria disponible de ensamblaje del objeto. Ahora queda: " + memory);
            }
            return memory;
        }
        public override int GetMemory()
        {
            return memory;
        }
    }
}
