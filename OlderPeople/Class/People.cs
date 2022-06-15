using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlderPeople.Class
{
    public class People
    {
        public string Name { get; set; }
        public int Years { get; set; }

        public People()
        {
        }
        public People(string name, int years)
        {
            Name = name;
            Years = years;
        }
    }
}
