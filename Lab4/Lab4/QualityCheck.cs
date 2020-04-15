using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class QualityCheck : Machine
    {
        static Random rnd = new Random();
        public QualityCheck(int memory, int use)
        {
            memory = rnd.Next(50, 200); ;
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

        public void Check(int use)
        {
            memory -= use;
        }
    }
}
