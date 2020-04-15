using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class  Machine
    {
        protected int memory;
        protected int use;

        public abstract int NewMemory();
        public abstract int NewUse();

    }
}
