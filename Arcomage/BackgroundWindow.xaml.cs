using System;
using System.Collections.Generic;
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
    /// Interakční logika pro BackgroundWindow.xaml
    /// </summary>
    public partial class BackgroundWindow : Window
    {
        private SpravceHry spravce;
        private HerniObrazovka herniObrazovka;
        private Pozadi pozadi;
        public BackgroundWindow(HerniObrazovka herniObrazovka, SpravceHry spravce)
        {
            InitializeComponent();
            this.herniObrazovka = herniObrazovka;
            this.spravce = spravce;            
            listBox_Backgrounds.ItemsSource = spravce.backgroundList.pozadiList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (listBox_Backgrounds.SelectedItem != null)
            {
                pozadi = (Pozadi)listBox_Backgrounds.SelectedItem;
                herniObrazovka.Backgrounds = pozadi.Picture;
            }
            Close();
        }
    }
}
