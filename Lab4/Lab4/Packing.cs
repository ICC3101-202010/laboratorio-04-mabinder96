﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Packing : Machine
    {
        static Random rnd = new Random();
        public Packing(int memory, int use)
        {
            memory = rnd.Next(50, 200); ;
            use = 0;
        }

        public override int NewMemory()
        {
            memory += rnd.Next(50, 100);
            return memory;
        }
        public override int  NewUse()
        {
            use += rnd.Next(0, 25);
            return use;
        }
        
        
        public void Pack(int use)
        {
            memory -= use;
        }
    }
}
