using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoGuts
{
    internal class Freundin : World
    {
        bool smexy;
        public Freundin(string name, int alter, bool smexy)
        {
            Name = name;
            Alter = alter;
            Smexy = smexy;
        }

        public bool Smexy { get => smexy; set => smexy = value; }
    }
}
