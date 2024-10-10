using DataBinding.Data;
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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        Person person = new Person()//From Person Class We assign 2 Properties
        {
            Name = "Uesli",
            Age = 20
        };
        public MainWindow()
        {

            this.DataContext = person;//DataContext gets the MainWindow Object inputs

            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"{person.Name} and {person.Age}");
            Window window = new Window1();//After Click Event is Triggered We Create A new Window
            window.Show();


        }
    }
}