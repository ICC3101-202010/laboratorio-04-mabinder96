using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class Machine
    {
        protected int memory;
        protected int use;
        protected string name;
        public string Name { get => name; set => name = value; }
        public abstract int NewMemory();
        public abstract int GetMemory();
        public abstract int NewUse();

    }
}
