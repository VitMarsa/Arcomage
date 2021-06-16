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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Arcomage
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int startVez;
        private int startZed;
        private int startTezba;
        private int startMagie;
        private int startJeskyne;
        private int startCihly;
        private int startDrahokamy;
        private int startPrisery;
        private int viteznaVez;
        private int vitezneSuroviny;
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void button_Play_Click(object sender, RoutedEventArgs e)
        {
            bool spravneZadano = true;
            if ((!int.TryParse(textBox_StartovniVez.Text, out startVez)) || (startVez <= 0))
            { 
                MessageBox.Show("Chybně zadaná velikost počáteční věže!", "Chyba!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                spravneZadano = false;
            }
            if ((!int.TryParse(textBox_StartovniZed.Text, out startZed)) || (startZed <= 0))
            {
                MessageBox.Show("Chybně zadaná velikost počáteční zdi!", "Chyba!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                spravneZadano = false;
            }
            if ((!int.TryParse(textBox_StartovniTezba.Text, out startTezba)) || (startTezba < 1))
            {
                MessageBox.Show("Chybně zadaná velikost počáteční těžby!", "Chyba!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                spravneZadano = false;
            }
            if ((!int.TryParse(textBox_StartovniMagie.Text, out startMagie)) || (startMagie < 1))
            {
                MessageBox.Show("Chybně zadaná velikost počáteční magie!", "Chyba!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                spravneZadano = false;
            }
            if ((!int.TryParse(textBox_StartovniJeskyne.Text, out startJeskyne)) || (startJeskyne < 1))
            {
                MessageBox.Show("Chybně zadaná velikost počáteční jeskyně!", "Chyba!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                spravneZadano = false;
            }
            if ((!int.TryParse(textBox_StartovniCihly.Text, out startCihly)) || (startCihly < 0))
            {
                MessageBox.Show("Chybně zadaná velikost počátečních cihel!", "Chyba!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                spravneZadano = false;
            }
            if ((!int.TryParse(textBox_StartovniDrahokamy.Text, out startDrahokamy)) || (startDrahokamy < 0))
            {
                MessageBox.Show("Chybně zadaná velikost počátečních drahokamů!", "Chyba!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                spravneZadano = false;
            }
            if ((!int.TryParse(textBox_StartovniPrisery.Text, out startPrisery)) || (startPrisery < 0))
            {
                MessageBox.Show("Chybně zadaná velikost počátečních příšer!", "Chyba!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                spravneZadano = false;
            }
            if ((!int.TryParse(textBox_VitezstviVez.Text, out viteznaVez)) || (viteznaVez <= 0) || (viteznaVez <= startVez))
            {
                MessageBox.Show("Chybně zadaná velikost vítězné věže!", "Chyba!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                spravneZadano = false;
            }
            if ((!int.TryParse(textBox_VitezstviSuroviny.Text, out vitezneSuroviny)) || (vitezneSuroviny <= 0) || (vitezneSuroviny <= startCihly) || (vitezneSuroviny <= startDrahokamy) || (vitezneSuroviny <= startPrisery))
            {
                MessageBox.Show("Chybně zadaný vítězný počet surovin!", "Chyba!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                spravneZadano = false;
            }
            if (textBox_Hrac1Jmeno.Text.Length > 10)
            {
                MessageBox.Show("Zadané jméno hráče 1 je příliš dlouhé!", "Chyba!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                spravneZadano = false;
            }
            if (textBox_Hrac2Jmeno.Text.Length > 10)
            {
                MessageBox.Show("Zadané jméno hráče 2 je příliš dlouhé!", "Chyba!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                spravneZadano = false;
            }            
            if (spravneZadano)
            {
                HerniObrazovka herniObrazovka = new HerniObrazovka(new SpravceHry(textBox_Hrac1Jmeno.Text, textBox_Hrac2Jmeno.Text, startTezba, startMagie, startJeskyne, startCihly, startDrahokamy, startPrisery, startVez, startZed, viteznaVez, vitezneSuroviny, checkBox_AI.IsChecked.Value));
                Close();
                herniObrazovka.ShowDialog();
            }
        }
    }
}
