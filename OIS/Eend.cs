using System;
using System.Collections.Generic;
using System.Text;

namespace OIS
{
    class Eend
    {
        public string naam { get; private set; }
        public string geslacht { get; private set;}
        public Eend(string Naam, string Geslacht)
        {
            this.naam = Naam;
            this.geslacht = Geslacht;
        }
    }
}
