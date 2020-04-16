using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    //Creo el constructor de la clase QualityCheck, el cual hereda los atributos de la clase astracta máquina
    class QualityCheck : Machine
    {
        public QualityCheck()
        {
            memory = 80;
            use = 0;
            name = "Verificación de calidad";
        }

        //Uso el método NewMemory() heredado de la clase máquina, el cual me permite reiniciar la memoria
        public override int NewMemory(string name)
        {
            memory += 80;
            Console.WriteLine("La nueva memoria de verificación de calidad es: " + memory);
            return memory;
        }

        //Creo el método Check(), donde va a funcionar el proceso utilizando un número Random gastar memoria
        static Random rnd = new Random();
        public  int Check()
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

        //Uso el método GetMemory() heredado de la clase máquina, el cual me retorna la memoria disponible
        public override int GetMemory()
        {
            return memory;
        }
    }
}
