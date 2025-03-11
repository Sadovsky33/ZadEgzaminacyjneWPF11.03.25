using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZadEgzaminacyjneWPF11._03._25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Kacper Sadecki
    /// zadegz
   
    public partial class MainWindow : Window
    {
        
       
        public MainWindow()
        {
            InitializeComponent();
            string male = "qwertyuiopasdfghjklzxcvbnm";
            string wielkie = "QWERTYUIOPASDFGHJKLZXCVBNM";
            int cyfry = 1234567890;
            string specjalne = "!@#$%^&*()_+-";

            for (int i = 0; i < male.Length; i++)
            {

            }
           
        }

        private void Imie_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Nazwisko_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Stanowisko_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void IleZnakow_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MaleWielkieLitery_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Cyfry_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ZnakiSpecjalne_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void GenerujBttn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ZatwierdzBttn_Click(object sender, RoutedEventArgs e)
        {
        
            MessageBox.Show(("Dane Pracownika:") + Imie.Text + (" ") + Nazwisko.Text + (" ") + Stanowisko.Text +(" ") + ("Hasło:"));
        }
    }
}