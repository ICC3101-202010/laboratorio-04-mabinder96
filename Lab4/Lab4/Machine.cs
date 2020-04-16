using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    //Creo la clase abstracta Machine, de la cual van a heredar los procesos sus atributos y métodos
    abstract class Machine
    {
        protected int memory;
        protected int use;
        protected string name;
        public string Name { get => name; set => name = value; }
        public abstract int NewMemory(string name);
        public abstract int GetMemory();
    }
}
