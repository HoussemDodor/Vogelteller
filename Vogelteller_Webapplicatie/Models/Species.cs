using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Species
    {
        int ID;
        string name;

        Species(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
