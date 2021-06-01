using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcomage
{
    public class Pozadi
    {
        public string Jmeno { get; set; }
        public string Picture { get; set; }

        public Pozadi(string jmeno, string picture)
        {
            Jmeno = jmeno;
            Picture = picture;
        }
        public override string ToString()
        {
            return Jmeno;
        }
    }
}
