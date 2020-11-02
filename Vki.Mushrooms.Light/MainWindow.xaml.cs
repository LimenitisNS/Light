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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vki.Mushrooms.Light.Model.Observer;

namespace Vki.Mushrooms.Light
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Lamp lamp = new Lamp();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_TurnON(object sender, RoutedEventArgs e)
        {
            lamp.SwitchLight();
        }

        private void Button_Click_TurnOFF(object sender, RoutedEventArgs e)
        {
            lamp.SwitchLight();
        }
    }
}
