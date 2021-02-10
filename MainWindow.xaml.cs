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
using DesingPaterns.Validators;
using DesingPaterns.Interfaces;

namespace DesingPaterns
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    class Person
    {
        //Validators
        readonly IStringValidator stringValidator;
        readonly IDateValidator dateValidator;
        readonly IBCNValidator bcnValidator;

        public string DayOfBirth { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BCN { get; set; }

        // Kod pro použití validátorů

        public Person(IStringValidator sv, IStringValidator ssv, IDateValidator dv, IBCNValidator bv)
        {
            stringValidator = sv;
            stringValidator = ssv;
            dateValidator = dv;
            bcnValidator = bv;
        }

        public Person()
        {
            stringValidator = null;
            dateValidator = null;
            bcnValidator = null;
        }
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
