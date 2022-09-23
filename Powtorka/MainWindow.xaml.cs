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

namespace Powtorka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool czyPani = true;
        public char pierwszaCyfra; 
        public MainWindow()
        {
            InitializeComponent();
            pierwszaCyfra = '0';
        }

        private void witaj(object sender, RoutedEventArgs e)
        {
            string i = imie.Text;
            string n = nazwisko.Text;
            if(sprawdzDate() == false)
            {
                MessageBox.Show("Poprawnie wpisz date");
            }
            int rokWpisany = int.Parse(rok.Text);
            char pierwszaCyfra = rok.Text[0];
            P1.Text = pierwszaCyfra.ToString();
            if(k.IsChecked == true)
            {
                MessageBox.Show("Witaj Pani " + i + " " + n);
            }else
            if(m.IsChecked == true)
            {
                MessageBox.Show("Witaj Panie " + i + " " + n);
            }
        }

        private bool sprawdzDate()
        {
            if(rok.Text == ""){
                return false;
            }
            if(miesiac.Text == ""){
                return false;
            }
            if (dzien.Text == ""){
                return false;
            }if(rok.Text.Length != 4){
                return false;
            }
            if(Int32.Parse(rok.Text) < 1922 || Int32.Parse(rok.Text) > 2022){
                return false;
            }
            if (miesiac.Text.Length > 2){
                return false;
            }
            if (Int32.Parse(miesiac.Text) < 1 || Int32.Parse(miesiac.Text) > 12){
                return false;
            }
            if (dzien.Text.Length > 2){
                return false;
            }
            if (Int32.Parse(dzien.Text) < 1 || Int32.Parse(dzien.Text) > 31){
                return false;
            }
            return true;
        }

        private bool sprawdzImie(string imie)
        {
            if(imie == "Kuba")
            {
                return true;
            }
            if (imie[imie.Length-1] == 'a')
            {
                return false;
            }
            if(imie == "Ines" || imie == "Dolores" || imie == "Inez")
            {
                return false;
            }
            return true;
        }

        private void czKobieta(object sender, RoutedEventArgs e)
        {
            if(imie.Text != "")
            if(sprawdzImie(imie.Text))
            {
                MessageBox.Show("Sprawdź czy poprawnie wpisałaś imię");
                var radio = sender as RadioButton;
                radio.IsChecked = false;
            }
        }

        private void czMeszczyzna(object sender, RoutedEventArgs e)
        {
            if(imie.Text != "")
            if(!sprawdzImie(imie.Text))
            {
                MessageBox.Show("Sprawdź czy poprawnie wpisałeś imię");
                var radio = sender as RadioButton;
                radio.IsChecked = false;
            }
        }
    }
}
