using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcomage
{
    static class Vlastnosti
    {
        private static void Poskozeni(int dmg, Hrac hrac)
        {
            if (dmg > hrac.Zed)
            {                
                dmg -= hrac.Zed;
                hrac.Zed = 0;
                hrac.Vez -= dmg;
                if (hrac.Vez < 0)
                    hrac.Vez = 0;
            }
            else
                hrac.Zed -= dmg;
        }
        public static void NedostatekCihel(SpravceHry spravce)
        {
            spravce.Hrac1.Cihly -= 8;
            if (spravce.Hrac1.Cihly < 0)
                spravce.Hrac1.Cihly = 0;
            spravce.Hrac2.Cihly -= 8;
            if (spravce.Hrac2.Cihly < 0)
                spravce.Hrac2.Cihly = 0;
        }
        public static void StastnyNalez(SpravceHry spravce)
        {
            spravce.AktualniHrac.Cihly += 2;
            spravce.AktualniHrac.Drahokamy += 2;
            spravce.HrajeZnovu = true;
        }
        public static void PratelskyTeren(SpravceHry spravce)
        {
            spravce.AktualniHrac.Zed += 1;
            spravce.HrajeZnovu = true;
        }
        public static void Hornici(SpravceHry spravce)
        {
            spravce.AktualniHrac.Tezba += 1;
        }
        public static void HlavniTezba(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                if (spravce.Hrac1.Tezba < spravce.Hrac2.Tezba)
                    spravce.AktualniHrac.Tezba += 2;
                else
                    spravce.AktualniHrac.Tezba += 1;
            }
            else
            {
                if (spravce.Hrac2.Tezba < spravce.Hrac1.Tezba)
                    spravce.AktualniHrac.Tezba += 2;
                else
                    spravce.AktualniHrac.Tezba += 1;
            }
        }
        public static void Trpaslik(SpravceHry spravce)
        {
            spravce.AktualniHrac.Tezba += 1;
            spravce.AktualniHrac.Zed += 4;
        }
        public static void Prescas(SpravceHry spravce)
        {
            spravce.AktualniHrac.Zed += 5;
            spravce.AktualniHrac.Drahokamy -= 5;
            if (spravce.AktualniHrac.Drahokamy < 0)
                spravce.AktualniHrac.Drahokamy = 0;
        }
        public static void Vyzvedac(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                if (spravce.Hrac1.Tezba < spravce.Hrac2.Tezba)
                    spravce.AktualniHrac.Tezba = spravce.Hrac2.Tezba;
            }
            else
            {
                if (spravce.Hrac2.Tezba < spravce.Hrac1.Tezba)
                    spravce.AktualniHrac.Tezba = spravce.Hrac1.Tezba;
            }
        }
        public static void ZakladniZed(SpravceHry spravce)
        {
            spravce.AktualniHrac.Zed += 3;
        }

        public static void HrubaZed(SpravceHry spravce)
        {
            spravce.AktualniHrac.Zed += 4;
        }
        public static void Inovace(SpravceHry spravce)
        {
            spravce.Hrac1.Tezba += 1;
            spravce.Hrac2.Tezba += 1;
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac1.Drahokamy += 4;
            }
            else
            {
                spravce.Hrac2.Drahokamy += 4;
            }
        }

        public static void Zaklady(SpravceHry spravce)
        {
            if (spravce.AktualniHrac.Zed == 0)
                spravce.AktualniHrac.Zed = 6;
            else
                spravce.AktualniHrac.Zed += 3;
        }

        public static void Otresy(SpravceHry spravce)
        {
            spravce.Hrac1.Zed -= 5;
            if (spravce.Hrac1.Zed < 0)
                spravce.Hrac1.Zed = 0;
            spravce.Hrac2.Zed -= 5;
            if (spravce.Hrac2.Zed < 0)
                spravce.Hrac2.Zed = 0;
            spravce.HrajeZnovu = true;
        }

        public static void TajnaMistnost(SpravceHry spravce)
        {
            spravce.AktualniHrac.Magie += 1;
            spravce.HrajeZnovu = true;
        }

        public static void Zemetreseni(SpravceHry spravce)
        {
            spravce.Hrac1.Tezba -= 1;
            if (spravce.Hrac1.Tezba < 1)
                spravce.Hrac1.Tezba = 1;
            spravce.Hrac2.Tezba -= 1;
            if (spravce.Hrac2.Tezba < 1)
                spravce.Hrac2.Tezba = 1;
        }

        public static void VelkaZed(SpravceHry spravce)
        {
            spravce.AktualniHrac.Zed += 6;
        }

        public static void Kolaps(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac2.Tezba -= 1;
                if (spravce.Hrac2.Tezba < 1)
                    spravce.Hrac2.Tezba = 1;
            }
            else
            {
                spravce.Hrac1.Tezba -= 1;
                if (spravce.Hrac1.Tezba < 1)
                    spravce.Hrac1.Tezba = 1;
            }
        }
        public static void NoveVybaveni(SpravceHry spravce)
        {
            spravce.AktualniHrac.Tezba += 2;
        }
        public static void KonecTezby(SpravceHry spravce)
        {
            spravce.AktualniHrac.Tezba -= 1;
            if (spravce.AktualniHrac.Tezba < 1)
                spravce.AktualniHrac.Tezba = 1;
            spravce.AktualniHrac.Zed += 10;
            spravce.AktualniHrac.Drahokamy += 5;
        }
        public static void ObrnenaZed(SpravceHry spravce)
        {
            spravce.AktualniHrac.Zed += 8;
        }

        public static void Mrize(SpravceHry spravce)
        {
            spravce.AktualniHrac.Zed += 5;
            spravce.AktualniHrac.Jeskyne += 1;
        }

        public static void Krystaly(SpravceHry spravce)
        {
            spravce.AktualniHrac.Zed += 7;
            spravce.AktualniHrac.Drahokamy += 7;
        }

        public static void HarmonickaRuda(SpravceHry spravce)
        {
            spravce.AktualniHrac.Zed += 6;
            spravce.AktualniHrac.Vez += 3;
        }

        public static void VysokaZed(SpravceHry spravce)
        {
            spravce.AktualniHrac.Zed += 12;
        }

        public static void PresnyNavrh(SpravceHry spravce)
        {
            spravce.AktualniHrac.Zed += 8;
            spravce.AktualniHrac.Vez += 5;
        }

        public static void MocnaZed(SpravceHry spravce)
        {
            spravce.AktualniHrac.Zed += 15;
        }

        public static void VrhacKamene(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac1.Zed += 6;
                Poskozeni(10, spravce.Hrac2);
            }
            else
            {
                spravce.Hrac2.Zed += 6;
                Poskozeni(10, spravce.Hrac1);
            }
        }

        public static void DraciSrdce(SpravceHry spravce)
        {
            spravce.AktualniHrac.Zed += 20;
            spravce.AktualniHrac.Vez += 8;
        }

        public static void NucenaPrace(SpravceHry spravce)
        {
            spravce.AktualniHrac.Zed += 9;
            spravce.AktualniHrac.Prisery -= 5;
            if (spravce.AktualniHrac.Prisery < 0)
                spravce.AktualniHrac.Prisery = 0;
        }

        public static void KamennaZahrada(SpravceHry spravce)
        {
            spravce.AktualniHrac.Zed += 1;
            spravce.AktualniHrac.Vez += 1;
            spravce.AktualniHrac.Prisery += 2;
        }

        public static void Zaplavy(SpravceHry spravce)
        {
            if (spravce.Hrac1.Zed > spravce.Hrac2.Zed)
            {
                spravce.Hrac2.Jeskyne -= 1;
                spravce.Hrac2.Vez -= 2;
                if (spravce.Hrac2.Jeskyne < 1)
                    spravce.Hrac2.Jeskyne = 1;
                if (spravce.Hrac2.Vez < 0)
                    spravce.Hrac2.Vez = 0;
            }
            if (spravce.Hrac2.Zed < spravce.Hrac1.Zed)
            {
                spravce.Hrac1.Jeskyne -= 1;
                spravce.Hrac1.Vez -= 2;
                if (spravce.Hrac1.Jeskyne < 1)
                    spravce.Hrac1.Jeskyne = 0;
                if (spravce.Hrac1.Vez < 0)
                    spravce.Hrac1.Vez = 0;
            }
        }

        public static void Kasarna(SpravceHry spravce)
        {
            spravce.AktualniHrac.Prisery += 6;
            spravce.AktualniHrac.Zed += 6;
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                if (spravce.Hrac1.Jeskyne < spravce.Hrac2.Jeskyne)
                    spravce.Hrac1.Jeskyne += 1;
            }
            else
            {
                if (spravce.Hrac2.Jeskyne < spravce.Hrac1.Jeskyne)
                    spravce.Hrac2.Jeskyne += 1;
            }
        }

        public static void Opevneni(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac1.Zed += 7;
                Poskozeni(6, spravce.Hrac2);
            }
            else
            {
                spravce.Hrac2.Zed += 7;
                Poskozeni(6, spravce.Hrac1);
            }
        }

        public static void Presun(SpravceHry spravce)
        {
            int prohod = spravce.Hrac1.Zed;
            spravce.Hrac1.Zed = spravce.Hrac2.Zed;
            spravce.Hrac2.Zed = prohod;
        }

        public static void Krystal(SpravceHry spravce)
        {
            spravce.AktualniHrac.Vez += 1;
            spravce.HrajeZnovu = true;
        }

        public static void KourovyKrystal(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac2.Vez -= 1;
                if (spravce.Hrac2.Vez < 0)
                    spravce.Hrac2.Vez = 0;
            }
            else
            {
                spravce.Hrac1.Vez -= 1;
                if (spravce.Hrac1.Vez < 0)
                    spravce.Hrac1.Vez = 0;
            }
            spravce.HrajeZnovu = true;
        }

        public static void Ametyst(SpravceHry spravce)
        {
            spravce.AktualniHrac.Vez += 3;            
        }

        public static void Vyvolavac(SpravceHry spravce)
        {
            spravce.AktualniHrac.Magie += 1;
        }

        public static void Hranol(SpravceHry spravce)
        {
            spravce.OdhazujeKartu = true;
            spravce.HrajeZnovu = true;
        }

        public static void Magnetovec(SpravceHry spravce)
        {
            spravce.AktualniHrac.Vez += 3;
        }

        public static void SlunecniZare(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac1.Vez += 2;
                spravce.Hrac2.Vez -= 2;
                if (spravce.Hrac2.Vez < 0)
                    spravce.Hrac2.Vez = 0;
            }
            else
            {
                spravce.Hrac2.Vez += 2;
                spravce.Hrac1.Vez -= 2;
                if (spravce.Hrac1.Vez < 0)
                    spravce.Hrac1.Vez = 0;
            }
        }

        public static void KrystalovaMatice(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac1.Magie += 1;
                spravce.Hrac1.Vez += 3;
                spravce.Hrac2.Vez += 1;
            }
            else
            {
                spravce.Hrac2.Magie += 1;
                spravce.Hrac2.Vez += 3;
                spravce.Hrac1.Vez += 1;
            }
        }

        public static void PoskozenyDiamant(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac2.Vez -= 3;
                if (spravce.Hrac2.Vez < 0)
                    spravce.Hrac2.Vez = 0;
            }
            else
            {
                spravce.Hrac1.Vez -= 3;
                if (spravce.Hrac1.Vez < 0)
                    spravce.Hrac1.Vez = 0;
            }
        }

        public static void Rubin(SpravceHry spravce)
        {
            spravce.AktualniHrac.Vez += 5;
        }

        public static void DiamantoveKopi(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac2.Vez -= 5;
                if (spravce.Hrac2.Vez < 0)
                    spravce.Hrac2.Vez = 0;
            }
            else
            {
                spravce.Hrac1.Vez -= 5;
                if (spravce.Hrac1.Vez < 0)
                    spravce.Hrac1.Vez = 0;
            }
        }

        public static void MocnyZazeh(SpravceHry spravce)
        {
            spravce.AktualniHrac.Vez -= 5;
            if (spravce.AktualniHrac.Vez < 0)
                spravce.AktualniHrac.Vez = 0;
            spravce.AktualniHrac.Magie += 2;
        }

        public static void Harmonie(SpravceHry spravce)
        {
            spravce.AktualniHrac.Magie += 1;
            spravce.AktualniHrac.Vez += 3;
            spravce.AktualniHrac.Zed += 3;
        }

        public static void Vyrovnani(SpravceHry spravce)
        {
            if (spravce.Hrac1.Magie > spravce.Hrac2.Magie)
                spravce.Hrac2.Magie = spravce.Hrac1.Magie;
            else
                spravce.Hrac1.Magie = spravce.Hrac2.Magie;
        }

        public static void Smaragd(SpravceHry spravce)
        {
            spravce.AktualniHrac.Vez += 8;
        }
        public static void PerlaVedeni(SpravceHry spravce)
        {
            spravce.AktualniHrac.Vez += 5;
            spravce.AktualniHrac.Magie += 1;
        }
        public static void Zurivost(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac1.Magie -= 1;
                if (spravce.Hrac1.Magie < 1)
                    spravce.Hrac1.Magie = 1;
                spravce.Hrac2.Vez -= 9;
                if (spravce.Hrac2.Vez < 0)
                    spravce.Hrac2.Vez = 0;
            }
            else
            {
                spravce.Hrac2.Magie -= 1;
                if (spravce.Hrac2.Magie < 1)
                    spravce.Hrac2.Magie = 1;
                spravce.Hrac1.Vez -= 9;
                if (spravce.Hrac1.Vez < 0)
                    spravce.Hrac1.Vez = 0;
            }
        }
        public static void RozpadajiciKamen(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac1.Vez += 5;
                spravce.Hrac2.Cihly -= 6;
                if (spravce.Hrac2.Cihly < 0)
                    spravce.Hrac2.Cihly = 0;
            }
            else
            {
                spravce.Hrac2.Vez += 5;
                spravce.Hrac1.Cihly -= 6;
                if (spravce.Hrac1.Cihly < 0)
                    spravce.Hrac1.Cihly = 0;
            }
        }
        public static void Safir(SpravceHry spravce)
        {
            spravce.AktualniHrac.Vez += 11;
        }
        public static void Neshoda(SpravceHry spravce)
        {
            spravce.Hrac1.Vez -= 7;
            if (spravce.Hrac1.Vez < 0)
                spravce.Hrac1.Vez = 0;
            spravce.Hrac1.Magie -= 1;
            if (spravce.Hrac1.Magie < 1)
                spravce.Hrac1.Magie = 1;
            spravce.Hrac2.Vez -= 7;
            if (spravce.Hrac2.Vez < 0)
                spravce.Hrac2.Vez = 0;
            spravce.Hrac2.Magie -= 1;
            if (spravce.Hrac2.Magie < 1)
                spravce.Hrac2.Magie = 1;
        }
        public static void OhnivyRubin(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac1.Vez += 6;
                spravce.Hrac2.Vez -= 4;
                if (spravce.Hrac2.Vez < 0)
                    spravce.Hrac2.Vez = 0;
            }
            else
            {
                spravce.Hrac2.Vez += 6;
                spravce.Hrac1.Vez -= 4;
                if (spravce.Hrac1.Vez < 0)
                    spravce.Hrac1.Vez = 0;
            }
        }
        public static void TezebniVypomoc(SpravceHry spravce)
        {
            spravce.AktualniHrac.Vez += 7;
            spravce.AktualniHrac.Cihly -= 10;
            if (spravce.AktualniHrac.Cihly < 1)
                spravce.AktualniHrac.Cihly = 1;
        }
        public static void KrystalovyStit(SpravceHry spravce)
        {
            spravce.AktualniHrac.Vez += 8;
            spravce.AktualniHrac.Zed += 3;
        }
        public static void PratelskyDrahokam(SpravceHry spravce)
        {
            spravce.AktualniHrac.Vez += 8;
            spravce.AktualniHrac.Jeskyne += 1;
        }
        public static void Diamant(SpravceHry spravce)
        {
            spravce.AktualniHrac.Vez += 15;            
        }
        public static void Svatyne(SpravceHry spravce)
        {
            spravce.AktualniHrac.Vez += 10;
            spravce.AktualniHrac.Zed += 5;
            spravce.AktualniHrac.Prisery += 5;
        }
        public static void LavovyBlok(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac1.Vez += 12;
                Poskozeni(6, spravce.Hrac2);
            }
            else
            {
                spravce.Hrac2.Vez += 12;
                Poskozeni(6, spravce.Hrac1);
            }
        }
        public static void DraciOko(SpravceHry spravce)
        {
            spravce.AktualniHrac.Vez += 20;
        }
        public static void Krystalizace(SpravceHry spravce)
        {
            spravce.AktualniHrac.Vez += 11;
            spravce.AktualniHrac.Zed -= 6;
            if (spravce.AktualniHrac.Zed < 0)
                spravce.AktualniHrac.Zed = 0;
        }
        public static void BalicekDrobnosti(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                if (spravce.Hrac1.Vez < spravce.Hrac2.Vez)
                    spravce.Hrac1.Vez += 2;
                else
                    spravce.Hrac1.Vez += 1;
            }
            else
            {
                if (spravce.Hrac2.Vez < spravce.Hrac1.Vez)
                    spravce.Hrac2.Vez += 2;
                else
                    spravce.Hrac2.Vez += 1;
            }
        }
        public static void Duha(SpravceHry spravce)
        {
            spravce.Hrac1.Vez += 1;
            spravce.Hrac2.Vez += 1;
            spravce.AktualniHrac.Drahokamy += 3;
        }
        public static void UcednikBlesku(SpravceHry spravce)
        {            
            spravce.AktualniHrac.Vez += 4;
            spravce.AktualniHrac.Prisery -= 3;
            if (spravce.AktualniHrac.Prisery < 0)
                spravce.AktualniHrac.Prisery = 0;
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac2.Vez -= 2;
                if (spravce.Hrac2.Vez < 0)
                    spravce.Hrac2.Vez = 0;
            }
            else
            {
                spravce.Hrac1.Vez -= 2;
                if (spravce.Hrac1.Vez < 0)
                    spravce.Hrac1.Vez = 0;
            }
        }
        public static void OdrazBlesku(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                if (spravce.Hrac1.Vez > spravce.Hrac2.Zed)
                    spravce.Hrac2.Vez -= 8;
                else
                    Poskozeni(8, spravce.Hrac2);
            }
            else
            {
                if (spravce.Hrac2.Vez > spravce.Hrac1.Zed)
                    spravce.Hrac1.Vez -= 8;
                else
                    Poskozeni(8, spravce.Hrac1);
            }
        }

        public static void PromenaDrahokamu(SpravceHry spravce)
        {
            spravce.AktualniHrac.Vez += 13;
            spravce.AktualniHrac.Prisery += 6;
            spravce.AktualniHrac.Cihly += 6;
        }

        public static void NemocSilenychKrav(SpravceHry spravce)
        {
            spravce.Hrac1.Prisery -= 6;
            if (spravce.Hrac1.Prisery < 0)
                spravce.Hrac1.Prisery = 0;
            spravce.Hrac2.Prisery -= 6;
            if (spravce.Hrac2.Prisery < 0)
                spravce.Hrac2.Prisery = 0;
        }
        public static void Vila(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(2, spravce.Hrac2);
            }
            else
            {
                Poskozeni(2, spravce.Hrac1);
            }
            spravce.HrajeZnovu = true;
        }
        public static void MrzutiGoblini(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(4, spravce.Hrac2);
                spravce.Hrac1.Drahokamy -= 3;
                if (spravce.Hrac1.Drahokamy < 0)
                    spravce.Hrac1.Drahokamy = 0;
            }
            else
            {
                Poskozeni(4, spravce.Hrac1);
                spravce.Hrac2.Drahokamy -= 3;
                if (spravce.Hrac2.Drahokamy < 0)
                    spravce.Hrac2.Drahokamy = 0;
            }
        }
        public static void Minotaur(SpravceHry spravce)
        {
            spravce.AktualniHrac.Jeskyne += 1;
        }
        public static void ElfiPruzkumnik(SpravceHry spravce)
        {
            spravce.OdhazujeKartu = true;
            spravce.HrajeZnovu = true;
        }
        public static void DavGoblinu(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(6, spravce.Hrac2);
                Poskozeni(3, spravce.Hrac1);
            }
            else
            {
                Poskozeni(6, spravce.Hrac1);
                Poskozeni(3, spravce.Hrac2);
            }
        }
        public static void GobliniLukostrelci(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac2.Vez -= 3;
                if (spravce.Hrac2.Vez < 0)
                    spravce.Hrac2.Vez = 0;
                Poskozeni(1, spravce.Hrac1);
            }
            else
            {
                spravce.Hrac1.Vez -= 3;
                if (spravce.Hrac1.Vez < 0)
                    spravce.Hrac1.Vez = 0;
                Poskozeni(1, spravce.Hrac2);
            }
        }
        public static void TemnaVila(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac2.Vez -= 2;
                if (spravce.Hrac2.Vez < 0)
                    spravce.Hrac2.Vez = 0;
            }
            else
            {
                spravce.Hrac1.Vez -= 2;
                if (spravce.Hrac1.Vez < 0)
                    spravce.Hrac1.Vez = 0;
            }
            spravce.HrajeZnovu = true;
        }
        public static void Skret(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(5, spravce.Hrac2);
            }
            else
            {
                Poskozeni(5, spravce.Hrac1);
            }
        }
        public static void Trpaslici(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(4, spravce.Hrac2);
                spravce.Hrac1.Zed += 3;
            }
            else
            {
                Poskozeni(4, spravce.Hrac1);
                spravce.Hrac2.Zed += 3;
            }
        }
        public static void MaliHadi(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac2.Vez -= 4;
                if (spravce.Hrac2.Vez < 0)
                    spravce.Hrac2.Vez = 0;
            }
            else
            {
                spravce.Hrac1.Vez -= 4;
                if (spravce.Hrac1.Vez < 0)
                    spravce.Hrac1.Vez = 0;
            }
        }
        public static void TroliDozorce(SpravceHry spravce)
        {
            spravce.AktualniHrac.Jeskyne += 2;
        }
        public static void Gremlin(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(2, spravce.Hrac2);
                spravce.Hrac1.Zed += 4;
                spravce.Hrac1.Vez += 2;
            }
            else
            {
                Poskozeni(2, spravce.Hrac1);
                spravce.Hrac2.Zed += 4;
                spravce.Hrac2.Zed += 2;
            }
        }
        public static void Uplnek(SpravceHry spravce)
        {
            spravce.Hrac1.Jeskyne += 1;
            spravce.Hrac2.Jeskyne += 1;
            spravce.AktualniHrac.Prisery += 3;
        }
        public static void Dobyvatel(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(6, spravce.Hrac2);
            }
            else
            {
                Poskozeni(6, spravce.Hrac1);
            }
        }
        public static void Zlobr(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(7, spravce.Hrac2);
            }
            else
            {
                Poskozeni(7, spravce.Hrac1);
            }
        }
        public static void DivokaOvce(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(6, spravce.Hrac2);
                spravce.Hrac2.Prisery -= 3;
                if (spravce.Hrac2.Prisery < 0)
                    spravce.Hrac2.Prisery = 0;
            }
            else
            {
                Poskozeni(6, spravce.Hrac1);
                spravce.Hrac1.Prisery -= 3;
                if (spravce.Hrac1.Prisery < 0)
                    spravce.Hrac1.Prisery = 0;
            }
        }
        public static void Imp(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(6, spravce.Hrac2);
            }
            else
            {
                Poskozeni(6, spravce.Hrac1);
            }
            spravce.Hrac1.Cihly -= 5;
            if (spravce.Hrac1.Cihly < 0)
                spravce.Hrac1.Cihly = 0;
            spravce.Hrac1.Drahokamy -= 5;
            if (spravce.Hrac1.Drahokamy < 0)
                spravce.Hrac1.Drahokamy = 0;
            spravce.Hrac1.Prisery -= 5;
            if (spravce.Hrac1.Prisery < 0)
                spravce.Hrac1.Prisery = 0;
            spravce.Hrac2.Cihly -= 5;
            if (spravce.Hrac2.Cihly < 0)
                spravce.Hrac2.Cihly = 0;
            spravce.Hrac2.Drahokamy -= 5;
            if (spravce.Hrac2.Drahokamy < 0)
                spravce.Hrac2.Drahokamy = 0;
            spravce.Hrac2.Prisery -= 5;
            if (spravce.Hrac2.Drahokamy < 0)
                spravce.Hrac2.Drahokamy = 0;
        }
        public static void DivokyCmelak(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                if (spravce.Hrac2.Zed == 0)
                    Poskozeni(10, spravce.Hrac2);
                else
                    Poskozeni(6, spravce.Hrac2);
            }
            else
            {
                if (spravce.Hrac1.Zed == 0)
                    Poskozeni(10, spravce.Hrac1);
                else
                    Poskozeni(6, spravce.Hrac1);
            }
        }
        public static void Vlkodlak(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(9, spravce.Hrac2);

            }
            else
            {
                Poskozeni(9, spravce.Hrac1);
            }
        }
        public static void MrakKoroze(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                if (spravce.Hrac2.Zed > 0)
                    Poskozeni(10, spravce.Hrac2);
                else
                    Poskozeni(7, spravce.Hrac2);
            }
            else
            {
                if (spravce.Hrac1.Zed > 0)
                    Poskozeni(10, spravce.Hrac1);
                else
                    Poskozeni(7, spravce.Hrac1);
            }
        }
        public static void Jednorozec(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                if (spravce.Hrac1.Magie > spravce.Hrac2.Magie)
                    Poskozeni(12, spravce.Hrac2);
                else
                    Poskozeni(8, spravce.Hrac2);
            }
            else
            {
                if (spravce.Hrac2.Magie > spravce.Hrac1.Magie)
                    Poskozeni(12, spravce.Hrac1);
                else
                    Poskozeni(8, spravce.Hrac1);
            }
        }
        public static void ElfiLukostrelci(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                if (spravce.Hrac1.Zed > spravce.Hrac2.Zed)
                {
                    spravce.Hrac2.Vez -= 6;
                    if (spravce.Hrac2.Vez < 0)
                        spravce.Hrac2.Vez = 0;
                }
                else
                    Poskozeni(6, spravce.Hrac2);
            }
            else
            {
                if (spravce.Hrac2.Zed > spravce.Hrac1.Zed)
                {
                    spravce.Hrac1.Vez -= 6;
                    if (spravce.Hrac1.Vez < 0)
                        spravce.Hrac1.Vez = 0;
                }
                else
                    Poskozeni(6, spravce.Hrac1);
            }
        }
        public static void Sukuba(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac2.Vez -= 5;
                if (spravce.Hrac2.Vez < 0)
                    spravce.Hrac2.Vez = 0;
                spravce.Hrac2.Prisery -= 8;
                if (spravce.Hrac2.Prisery < 0)
                    spravce.Hrac2.Prisery = 0;
            }
            else
            {
                spravce.Hrac1.Vez -= 5;
                if (spravce.Hrac1.Vez < 0)
                    spravce.Hrac1.Vez = 0;
                spravce.Hrac1.Prisery -= 8;
                if (spravce.Hrac1.Prisery < 0)
                    spravce.Hrac1.Prisery = 0;
            }
        }
        public static void KamenniBojovnici(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(8, spravce.Hrac2);
                spravce.Hrac2.Tezba -= 1;
                if (spravce.Hrac2.Tezba < 1)
                    spravce.Hrac2.Tezba = 1;
            }
            else
            {
                Poskozeni(8, spravce.Hrac1);
                spravce.Hrac1.Tezba -= 1;
                if (spravce.Hrac1.Tezba < 1)
                    spravce.Hrac1.Tezba = 1;
            }
        }
        public static void Zlodej(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac2.Drahokamy -= 10;
                if (spravce.Hrac2.Drahokamy < 0)
                    spravce.Hrac2.Drahokamy = 0;
                spravce.Hrac2.Cihly-= 5;
                if (spravce.Hrac2.Cihly < 0)
                    spravce.Hrac2.Cihly = 0;
                spravce.Hrac1.Drahokamy += 5;
                spravce.Hrac1.Cihly += 2;
            }
            else
            {
                spravce.Hrac1.Drahokamy -= 10;
                if (spravce.Hrac1.Drahokamy < 0)
                    spravce.Hrac1.Drahokamy = 0;
                spravce.Hrac1.Cihly -= 5;
                if (spravce.Hrac1.Cihly < 0)
                    spravce.Hrac1.Cihly = 0;
                spravce.Hrac2.Drahokamy += 5;
                spravce.Hrac2.Cihly += 2;
            }
        }
        public static void KamenyObr(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(10, spravce.Hrac2);
                spravce.Hrac1.Zed += 4;
            }
            else
            {
                Poskozeni(10, spravce.Hrac1);
                spravce.Hrac2.Zed += 4;
            }
        }
        public static void Upir(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(10, spravce.Hrac2);
                spravce.Hrac2.Prisery -= 5;
                if (spravce.Hrac2.Prisery < 0)
                    spravce.Hrac2.Prisery = 0;
                spravce.Hrac2.Jeskyne -= 1;
                if (spravce.Hrac2.Jeskyne < 1)
                    spravce.Hrac2.Jeskyne = 1;
            }
            else
            {
                Poskozeni(10, spravce.Hrac1);
                spravce.Hrac1.Prisery -= 5;
                if (spravce.Hrac1.Prisery < 0)
                    spravce.Hrac1.Prisery = 0;
                spravce.Hrac1.Jeskyne -= 1;
                if (spravce.Hrac1.Jeskyne < 1)
                    spravce.Hrac1.Jeskyne = 1;
            }
        }
        public static void Drak(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(20, spravce.Hrac2);
                spravce.Hrac2.Drahokamy -= 10;
                if (spravce.Hrac2.Drahokamy < 0)
                    spravce.Hrac2.Drahokamy = 0;
                spravce.Hrac2.Jeskyne -= 1;
                if (spravce.Hrac2.Jeskyne < 1)
                    spravce.Hrac2.Jeskyne = 1;
            }
            else
            {
                Poskozeni(20, spravce.Hrac1);
                spravce.Hrac1.Drahokamy -= 10;
                if (spravce.Hrac1.Drahokamy < 0)
                    spravce.Hrac1.Drahokamy = 0;
                spravce.Hrac1.Jeskyne -= 1;
                if (spravce.Hrac1.Jeskyne < 1)
                    spravce.Hrac1.Jeskyne = 1;
            }
        }
        public static void Kopinik(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                if (spravce.Hrac1.Zed > spravce.Hrac2.Zed)
                {
                    Poskozeni(3, spravce.Hrac2);
                }
                else
                    Poskozeni(2, spravce.Hrac2);
            }
            else
            {
                if (spravce.Hrac2.Zed > spravce.Hrac1.Zed)
                {
                    Poskozeni(3, spravce.Hrac1);
                }
                else
                    Poskozeni(2, spravce.Hrac1);
            }
        }
        public static void Gnom(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(3, spravce.Hrac2);
                spravce.Hrac1.Drahokamy += 1;
            }
            else
            {
                Poskozeni(3, spravce.Hrac1);
                spravce.Hrac2.Drahokamy += 1;
            }
        }
        public static void Berserkr(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(8, spravce.Hrac2);
                spravce.Hrac1.Vez -= 3;
                if (spravce.Hrac1.Vez < 0)
                    spravce.Hrac1.Vez = 0;
            }
            else
            {
                Poskozeni(8, spravce.Hrac1);
                spravce.Hrac2.Vez -= 3;
                if (spravce.Hrac2.Vez < 0)
                    spravce.Hrac2.Vez = 0;
            }
        }
        public static void Valecnik(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                Poskozeni(13, spravce.Hrac2);
                spravce.Hrac1.Drahokamy -= 3;
                if (spravce.Hrac1.Drahokamy < 0)
                    spravce.Hrac1.Drahokamy = 0;
            }
            else
            {
                Poskozeni(13, spravce.Hrac1);
                spravce.Hrac2.Drahokamy -= 3;
                if (spravce.Hrac2.Drahokamy < 0)
                    spravce.Hrac2.Drahokamy = 0;
            }
        }
        public static void PegasKopinik(SpravceHry spravce)
        {
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                spravce.Hrac2.Vez -= 12;
                if (spravce.Hrac2.Vez < 0)
                    spravce.Hrac2.Vez = 0;
            }
            else
            {
                spravce.Hrac1.Vez -= 12;
                if (spravce.Hrac1.Vez < 0)
                    spravce.Hrac1.Vez = 0;
            }
        }
    }
}
