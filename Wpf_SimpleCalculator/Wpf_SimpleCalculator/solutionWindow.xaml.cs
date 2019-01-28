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

namespace Wpf_SimpleCalculator
{
    /// <summary>
    /// Interaction logic for solutionWindow.xaml
    /// </summary>
    public partial class solutionWindow : Window
    {
        public solutionWindow(double volume)
        {
            InitializeComponent();

            Label_Volume.Content = volume + "gallons";
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
