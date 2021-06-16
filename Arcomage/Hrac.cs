using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcomage
{
    public class Hrac: INotifyPropertyChanged
    {
        public List<Karta> balicek;
        public List<Karta> pouzite;
        public Karta[] ruka;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Jmeno { get; set; }
        private int tezba;
        public int Tezba
        {
            get => tezba;
            set
            {
                tezba = value;
                OnPropertyChanged(nameof(Tezba));
            }
        }
        private int magie;
        public int Magie 
        { 
            get => magie;
            set 
            {
                magie = value;
                OnPropertyChanged(nameof(Magie));
            }
        }
        private int jeskyne;
        public int Jeskyne { 
            get => jeskyne;
            set 
            {
                jeskyne = value;
                OnPropertyChanged(nameof(Jeskyne));
            }
        }
        private int cihly;
        public int Cihly 
        { 
            get => cihly;
            set
            {
                cihly = value;
                OnPropertyChanged(nameof(Cihly));
            }
        }
        private int drahokamy;
        public int Drahokamy { 
            get => drahokamy;
            set 
            {
                drahokamy = value;
                OnPropertyChanged(nameof(Drahokamy));
            }
        }
        private int prisery;
        public int Prisery 
        { get => prisery;
            set 
            {
                prisery = value;
                OnPropertyChanged(nameof(Prisery));
            }
        }
        private int vez;
        public int Vez 
        {
            get => vez;
            set 
            {
                vez = value;
                OnPropertyChanged(nameof(vez));
            } 
        }
        private int zed;
        public int Zed 
        { 
            get => zed;
            set 
            {
                zed = value;
                OnPropertyChanged(nameof(zed));
            } 
        }

        public Hrac(string jmeno, List<Karta> balicek, int tezba, int magie, int jeskyne, int cihly, int drahokamy, int prisery, int vez, int zed)
        {
            Jmeno = jmeno;
            Tezba = tezba;
            Magie = magie;
            Jeskyne = jeskyne;
            Cihly = cihly;
            Drahokamy = drahokamy;
            Prisery = prisery;
            Vez = vez;
            Zed = zed;
            this.balicek = balicek;
            pouzite = new List<Karta>();
            ruka = new Karta[5];                        
        }
        public Hrac()
        { 
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
