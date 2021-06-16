using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcomage
{
    public class BackgroundList
    {
        public ObservableCollection<Pozadi> pozadiList;
        public BackgroundList()
        {
            pozadiList = new ObservableCollection<Pozadi>();
        }
        public void PridejPozadi(string jmeno, string picture)
        {
            pozadiList.Add(new Pozadi(jmeno, picture));
        }
    }
}
