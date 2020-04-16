using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class QualityCheck : Machine
    {
        public QualityCheck()
        {
            memory = 80;
            use = 0;
            name = "Verificación de calidad";
        }
        public override int NewMemory()
        {
            memory += 80;
            Console.WriteLine("La nueva memoria de verificación de calidad es: " + memory);
            return memory;
        }
        static Random rnd = new Random();
        public override int NewUse()
        {
            use = rnd.Next(25, 35);
            if (use >= memory)
            {
                Console.WriteLine("Se ha usado: " + memory + " de la memoria disponible de verificación de calidad. Ahora queda: 0");
                memory = 0;
            }
            else
            {
                memory -= use;
                Console.WriteLine("Se ha usado: " + use + " de la memoria disponible de verificación de calidad. Ahora queda: " + memory);
            }
            return memory;
        }
        public override int GetMemory()
        {
            return memory;
        }
    }
}
