using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace KartKupkaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Ksiazka> ksiazki { get; set; }
        public List<string> kategorie { get; set; } = new List<string> { "powieść", "opowiadanie", "kryminał", "fantasy", "thriller", "naukowa" };

        public MainWindow()
        {
            InitializeComponent();

            ksiazki = new ObservableCollection<Ksiazka>();
            katCombobox.ItemsSource = kategorie;

            ksiazki.Add(new Ksiazka("Potop", "Henryk Sienkiewicz", 1809, "powieść", true));
            ksiazki.Add(new Ksiazka("Lalka", "Bolesław Prus", 1799, "opowiadanie", false));
            ksiazki.Add(new Ksiazka("Sprawa Niny Frank", "Katarzyna Bonda", 2015, "kryminał", true));
            ksiazki.Add(new Ksiazka("Jaś Cośtamski", "Cokolwiek", 2020, "naukowa", false));

            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string tytul = tytulTextBox.Text;
            string autor = autorTextBox.Text;
            int rokWydania;

            

            if(int.TryParse(rokTextBox.Text, out rokWydania))
            {

            }
            else
            {
                rokWydania = 1234;
                MessageBox.Show("Rok wydania ma być liczbą. Ustawiono 1234.");
            }

            string kategoria = kategoriaComboBox.Text;
            bool czyAudioDostepny = czyDostepnyCheckBox.IsChecked == true ? true : false;

            ksiazki.Add(new Ksiazka(tytul, autor, rokWydania, kategoria, czyAudioDostepny));
        }
    }
}
