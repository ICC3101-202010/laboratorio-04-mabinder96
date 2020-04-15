using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class CentralComputer:ISwitchedOn
    {
        public CentralComputer(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        List<Machine> machines = new List<Machine>();

        public void SwitchedOn()
        {

        }
    }
}
