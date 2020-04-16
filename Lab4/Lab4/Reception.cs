using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Reception:Machine
    {
        public Reception()
        {
            memory = 150;
            use = 0;
            name = "Recepción de piezas";
        }
        public override int NewMemory()
        {
            memory += 150;
            Console.WriteLine("La nueva memoria de recepción es: " + memory);
            return memory;
        }
        static Random rnd = new Random();
        public override int NewUse()
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
        public override int GetMemory()
        {
            return memory;
        }
    }
}
