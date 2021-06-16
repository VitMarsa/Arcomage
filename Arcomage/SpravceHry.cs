using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Arcomage
{
    public class SpravceHry
    {
        Random randomizer;
        public Hrac Hrac1 { get; set; }
        public Hrac Hrac2 { get; set; }
        public Hrac AktualniHrac { get; set; }
        public int VitezstviVez { get; set; }
        public int VitezstviSuroviny { get; set; }
        public bool HrajeZnovu { get; set; }
        public bool OdhazujeKartu { get; set; }
        public bool AI { get; set; }        
        public event Action<SpravceHry> Vitezstvi;
        public event Action<bool> Aktualizuj;
        public string ZpusobVitezstvi;
        public BackgroundList backgroundList;
        private DispatcherTimer timer;
        public string ZahranaKarta { get; set; }
        public string Report { get; set; }
        public SpravceHry(string jmeno1, string jmeno2, int tezba, int magie, int jeskyne, int cihly, int drahokamy, int prisery, int vez, int zed, int vitezstviVez, int vitezstviSuroviny, bool ai)
        {
            randomizer = new Random();
            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(2000)
            };
            timer.Tick += Timer_Tick;
            VitezstviVez = vitezstviVez;
            VitezstviSuroviny = vitezstviSuroviny;
            Hrac1 = new Hrac(jmeno1, VytvorBalicek(), tezba, magie, jeskyne, cihly, drahokamy, prisery, vez, zed);
            LizniPrvniKarty(Hrac1);
            Hrac2 = new Hrac(jmeno2, VytvorBalicek(), tezba, magie, jeskyne, cihly, drahokamy, prisery, vez, zed);
            LizniPrvniKarty(Hrac2);
            HrajeZnovu = false;
            OdhazujeKartu = false;
            AktualniHrac = Hrac1;
            AI = ai;
            backgroundList = new BackgroundList();
            PridejPozadi();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Aktualizuj(false);
            timer.Stop();
        }

        public void PouzijKartu(Karta karta, int i)
        {            
            //Použije kartu z ruky
            karta.Akce(this);
            AktualniHrac.Cihly -= karta.CenaCihly;
            AktualniHrac.Drahokamy -= karta.CenaDrahokamy;
            AktualniHrac.Prisery -= karta.CenaPrisery;
            //Uloží informace o odehrané kartě
            ZahranaKarta = karta.Picture;
            Report = AktualniHrac.Jmeno + " použil " + karta.Jmeno;
            //Vygeneruje novou kartu a nahradí jí stávající v ruce
            AktualniHrac.ruka[i] = LizniKartu(AktualniHrac);
            //Kontroluje, jestli hráč nepoužil celý balíček a případně jej resetuje kromě karet z ruky
            if (AktualniHrac.pouzite.Count == 102)
            {
                AktualniHrac.pouzite.Clear();
                for (int j = 0; j < 5; j++)
                    AktualniHrac.pouzite.Add(AktualniHrac.ruka[j]);
            }
            Aktualizuj(true);
            timer.Start();
            //Kontroluje, jestli hráč nemá hrát znovu
            //Pokud je aktivované AI a stane se aktivním hráčem hráč 2, odehraje AI svůj tah.
            if (!HrajeZnovu)
            {
                KonecTahu();
                if (AktualniHrac == Hrac2 && AI)
                    TahAI();
            }
            else
            {                
                HrajeZnovu = false;
                if (AktualniHrac == Hrac2 && AI)
                    TahAI();
            }
        }

        public void OdhodKartu(Karta karta, int i)
        {            
            //Výjimka pro kartu Magnetovec, která nemůže být odložena
            if (karta.Picture == "Pictures/Cards/Magnetovec.png")
                return;
            //Uloží informace o odehrané kartě
            ZahranaKarta = karta.Picture;
            Report = AktualniHrac.Jmeno + " odhodil " + karta.Jmeno;
            //Vygeneruje novou kartu a nahradí jí stávající v ruce
            AktualniHrac.ruka[i] = LizniKartu(AktualniHrac);
            //Kontroluje, jestli hráč nepoužil celý balíček a případně jej resetuje kromě karet z ruky
            if (AktualniHrac.pouzite.Count == 102)
            {
                AktualniHrac.pouzite.Clear();
                for (int j = 0; j < 5; j++)
                    AktualniHrac.pouzite.Add(AktualniHrac.ruka[j]);
            }
            //Kontroluje, jestli hráč využívá možnosti odhodit a hrát znovu
            //Pokud je aktivované AI a stane se aktivním hráčem hráč 2, odehraje AI svůj tah.
            Aktualizuj(true);
            timer.Start();
            if (!OdhazujeKartu)
            {                
                KonecTahu();
                if (AktualniHrac == Hrac2 && AI)
                    TahAI();
            }
            else
            {
                OdhazujeKartu = false;
                if (AktualniHrac == Hrac2 && AI)
                    TahAI();                             
            }
        }
        public void TahAI()
        {            
            bool dostupnaKarta = false;
            bool neplatnaKarta = true;
            while (neplatnaKarta)
            {
                //Zjistí, zdali je v ruce alespoň jedna použitelná karta
                for (int i = 0; i < 5; i++)
                {
                    if (Dostatek(AktualniHrac.ruka[i]))
                        dostupnaKarta = true;
                }
                //Pokud má vyhodit kartu, tak náhodně vybere jednu z 5
                if (OdhazujeKartu)
                { 
                    dostupnaKarta = false;
                }                
                //Je-li dostupná alespoň jedna karta, AI jednu náhodně použije. Pokud vybere neplatnou, zkouší to znova.
                if (dostupnaKarta)
                {
                    int j = randomizer.Next(5);
                    if (Dostatek(AktualniHrac.ruka[j]))
                    {
                        Report = "použil " + AktualniHrac.ruka[j].Jmeno;                        
                        PouzijKartu(AktualniHrac.ruka[j], j);
                        neplatnaKarta = false;
                        Aktualizuj(false);
                    }
                }
                //Není-li dostupná žádná karta, AI jednu náhdoně odhodí, pokud to není magnetovec. Pokud použil odhazovací kartu, odhodí ji a odehraje nový tah.
                else
                {
                    int j = randomizer.Next(5);
                    if (!(AktualniHrac.ruka[j].Picture == "Pictures/Cards/Magnetovec.png"))
                    {
                        Report = "odhodil " + AktualniHrac.ruka[j].Jmeno;
                        OdhodKartu(AktualniHrac.ruka[j], j);
                        neplatnaKarta = false;                        
                        Aktualizuj(false);
                    }
                }
            }
        }
        private Karta LizniKartu(Hrac hrac)
        {
            bool neplatnaKarta = true;
            Karta karta = new Karta();
            while (neplatnaKarta)
            {
                karta = hrac.balicek[randomizer.Next(102)];
                if (!hrac.pouzite.Any(k => k.Picture == karta.Picture))
                {
                    hrac.pouzite.Add(karta);
                    neplatnaKarta = false;
                }
            }
            return karta;
        }

        public void LizniPrvniKarty(Hrac hrac)
        {
            for (int i = 0; i < 5; i++)
                hrac.ruka[i] = LizniKartu(hrac);
        }

        public void KonecTahu()
        {
            Thread.Sleep(250);
            AktualniHrac.Cihly += AktualniHrac.Tezba;
            AktualniHrac.Drahokamy += AktualniHrac.Magie;
            AktualniHrac.Prisery += AktualniHrac.Jeskyne;
            KontrolaVitezstvi();
            if (AktualniHrac == Hrac1)
                AktualniHrac = Hrac2;
            else
                AktualniHrac = Hrac1;
        }

        public void KontrolaVitezstvi()
        {
            if (AktualniHrac.Vez >= VitezstviVez)
            {
                ZpusobVitezstvi = "Skrze dostavění věže!";
                Vitezstvi(this);
            }
            if (AktualniHrac.Cihly >= VitezstviSuroviny || AktualniHrac.Drahokamy >= VitezstviSuroviny || AktualniHrac.Prisery >= VitezstviSuroviny)
            {
                ZpusobVitezstvi = "Skrze nastřádání surovin!";
                Vitezstvi(this);
            }
            if (AktualniHrac == Hrac1)
            {
                if (Hrac2.Vez <= 0)
                {
                    ZpusobVitezstvi = "Skrze zničení nepřátelské věže!";
                    Vitezstvi(this);

                }
                if (Hrac1.Vez <= 0)
                {
                    AktualniHrac = Hrac2;
                    ZpusobVitezstvi = "Skrze zničení nepřátelské věže!";
                    Vitezstvi(this);
                }
            }
            else
            {
                if (Hrac1.Vez <= 0)
                {
                    ZpusobVitezstvi = "Skrze zničení nepřátelské věže!";
                    Vitezstvi(this);
                }
                if (Hrac2.Vez <= 0)
                {
                    AktualniHrac = Hrac1;
                    ZpusobVitezstvi = "Skrze zničení nepřátelské věže!";
                    Vitezstvi(this);
                }
            }
        }
        public bool Dostatek(Karta karta)
        {
            bool dostatek = true;
            if (karta.CenaCihly > AktualniHrac.Cihly || karta.CenaDrahokamy > AktualniHrac.Drahokamy || karta.CenaPrisery > AktualniHrac.Prisery)
                dostatek = false;
            return dostatek;
        }        
        public List<Karta> VytvorBalicek()
        {
            List<Karta> balicek = new List<Karta>();
            balicek.Add(new Karta("Nedostatek cihel", @"Pictures/Cards/NedostatekCihel.png", 0, 0, 0, Vlastnosti.NedostatekCihel));
            balicek.Add(new Karta("Šťastný nález", @"Pictures/Cards/StastnyNalez.png", 0, 0, 0, Vlastnosti.StastnyNalez));
            balicek.Add(new Karta("Přátelský terén", @"Pictures/Cards/PratelskyTeren.png", 1, 0, 0, Vlastnosti.PratelskyTeren));
            balicek.Add(new Karta("Horníci", @"Pictures/Cards/Hornici.png", 3, 0, 0, Vlastnosti.Hornici));
            balicek.Add(new Karta("Hlavní těžba", @"Pictures/Cards/HlavniTezba.png", 4, 0, 0, Vlastnosti.HlavniTezba));
            balicek.Add(new Karta("Trpaslík", @"Pictures/Cards/Trpaslik.png", 7, 0, 0, Vlastnosti.Trpaslik));
            balicek.Add(new Karta("Přesčas", @"Pictures/Cards/Prescas.png", 2, 0, 0, Vlastnosti.Prescas));
            balicek.Add(new Karta("Vyzvědač", @"Pictures/Cards/Vyzvedac.png", 5, 0, 0, Vlastnosti.Vyzvedac));
            balicek.Add(new Karta("Základní zeď", @"Pictures/Cards/ZakladniZed.png", 2, 0, 0, Vlastnosti.ZakladniZed));
            balicek.Add(new Karta("Hrubá zeď", @"Pictures/Cards/HrubaZed.png", 3, 0, 0, Vlastnosti.HrubaZed));
            balicek.Add(new Karta("Inovace", @"Pictures/Cards/Inovace.png", 2, 0, 0, Vlastnosti.Inovace));
            balicek.Add(new Karta("Základy", @"Pictures/Cards/Zaklady.png", 3, 0, 0, Vlastnosti.Zaklady));
            balicek.Add(new Karta("Otřesy", @"Pictures/Cards/Otresy.png", 7, 0, 0, Vlastnosti.Otresy));
            balicek.Add(new Karta("Tajná místnost", @"Pictures/Cards/TajnaMistnost.png", 8, 0, 0, Vlastnosti.TajnaMistnost));
            balicek.Add(new Karta("Zemětřesení", @"Pictures/Cards/Zemetreseni.png", 0, 0, 0, Vlastnosti.Zemetreseni));
            balicek.Add(new Karta("Velká zeď", @"Pictures/Cards/VelkaZed.png", 5, 0, 0, Vlastnosti.VelkaZed));
            balicek.Add(new Karta("Kolaps", @"Pictures/Cards/Kolaps.png", 4, 0, 0, Vlastnosti.Kolaps));
            balicek.Add(new Karta("Nové vybavení", @"Pictures/Cards/NoveVybaveni.png", 6, 0, 0, Vlastnosti.NoveVybaveni));
            balicek.Add(new Karta("Konec těžby", @"Pictures/Cards/KonecTezby.png", 0, 0, 0, Vlastnosti.KonecTezby));
            balicek.Add(new Karta("Obrněná zeď", @"Pictures/Cards/ObrnenaZed.png", 8, 0, 0, Vlastnosti.ObrnenaZed));
            balicek.Add(new Karta("Mříže", @"Pictures/Cards/Mrize.png", 9, 0, 0, Vlastnosti.Mrize));
            balicek.Add(new Karta("Krytaly", @"Pictures/Cards/Krystaly.png", 9, 0, 0, Vlastnosti.Krystaly));
            balicek.Add(new Karta("Harmonická ruda", @"Pictures/Cards/HarmonickaRuda.png", 11, 0, 0, Vlastnosti.HarmonickaRuda));
            balicek.Add(new Karta("Vysoka zeď", @"Pictures/Cards/VysokaZed.png", 13, 0, 0, Vlastnosti.VysokaZed));
            balicek.Add(new Karta("Návrh", @"Pictures/Cards/PresnyNavrh.png", 15, 0, 0, Vlastnosti.PresnyNavrh));
            balicek.Add(new Karta("Mocná zeď", @"Pictures/Cards/MocnaZed.png", 16, 0, 0, Vlastnosti.MocnaZed));
            balicek.Add(new Karta("Vrhač kamene", @"Pictures/Cards/VrhacKamene.png", 18, 0, 0, Vlastnosti.VrhacKamene));
            balicek.Add(new Karta("Dračí srdce", @"Pictures/Cards/DraciSrdce.png", 24, 0, 0, Vlastnosti.DraciSrdce));
            balicek.Add(new Karta("Nucená práce", @"Pictures/Cards/NucenaPrace.png", 7, 0, 0, Vlastnosti.NucenaPrace));
            balicek.Add(new Karta("Kamenná zahrada", @"Pictures/Cards/KamennaZahrada.png", 1, 0, 0, Vlastnosti.KamennaZahrada));
            balicek.Add(new Karta("Záplavy", @"Pictures/Cards/Zaplavy.png", 6, 0, 0, Vlastnosti.Zaplavy));
            balicek.Add(new Karta("Kasárna", @"Pictures/Cards/Kasarna.png", 10, 0, 0, Vlastnosti.Kasarna));
            balicek.Add(new Karta("Opevnění", @"Pictures/Cards/Opevneni.png", 14, 0, 0, Vlastnosti.Opevneni));
            balicek.Add(new Karta("Přesun", @"Pictures/Cards/Presun.png", 17, 0, 0, Vlastnosti.Presun));
            //Zde začínají karta magie
            balicek.Add(new Karta("Krystal", @"Pictures/Cards/Krystal.png", 0, 1, 0, Vlastnosti.Krystal));
            balicek.Add(new Karta("Kouřouvý krystal", @"Pictures/Cards/KourovyKrystal.png", 0, 2, 0, Vlastnosti.KourovyKrystal));
            balicek.Add(new Karta("Ametyst", @"Pictures/Cards/Ametyst.png", 0, 2, 0, Vlastnosti.Ametyst));
            balicek.Add(new Karta("Vyvolávač", @"Pictures/Cards/Vyvolavac.png", 0, 3, 0, Vlastnosti.Vyvolavac));
            balicek.Add(new Karta("Hranol", @"Pictures/Cards/Hranol.png", 0, 2, 0, Vlastnosti.Hranol));
            balicek.Add(new Karta("Magnetovec", @"Pictures/Cards/Magnetovec.png", 0, 5, 0, Vlastnosti.Magnetovec));
            balicek.Add(new Karta("Sluneční záře", @"Pictures/Cards/SlunecniZare.png", 0, 4, 0, Vlastnosti.SlunecniZare));
            balicek.Add(new Karta("Krystalová matice", @"Pictures/Cards/KrystalovaMatice.png", 0, 6, 0, Vlastnosti.KrystalovaMatice));
            balicek.Add(new Karta("Poškozený diamant", @"Pictures/Cards/PoskozenyDiamant.png", 0, 2, 0, Vlastnosti.PoskozenyDiamant));
            balicek.Add(new Karta("Rubín", @"Pictures/Cards/Rubin.png", 0, 3, 0, Vlastnosti.Rubin));
            balicek.Add(new Karta("Diamantové kopí", @"Pictures/Cards/DiamantoveKopi.png", 0, 4, 0, Vlastnosti.DiamantoveKopi));
            balicek.Add(new Karta("Mocný zážeh", @"Pictures/Cards/MocnyZazeh.png", 0, 3, 0, Vlastnosti.MocnyZazeh));
            balicek.Add(new Karta("Harmonie", @"Pictures/Cards/Harmonie.png", 0, 7, 0, Vlastnosti.Harmonie));
            balicek.Add(new Karta("Vyrovnání", @"Pictures/Cards/Vyrovnani.png", 0, 7, 0, Vlastnosti.Vyrovnani));
            balicek.Add(new Karta("Smaragd", @"Pictures/Cards/Smaragd.png", 0, 6, 0, Vlastnosti.Smaragd));
            balicek.Add(new Karta("Perla vědění", @"Pictures/Cards/PerlaVedeni.png", 0, 9, 0, Vlastnosti.PerlaVedeni));
            balicek.Add(new Karta("Zuřivost", @"Pictures/Cards/Zurivost.png", 0, 8, 0, Vlastnosti.Zurivost));
            balicek.Add(new Karta("Rozpadající kámen", @"Pictures/Cards/RozpadajiciKamen.png", 4, 0, 0, Vlastnosti.RozpadajiciKamen));
            balicek.Add(new Karta("Safír", @"Pictures/Cards/Safir.png", 0, 10, 0, Vlastnosti.Safir));
            balicek.Add(new Karta("Neshoda", @"Pictures/Cards/Neshoda.png", 0, 5, 0, Vlastnosti.Neshoda));
            balicek.Add(new Karta("Ohnivý rubín", @"Pictures/Cards/OhnivyRubin.png", 0, 13, 0, Vlastnosti.OhnivyRubin));
            balicek.Add(new Karta("Těžební výpomoc", @"Pictures/Cards/TezebniVypomoc.png", 0, 4, 0, Vlastnosti.TezebniVypomoc));
            balicek.Add(new Karta("Krystalový štít", @"Pictures/Cards/KrystalovyStit.png", 0, 12, 0, Vlastnosti.KrystalovyStit));
            balicek.Add(new Karta("Přátelský drahokam", @"Pictures/Cards/PratelskyDrahokam.png", 0, 14, 0, Vlastnosti.PratelskyDrahokam));
            balicek.Add(new Karta("Diamant", @"Pictures/Cards/Diamant.png", 0, 16, 0, Vlastnosti.Diamant));
            balicek.Add(new Karta("Svatyně", @"Pictures/Cards/Svatyne.png", 0, 15, 0, Vlastnosti.Svatyne));
            balicek.Add(new Karta("Lávový blok", @"Pictures/Cards/LavovyBlok.png", 0, 17, 0, Vlastnosti.LavovyBlok));
            balicek.Add(new Karta("Dračí oko", @"Pictures/Cards/DraciOko.png", 0, 21, 0, Vlastnosti.DraciOko));
            balicek.Add(new Karta("Krystalizace", @"Pictures/Cards/Krystalizace.png", 0, 8, 0, Vlastnosti.Krystalizace));
            balicek.Add(new Karta("Balíček drobností", @"Pictures/Cards/BalicekDrobnosti.png", 0, 0, 0, Vlastnosti.BalicekDrobnosti));
            balicek.Add(new Karta("Duha", @"Pictures/Cards/Duha.png", 0, 0, 0, Vlastnosti.Duha));
            balicek.Add(new Karta("Učedník blesku", @"Pictures/Cards/UcednikBlesku.png", 0, 5, 0, Vlastnosti.UcednikBlesku));
            balicek.Add(new Karta("Odraz blesku", @"Pictures/Cards/OdrazBlesku.png", 0, 11, 0, Vlastnosti.OdrazBlesku));
            balicek.Add(new Karta("Proměna drahokamu", @"Pictures/Cards/PromenaDrahokamu.png", 0, 18, 0, Vlastnosti.PromenaDrahokamu));
            //Zde začínají karty Příšer
            balicek.Add(new Karta("Nemoc šílených krav", @"Pictures/Cards/NemocSilenychKrav.png", 0, 0, 0, Vlastnosti.NemocSilenychKrav));
            balicek.Add(new Karta("Víla", @"Pictures/Cards/Vila.png", 0, 0, 1, Vlastnosti.Vila));
            balicek.Add(new Karta("Mrzutí goblini", @"Pictures/Cards/MrzutiGoblini.png", 0, 0, 1, Vlastnosti.MrzutiGoblini));
            balicek.Add(new Karta("Minotaur", @"Pictures/Cards/Minotaur.png", 0, 0, 3, Vlastnosti.Minotaur));
            balicek.Add(new Karta("Elfí průzkumník", @"Pictures/Cards/ElfiPruzkumnik.png", 0, 0, 2, Vlastnosti.ElfiPruzkumnik));
            balicek.Add(new Karta("Dav goblinů", @"Pictures/Cards/DavGoblinu.png", 0, 0, 3, Vlastnosti.DavGoblinu));
            balicek.Add(new Karta("Gobliní lukostřelci", @"Pictures/Cards/GobliniLukostrelci.png", 0, 0, 4, Vlastnosti.GobliniLukostrelci));
            balicek.Add(new Karta("Temná víla", @"Pictures/Cards/TemnaVila.png", 0, 0, 6, Vlastnosti.TemnaVila));
            balicek.Add(new Karta("Skřet", @"Pictures/Cards/Skret.png", 0, 0, 3, Vlastnosti.Skret));
            balicek.Add(new Karta("Trpaslíci", @"Pictures/Cards/Trpaslici.png", 0, 0, 5, Vlastnosti.Trpaslici));
            balicek.Add(new Karta("Malí hadi", @"Pictures/Cards/MaliHadi.png", 0, 0, 6, Vlastnosti.MaliHadi));
            balicek.Add(new Karta("Trolí dozorce", @"Pictures/Cards/TroliDozorce.png", 0, 0, 7, Vlastnosti.TroliDozorce));
            balicek.Add(new Karta("Gemlin", @"Pictures/Cards/Gremlin.png", 0, 0, 8, Vlastnosti.Gremlin));
            balicek.Add(new Karta("Úplněk", @"Pictures/Cards/Uplnek.png", 0, 0, 0, Vlastnosti.Uplnek));
            balicek.Add(new Karta("Dobyvatel", @"Pictures/Cards/Dobyvatel.png", 0, 0, 5, Vlastnosti.Dobyvatel));
            balicek.Add(new Karta("Zlobr", @"Pictures/Cards/Zlobr.png", 0, 0, 6, Vlastnosti.Zlobr));
            balicek.Add(new Karta("Divoká ovce", @"Pictures/Cards/DivokaOvce.png", 0, 0, 6, Vlastnosti.DivokaOvce));
            balicek.Add(new Karta("Imp", @"Pictures/Cards/Imp.png", 0, 0, 5, Vlastnosti.Imp));
            balicek.Add(new Karta("Divoký čmelák", @"Pictures/Cards/DivokyCmelak.png", 0, 0, 8, Vlastnosti.DivokyCmelak));
            balicek.Add(new Karta("Vlkodlak", @"Pictures/Cards/Vlkodlak.png", 0, 0, 9, Vlastnosti.Vlkodlak));
            balicek.Add(new Karta("Mrak koroze", @"Pictures/Cards/MrakKoroze.png", 0, 0, 11, Vlastnosti.MrakKoroze));
            balicek.Add(new Karta("Jednorožec", @"Pictures/Cards/Jednorozec.png", 0, 0, 9, Vlastnosti.Jednorozec));
            balicek.Add(new Karta("Elfí lukostřelec", @"Pictures/Cards/ElfiLukostrelci.png", 0, 0, 10, Vlastnosti.ElfiLukostrelci));
            balicek.Add(new Karta("Sukuba", @"Pictures/Cards/Sukuba.png", 0, 0, 14, Vlastnosti.Sukuba));
            balicek.Add(new Karta("Kamenní bojovníci", @"Pictures/Cards/KamenniBojovnici.png", 0, 0, 11, Vlastnosti.KamenniBojovnici));
            balicek.Add(new Karta("Zlodej", @"Pictures/Cards/Zlodej.png", 0, 0, 12, Vlastnosti.Zlodej));
            balicek.Add(new Karta("Kameny obr", @"Pictures/Cards/KamenyObr.png", 0, 0, 15, Vlastnosti.KamenyObr));
            balicek.Add(new Karta("Upír", @"Pictures/Cards/Upir.png", 0, 0, 17, Vlastnosti.Upir));
            balicek.Add(new Karta("Drak", @"Pictures/Cards/Drak.png", 0, 0, 25, Vlastnosti.Drak));
            balicek.Add(new Karta("Kopiník", @"Pictures/Cards/Kopinik.png", 0, 0, 2, Vlastnosti.Kopinik));
            balicek.Add(new Karta("Gnóm", @"Pictures/Cards/Gnom.png", 0, 0, 2, Vlastnosti.Gnom));
            balicek.Add(new Karta("Berserkr", @"Pictures/Cards/Berserkr.png", 0, 0, 4, Vlastnosti.Berserkr));
            balicek.Add(new Karta("Válečník", @"Pictures/Cards/Valecnik.png", 0, 0, 13, Vlastnosti.Valecnik));
            balicek.Add(new Karta("Pegas kopiník", @"Pictures/Cards/PegasKopinik.png", 0, 0, 18, Vlastnosti.PegasKopinik));
            return balicek;
        }
        private void PridejPozadi()
        {
            backgroundList.PridejPozadi("Hrdinové dobra i zla", @"Pictures/background1.jpg");
            backgroundList.PridejPozadi("Bitva Prvního věku", @"Pictures/background2.jpg");
            backgroundList.PridejPozadi("Skřetí vojska", @"Pictures/background3.jpg");
            backgroundList.PridejPozadi("Oheň a čaroděj", @"Pictures/background4.jpg");
            backgroundList.PridejPozadi("Poslední vzdor", @"Pictures/background5.jpg");
            backgroundList.PridejPozadi("Pád Gondolinu", @"Pictures/background6.jpg");
            backgroundList.PridejPozadi("Gothmog a Ecthelion", @"Pictures/background7.jpg");
        }
    }    
}
