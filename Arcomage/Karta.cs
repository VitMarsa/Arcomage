using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcomage
{
    public class Karta
    {
        public string Jmeno { get; set; }
        public string Picture { get; set; }
        public int CenaCihly { get; set; }
        public int CenaDrahokamy { get; set; }
        public int CenaPrisery { get; set; }
        public event Action<SpravceHry> Vlastnost;

        public Karta(string jmeno, string picture, int cenaCihly, int cenaDrahokamy, int cenaPrisery, Action<SpravceHry> vlastnost)
        {
            Jmeno = jmeno;
            Picture = picture;
            CenaCihly = cenaCihly;
            CenaDrahokamy = cenaDrahokamy;
            CenaPrisery = cenaPrisery;
            Vlastnost = vlastnost;
        }
        public Karta()
        { 
        }

        public void Akce(SpravceHry spravce)
        {
            Vlastnost?.Invoke(spravce);
        }
    }
}
