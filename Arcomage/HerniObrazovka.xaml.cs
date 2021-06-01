using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Arcomage
{
    /// <summary>
    /// Interakční logika pro HerniObrazovka.xaml
    /// </summary>
    public partial class HerniObrazovka : Window, INotifyPropertyChanged
    {
        private SpravceHry spravce;
        private string karta1;
        public string Karta1
        {
            get => karta1;
            set
            {
                karta1 = value;
                OnPropertyChanged(nameof(Karta1));
            }
        }
        private string karta2;
        public string Karta2
        {
            get => karta2;
            set
            {
                karta2 = value;
                OnPropertyChanged(nameof(Karta2));
            }
        }
        private string karta3;
        public string Karta3
        {
            get => karta3;
            set
            {
                karta3 = value;
                OnPropertyChanged(nameof(Karta3));
            }
        }
        private string karta4;
        public string Karta4
        {
            get => karta4;
            set
            {
                karta4 = value;
                OnPropertyChanged(nameof(Karta4));
            }
        }
        private string karta5;
        public string Karta5
        {
            get => karta5;
            set
            {
                karta5 = value;
                OnPropertyChanged(nameof(Karta5));
            }
        }
        private Thickness margin;
        private string backgrounds;
        public string Backgrounds
        {
            get => backgrounds;
            set
            {
                backgrounds = value;
                OnPropertyChanged(nameof(Backgrounds));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public HerniObrazovka(SpravceHry spravce)
        {
            InitializeComponent();
            this.spravce = spravce;
            spravce.Vitezstvi += Vitezstvi;
            spravce.AktualizujAI += Aktualizuj;
            gridHrac1.DataContext = spravce.Hrac1;
            gridHrac2.DataContext = spravce.Hrac2;
            gridVezHrac1.DataContext = spravce.Hrac1;
            gridVezHrac2.DataContext = spravce.Hrac2;
            gridCards.DataContext = this;
            gridMain.DataContext = this;
            textblock_jmenoHrace1.Text = spravce.Hrac1.Jmeno;
            textblock_jmenoHrace2.Text = spravce.Hrac2.Jmeno;
            Backgrounds = @"Pictures/background1.jpg";
            Aktualizuj();
        }
        public void Vitezstvi(SpravceHry spravce)
        {
            spravce.AI = false;
            VitezneOkno vitezneOkno = new VitezneOkno(spravce);
            Close();
            vitezneOkno.ShowDialog();
        }

        private void buttonCard1_Click(object sender, RoutedEventArgs e)
        {
            if (spravce.OdhazujeKartu)
            {                
                spravce.OdhodKartu(spravce.AktualniHrac.ruka[0], 0);
                Aktualizuj();
            }
            else
            {
                if (buttonCard1.Opacity == 1)
                {
                    spravce.PouzijKartu(spravce.AktualniHrac.ruka[0], 0);
                    Aktualizuj();
                }
            }
        }

        private void buttonCard1_RightClick(object sender, RoutedEventArgs e)
        {
            spravce.OdhodKartu(spravce.AktualniHrac.ruka[0], 0);
            Aktualizuj();
        }

        private void buttonCard2_Click(object sender, RoutedEventArgs e)
        {
            if (spravce.OdhazujeKartu)
            {
                spravce.OdhodKartu(spravce.AktualniHrac.ruka[1], 1);
                Aktualizuj();
            }
            else
            {
                if (buttonCard2.Opacity == 1)
                {
                    spravce.PouzijKartu(spravce.AktualniHrac.ruka[1], 1);
                    Aktualizuj();
                }
            }
        }

        private void buttonCard2_RightClick(object sender, RoutedEventArgs e)
        {
            spravce.OdhodKartu(spravce.AktualniHrac.ruka[1], 1);
            Aktualizuj();
        }

        private void buttonCard3_Click(object sender, RoutedEventArgs e)
        {
            if (spravce.OdhazujeKartu)
            {
                spravce.OdhodKartu(spravce.AktualniHrac.ruka[2], 2);
                Aktualizuj();
            }
            else
            {
                if (buttonCard3.Opacity == 1)
                {
                    spravce.PouzijKartu(spravce.AktualniHrac.ruka[2], 2);
                    Aktualizuj();
                }
            }
        }

        private void buttonCard3_RightClick(object sender, RoutedEventArgs e)
        {
            spravce.OdhodKartu(spravce.AktualniHrac.ruka[2], 2);
            Aktualizuj();
        }

        private void buttonCard4_Click(object sender, RoutedEventArgs e)
        {
            if (spravce.OdhazujeKartu)
            {
                spravce.OdhodKartu(spravce.AktualniHrac.ruka[3], 3);
                Aktualizuj();
            }
            else
            {
                if (buttonCard4.Opacity == 1)
                {
                    spravce.PouzijKartu(spravce.AktualniHrac.ruka[3], 3);
                    Aktualizuj();
                }
            }
        }

        private void buttonCard4_RightClick(object sender, RoutedEventArgs e)
        {
            spravce.OdhodKartu(spravce.AktualniHrac.ruka[3], 3);
            Aktualizuj();
        }

        private void buttonCard5_Click(object sender, RoutedEventArgs e)
        {
            if (spravce.OdhazujeKartu)
            {
                spravce.OdhodKartu(spravce.AktualniHrac.ruka[4], 4);
                Aktualizuj();
            }
            else
            {
                if (buttonCard5.Opacity == 1)
                {
                    spravce.PouzijKartu(spravce.AktualniHrac.ruka[4], 4);
                    Aktualizuj();
                }
            }
        }

        private void buttonCard5_RightClick(object sender, RoutedEventArgs e)
        {
            spravce.OdhodKartu(spravce.AktualniHrac.ruka[4], 4);
            Aktualizuj();
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Aktualizuj()
        {
            //Mění karty
            Karta1 = spravce.AktualniHrac.ruka[0].Picture;
            if (spravce.Dostatek(spravce.AktualniHrac.ruka[0]))
                buttonCard1.Opacity = 1;
            else
                buttonCard1.Opacity = 0.5;
            Karta2 = spravce.AktualniHrac.ruka[1].Picture;
            if (spravce.Dostatek(spravce.AktualniHrac.ruka[1]))
                buttonCard2.Opacity = 1;
            else
                buttonCard2.Opacity = 0.5;
            Karta3 = spravce.AktualniHrac.ruka[2].Picture;
            if (spravce.Dostatek(spravce.AktualniHrac.ruka[2]))
                buttonCard3.Opacity = 1;
            else
                buttonCard3.Opacity = 0.5;
            Karta4 = spravce.AktualniHrac.ruka[3].Picture;
            if (spravce.Dostatek(spravce.AktualniHrac.ruka[3]))
                buttonCard4.Opacity = 1;
            else
                buttonCard4.Opacity = 0.5;
            Karta5 = spravce.AktualniHrac.ruka[4].Picture;
            if (spravce.Dostatek(spravce.AktualniHrac.ruka[4]))
                buttonCard5.Opacity = 1;
            else
                buttonCard5.Opacity = 0.5;
            //Zvýrazňuje aktivního hráče
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                textblock_jmenoHrace1.Foreground = Brushes.DarkRed;
                textblock_jmenoHrace2.Foreground = Brushes.Gold;
            }
            else
            {
                textblock_jmenoHrace2.Foreground = Brushes.DarkRed;
                textblock_jmenoHrace1.Foreground = Brushes.Gold;
            }
            //Zobrazuje výšku věže a zdi
            ZobrazVez1((double)spravce.Hrac1.Vez / spravce.VitezstviVez * 100);
            ZobrazVez2((double)spravce.Hrac2.Vez / spravce.VitezstviVez * 100);
            ZobrazZed1((double)spravce.Hrac1.Zed / spravce.VitezstviVez * 100);
            ZobrazZed2((double)spravce.Hrac2.Zed / spravce.VitezstviVez * 100);
            //Vypíše nutnost odhodit kartu
            if (spravce.OdhazujeKartu)
            {
                textBlock_Info.FontSize = 40;
                textBlock_Info.Text = "Vyber kartu k odhození!";
                textBlock_Info.Visibility = Visibility.Visible;                
            }
            else
                textBlock_Info.Visibility = Visibility.Hidden;
            if (spravce.AI && !spravce.OdhazujeKartu)
            {
                textBlock_Info.FontSize = 25;
                textBlock_Info.Text = string.Format("{0} ", spravce.Hrac2.Jmeno) + spravce.AIReport;
                textBlock_Info.Visibility = Visibility.Visible;
            }
        }

        public void ZobrazVez1(double vez)
        {
            if (vez > 0)
                vezHrac1_1.Visibility = Visibility.Visible;
            else
                vezHrac1_1.Visibility = Visibility.Hidden;
            if (vez > 7)
                vezHrac1_2.Visibility = Visibility.Visible;
            else
                vezHrac1_2.Visibility = Visibility.Hidden;
            if (vez > 14)
                vezHrac1_3.Visibility = Visibility.Visible;
            else
                vezHrac1_3.Visibility = Visibility.Hidden;
            if (vez > 21)
                vezHrac1_4.Visibility = Visibility.Visible;
            else
                vezHrac1_4.Visibility = Visibility.Hidden;
            if (vez > 28)
                vezHrac1_5.Visibility = Visibility.Visible;
            else
                vezHrac1_5.Visibility = Visibility.Hidden;
            if (vez > 35)
                vezHrac1_6.Visibility = Visibility.Visible;
            else
                vezHrac1_6.Visibility = Visibility.Hidden;
            if (vez > 42)
                vezHrac1_7.Visibility = Visibility.Visible;
            else
                vezHrac1_7.Visibility = Visibility.Hidden;
            if (vez > 49)
                vezHrac1_8.Visibility = Visibility.Visible;
            else
                vezHrac1_8.Visibility = Visibility.Hidden;
            if (vez > 56)
                vezHrac1_9.Visibility = Visibility.Visible;
            else
                vezHrac1_9.Visibility = Visibility.Hidden;
            if (vez > 63)
                vezHrac1_10.Visibility = Visibility.Visible;
            else
                vezHrac1_10.Visibility = Visibility.Hidden;
            if (vez > 70)
                vezHrac1_11.Visibility = Visibility.Visible;
            else
                vezHrac1_11.Visibility = Visibility.Hidden;
            if (vez > 77)
                vezHrac1_12.Visibility = Visibility.Visible;
            else
                vezHrac1_12.Visibility = Visibility.Hidden;
            if (vez > 84)
                vezHrac1_13.Visibility = Visibility.Visible;
            else
                vezHrac1_13.Visibility = Visibility.Hidden;
            if (vez > 91)
                vezHrac1_14.Visibility = Visibility.Visible;
            else
                vezHrac1_14.Visibility = Visibility.Hidden;
            if (vez > 98)
                vezHrac1_15.Visibility = Visibility.Visible;
            else
                vezHrac1_15.Visibility = Visibility.Hidden;

            margin.Bottom = (int)vez / 7 * 20 + 60;
            margin.Left = 25;
            vezHrac1_strecha.Margin = margin;
        }
        public void ZobrazVez2(double vez)
        {
            if (vez > 0)
                vezHrac2_1.Visibility = Visibility.Visible;
            else
                vezHrac2_1.Visibility = Visibility.Hidden;
            if (vez > 7)
                vezHrac2_2.Visibility = Visibility.Visible;
            else
                vezHrac2_2.Visibility = Visibility.Hidden;
            if (vez > 14)
                vezHrac2_3.Visibility = Visibility.Visible;
            else
                vezHrac2_3.Visibility = Visibility.Hidden;
            if (vez > 21)
                vezHrac2_4.Visibility = Visibility.Visible;
            else
                vezHrac2_4.Visibility = Visibility.Hidden;
            if (vez > 28)
                vezHrac2_5.Visibility = Visibility.Visible;
            else
                vezHrac2_5.Visibility = Visibility.Hidden;
            if (vez > 35)
                vezHrac2_6.Visibility = Visibility.Visible;
            else
                vezHrac2_6.Visibility = Visibility.Hidden;
            if (vez > 42)
                vezHrac2_7.Visibility = Visibility.Visible;
            else
                vezHrac2_7.Visibility = Visibility.Hidden;
            if (vez > 49)
                vezHrac2_8.Visibility = Visibility.Visible;
            else
                vezHrac2_8.Visibility = Visibility.Hidden;
            if (vez > 56)
                vezHrac2_9.Visibility = Visibility.Visible;
            else
                vezHrac2_9.Visibility = Visibility.Hidden;
            if (vez > 63)
                vezHrac2_10.Visibility = Visibility.Visible;
            else
                vezHrac2_10.Visibility = Visibility.Hidden;
            if (vez > 70)
                vezHrac2_11.Visibility = Visibility.Visible;
            else
                vezHrac2_11.Visibility = Visibility.Hidden;
            if (vez > 77)
                vezHrac2_12.Visibility = Visibility.Visible;
            else
                vezHrac2_12.Visibility = Visibility.Hidden;
            if (vez > 84)
                vezHrac2_13.Visibility = Visibility.Visible;
            else
                vezHrac2_13.Visibility = Visibility.Hidden;
            if (vez > 91)
                vezHrac2_14.Visibility = Visibility.Visible;
            else
                vezHrac2_14.Visibility = Visibility.Hidden;
            if (vez > 98)
                vezHrac2_15.Visibility = Visibility.Visible;
            else
                vezHrac2_15.Visibility = Visibility.Hidden;

            margin.Bottom = (int)vez / 7 * 20 + 60;
            margin.Right = 25;
            vezHrac2_strecha.Margin = margin;            
        }

        public void ZobrazZed1(double zed)
        {
            if (zed > 0)
                zedHrac1_1.Visibility = Visibility.Visible;
            else
                zedHrac1_1.Visibility = Visibility.Hidden;
            if (zed > 7)
                zedHrac1_2.Visibility = Visibility.Visible;
            else
                zedHrac1_2.Visibility = Visibility.Hidden;
            if (zed > 14)
                zedHrac1_3.Visibility = Visibility.Visible;
            else
                zedHrac1_3.Visibility = Visibility.Hidden;
            if (zed > 21)
                zedHrac1_4.Visibility = Visibility.Visible;
            else
                zedHrac1_4.Visibility = Visibility.Hidden;
            if (zed > 28)
                zedHrac1_5.Visibility = Visibility.Visible;
            else
                zedHrac1_5.Visibility = Visibility.Hidden;
            if (zed > 35)
                zedHrac1_6.Visibility = Visibility.Visible;
            else
                zedHrac1_6.Visibility = Visibility.Hidden;
            if (zed > 42)
                zedHrac1_7.Visibility = Visibility.Visible;
            else
                zedHrac1_7.Visibility = Visibility.Hidden;
            if (zed > 49)
                zedHrac1_8.Visibility = Visibility.Visible;
            else
                zedHrac1_8.Visibility = Visibility.Hidden;
            if (zed > 56)
                zedHrac1_9.Visibility = Visibility.Visible;
            else
                zedHrac1_9.Visibility = Visibility.Hidden;
            if (zed > 63)
                zedHrac1_10.Visibility = Visibility.Visible;
            else
                zedHrac1_10.Visibility = Visibility.Hidden;
            if (zed > 70)
                zedHrac1_11.Visibility = Visibility.Visible;
            else
                zedHrac1_11.Visibility = Visibility.Hidden;
            if (zed > 77)
                zedHrac1_12.Visibility = Visibility.Visible;
            else
                zedHrac1_12.Visibility = Visibility.Hidden;
            if (zed > 84)
                zedHrac1_13.Visibility = Visibility.Visible;
            else
                zedHrac1_13.Visibility = Visibility.Hidden;
            if (zed > 91)
                zedHrac1_14.Visibility = Visibility.Visible;
            else
                zedHrac1_14.Visibility = Visibility.Hidden;
            if (zed > 98)
                zedHrac1_15.Visibility = Visibility.Visible;
            else
                zedHrac1_15.Visibility = Visibility.Hidden;
        }

        public void ZobrazZed2(double zed)
        {
            if (zed > 0)
                zedHrac2_1.Visibility = Visibility.Visible;
            else
                zedHrac2_1.Visibility = Visibility.Hidden;
            if (zed > 7)
                zedHrac2_2.Visibility = Visibility.Visible;
            else
                zedHrac2_2.Visibility = Visibility.Hidden;
            if (zed > 14)
                zedHrac2_3.Visibility = Visibility.Visible;
            else
                zedHrac2_3.Visibility = Visibility.Hidden;
            if (zed > 21)
                zedHrac2_4.Visibility = Visibility.Visible;
            else
                zedHrac2_4.Visibility = Visibility.Hidden;
            if (zed > 28)
                zedHrac2_5.Visibility = Visibility.Visible;
            else
                zedHrac2_5.Visibility = Visibility.Hidden;
            if (zed > 35)
                zedHrac2_6.Visibility = Visibility.Visible;
            else
                zedHrac2_6.Visibility = Visibility.Hidden;
            if (zed > 42)
                zedHrac2_7.Visibility = Visibility.Visible;
            else
                zedHrac2_7.Visibility = Visibility.Hidden;
            if (zed > 49)
                zedHrac2_8.Visibility = Visibility.Visible;
            else
                zedHrac2_8.Visibility = Visibility.Hidden;
            if (zed > 56)
                zedHrac2_9.Visibility = Visibility.Visible;
            else
                zedHrac2_9.Visibility = Visibility.Hidden;
            if (zed > 63)
                zedHrac2_10.Visibility = Visibility.Visible;
            else
                zedHrac2_10.Visibility = Visibility.Hidden;
            if (zed > 70)
                zedHrac2_11.Visibility = Visibility.Visible;
            else
                zedHrac2_11.Visibility = Visibility.Hidden;
            if (zed > 77)
                zedHrac2_12.Visibility = Visibility.Visible;
            else
                zedHrac2_12.Visibility = Visibility.Hidden;
            if (zed > 84)
                zedHrac2_13.Visibility = Visibility.Visible;
            else
                zedHrac2_13.Visibility = Visibility.Hidden;
            if (zed > 91)
                zedHrac2_14.Visibility = Visibility.Visible;
            else
                zedHrac2_14.Visibility = Visibility.Hidden;
            if (zed > 98)
                zedHrac2_15.Visibility = Visibility.Visible;
            else
                zedHrac2_15.Visibility = Visibility.Hidden;
        }

        private void buttonBackground_Click(object sender, RoutedEventArgs e)
        {
            BackgroundWindow  backgroundWindow = new BackgroundWindow(this, spravce);            
            backgroundWindow.ShowDialog();
        }
    }
}
