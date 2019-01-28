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

namespace Wpf_SimpleCalculator
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

        private void InitializeWindowElementsGallons()
        {
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Calculate_Click(object sender, RoutedEventArgs e)
        {
            Double volume;
            String loss;
            double lossMultiplier = 1;
            bool validInputs = false;

            validateInputs();
            if (validateInputs())
            {
                volume = double.Parse(Gallons.Text) * double.Parse(lbs.Text) * double.Parse(boxes.Text);

                loss = Combobox_Loss.SelectionBoxItem as string;

                switch (loss)
                {
                    case "No loss":
                        lossMultiplier = 1;
                        break;
                    case "5% loss":
                        lossMultiplier = .95;
                        break;
                    case "10% loss":
                        lossMultiplier = .9;
                        break;
                    default:
                        break;
                }

                volume = volume * lossMultiplier;

                galPressed.Text = volume.ToString();

                solutionWindow solutionWin = new solutionWindow(volume);

                solutionWin.ShowDialog();
            }    
        }

        private bool validateInputs()
        {
            bool validInputs = true;

            if (
                !double.TryParse(Gallons.Text, out double gallons1) ||
                !double.TryParse(lbs.Text, out double lbs1) ||
                !double.TryParse(boxes.Text, out double boxes1)
                ) 
            {
                MessageBox.Show("Please enter numbers for each field.");
                validInputs = false;
            }

            return validInputs;
        }

        private void Button_Help_Click(object sender, RoutedEventArgs e)
        {
            Help helpWindow = new Help();

            helpWindow.ShowDialog();
        }

        private void RadioButton_Gallons_Checked(object sender, RoutedEventArgs e)
        {
            if (this.IsLoaded)
            {
                GallonsPer.Content = "Gallons per lb";
                pressGal.Content = "Gallons to be pressed";
                Gallons.Text = ".08";
            }
            
        }

        private void RadioButton_Liters_Checked(object sender, RoutedEventArgs e)
        {
            GallonsPer.Content = "Liters per lb";
            pressGal.Content = "Liters to be pressed";
            Gallons.Text = ".30";
        }
    }
}
