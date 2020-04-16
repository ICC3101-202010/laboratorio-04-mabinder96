using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    //Creo el constructor de la clase ObjectAssembly, el cual hereda los atributos de la clase astracta máquina
    class ObjectAssembly : Machine
    {
        static Random rnd = new Random();
        public ObjectAssembly()
        {
            memory = 200;
            use = 0;
            name = "Ensamblaje del objeto";
        }

        //Uso el método NewMemory() heredado de la clase máquina, el cual me permite reiniciar la memoria
        public override int NewMemory()
        {
            memory += 200;
            Console.WriteLine("La nueva memoria de ensamblaje del objeto es: " + memory);
            return memory;
        }

        //Creo el método ObjectAssemble(), donde va a funcionar el proceso utilizando un número Random gastar memoria
        public  int ObjectAssemble()
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

        //Uso el método GetMemory() heredado de la clase máquina, el cual me retorna la memoria disponible
        public override int GetMemory()
        {
            return memory;
        }
    }
}
