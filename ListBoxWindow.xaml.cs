using DataBinding.Data;
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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public List<Person> People = new List<Person>//From Class Person with Name Age Properties We Create a List
        {
            new Person{Name="Uesli",Age=20},//Assigned new Objects
            new Person{Name="Bruno",Age=13},
            new Person{Name="Ami",Age=5},
            new Person{Name="Eno",Age=10},
        };

        public Window1()
        {
            InitializeComponent();
            ListBoxContent.ItemsSource= People;//We Get The ListBox With Items To beDisplayed with People List We Created
        }

        private void SelectedClick(object sender ,RoutedEventArgs e)
        {
            var listBox=ListBoxContent.SelectedItems;

            foreach(var item in listBox)
            {
                var person=(Person)item;
                MessageBox.Show(person.Name);
            }
        }
    }
}
