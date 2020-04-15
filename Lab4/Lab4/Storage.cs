using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Storage : Machine
    {
        static Random rnd = new Random();
        public Storage(int memory, int use)
        {
            memory = rnd.Next(50, 200);
            use = 0;
        }

        public override int NewMemory()
        {
            memory += rnd.Next(50, 100);
            return memory;
        }
        public override int NewUse()
        {
            use += rnd.Next(0, 25);
            return use;
        }

        public void Store(int use)
        {
            memory -= use;
        }
    }
}
