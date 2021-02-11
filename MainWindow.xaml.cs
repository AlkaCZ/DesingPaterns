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

        public void LogOut(TextBox name,TextBox surname,TextBox dayOfBirth, TextBox bcn, Person person, TextBlock LOG)
            {
            bool OkName = true;
            bool OkSurame = true;
            bool OkDate = true;
            bool OkBcn = true;

            if (name.Text != null | name.Text == "YourName")
            {
                person.Name = name.Text;
            }
            else
            {
                MessageBox.Show("Name format is wrong", "Format Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (surname.Text != null | surname.Text == "YourSurname")
            {
                person.Surname = surname.Text;
            }
            else
            {
                MessageBox.Show("Surname format is wrong", "Format Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (dayOfBirth.Text != null | dayOfBirth.Text == "day.month.year")
            {
                person.DayOfBirth = dayOfBirth.Text;
            }
            else
            {
                MessageBox.Show("Day of birth format is wrong", "Format Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (bcn.Text != null | bcn.Text == "xxxxxx/xxx")
            {
                person.BCN = bcn.Text;
            }
            else
            {
                MessageBox.Show("BCN format is wrong", "Format Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (OkName = stringValidator.IsValid(person.Name))
            {
                LOG.Text += person.Name;
                LOG.Text += " ";
            }
            if (OkSurame = stringValidator.IsValid(person.Surname))
            {
                LOG.Text += person.Surname;
                LOG.Text += " ";
            }
            if (OkDate = dateValidator.IsValid(person.DayOfBirth))
            {
                LOG.Text += person.DayOfBirth;
                LOG.Text += " ";
            }
            if (OkBcn = bcnValidator.IsValid(person.BCN, person.DayOfBirth))
            {
                LOG.Text += person.BCN;
                LOG.Text += "-----------------------------------------------------------";
            }
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

            Person p = new Person(new NameValidator(), new SurnameValidator(), new DateValidator(), new BcnValidator());
            p.LogOut(tbName, tbSurname, tbBirthDay, tbBCN, p, LOG);

         






        }
    }
}
