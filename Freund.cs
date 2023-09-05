using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoGuts
{
    internal class Freund : World
    {
        bool freundschaft;
        public Freund(string name, bool freundschaft)
        {
            Name = name;
            Freundschaft = freundschaft;
        }

        public bool Freundschaft { get => freundschaft; set => freundschaft = value; }
    }
}
