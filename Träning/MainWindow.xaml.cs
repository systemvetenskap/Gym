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

namespace Träning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            // Gym = vår klass
            // Klassen är också vår mall
            Gym gym;
            
            // skapar ett objekt av typen Gym
            gym= new Gym();

            gym.SetName("Eriks gymnastikförening");
            gym.Address = "Frösön";

            Person person = new GymOnly(120)
            {
                Name = "Erik",
            };

            bool result;
            result = gym.AddMember(person);


            person = new TotalMember()
            {
                Name = "Stina"
            };

            result = gym.AddMember(person);

            person = new EliteMember()
            {
                Name = "Starke Elisabeth"
            };

            result = gym.AddMember(person);

            lstMembers.ItemsSource = gym.GetMembers();           

        }

        private void btnSelectMember_Click(object sender, RoutedEventArgs e)
        {
            Person person = lstMembers.SelectedItem as Person;
            if (person is GymOnly)
            {
                MessageBox.Show($"{person.Name} du får inte vara med på träningspasset");
            }
            
            
            double bmi = person.Bmi();

        }
    }
}
