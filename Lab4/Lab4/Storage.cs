using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    //Creo el constructor de la clase Storage, el cual hereda los atributos de la clase astracta máquina
    class Storage : Machine
    {
        public Storage()
        {
            memory = 125;
            use = 0;
            name = "Almacenamiento";
        }

        //Uso el método NewMemory() heredado de la clase máquina, el cual me permite reiniciar la memoria
        public override int NewMemory(string name)
        {
            memory += 125;
            Console.WriteLine("La nueva memoria de alamcenamiento es: " + memory);
            return memory;
        }

        //Creo el método Store(), donde va a funcionar el proceso utilizando un número Random gastar memoria
        static Random rnd = new Random();
        public  int Store()
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

        //Uso el método GetMemory() heredado de la clase máquina, el cual me retorna la memoria disponible
        public override int GetMemory()
        {
            return memory;
        }
    }
}
