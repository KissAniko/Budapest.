using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budapest
{
    internal class Kozterulet
    {
        int irsz;
        string nev;
        string utotag;
        string ker;

        public Kozterulet(int irsz, string nev, string utotag, string ker)
        {
            this.irsz = irsz;
            this.nev = nev;
            this.utotag = utotag;
            this.ker = ker;
        }

        public int Irsz { get => irsz; set => irsz = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Utotag { get => utotag; set => utotag = value; }
        public string Ker { get => ker; set => ker = value; }

        
    }
}
