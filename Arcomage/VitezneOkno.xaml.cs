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
    /// Interakční logika pro VitezneOkno.xaml
    /// </summary>
    public partial class VitezneOkno : Window
    {
        public VitezneOkno(SpravceHry spravce)
        {
            InitializeComponent();
            textBlock_Hrac1.Text = spravce.Hrac1.Jmeno;
            textBlock_Hrac2.Text = spravce.Hrac2.Jmeno;
            if (spravce.AktualniHrac == spravce.Hrac1)
            {
                textBlock_Vitez_Hrac1.Text = "Vítěz";
                textBlock_Vitez_Hrac2.Text = "Poražen";
            }
            else
            {
                textBlock_Vitez_Hrac1.Text = "Poražen";
                textBlock_Vitez_Hrac2.Text = "Vítěz";
            }
            textBlock_ZpusobVitezstvi.Text = spravce.ZpusobVitezstvi;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
