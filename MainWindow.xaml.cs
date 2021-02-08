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

namespace DesingPaterns
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    class Person
    {
        //Validators
        //
        //
        //
        public DateTime DayOfBirth { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BCN { get; set; }

        // Kod pro použití validátorů
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnValidate_Click(object sender, RoutedEventArgs e)
        {
            // Metoda pro spuštění validace + vypsání do Log text blocku
        }
    }
}
