using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Species
    {
        public int ID { get; set; }
        public string name { get; set; }

        public Species(int id, string name)
        {
            ID = id;
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
