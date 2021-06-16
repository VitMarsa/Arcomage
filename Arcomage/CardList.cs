using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcomage
{
    public class CardList<Karta>: List<Karta>
    {
        public bool Contains(Karta karta)
        {
            bool contain = false;
            foreach (Karta KartaZListu in this)
                if (KartaZListu.Picture == karta.Picture)
                    contain = true;
            return contain;
        }
    }
}
