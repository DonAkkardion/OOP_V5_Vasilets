using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V5_Vasilets.Model
{
    public class Plane
    {
        private int ID;
        private string name;
        public string Name { get => name; set => name = value; }

        public Plane( string Name )
        {
            this.Name = Name;
        }

        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}
