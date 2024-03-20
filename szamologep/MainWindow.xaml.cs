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

namespace szamologep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double temp = 0;

        string operation = "";

        string output = "";
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;


            switch (name)
            {
                case "OneBtn":
                    output += 1;
                    OutputText.Content = output;
                    break;
                case "TwoBtn":
                    output += 2;
                    OutputText.Content = output;
                    break;

                case "ThreeBtn":
                    output += 3;
                    OutputText.Content = output;
                    break;

                case "FourBtn":
                    output += 4;
                    OutputText.Content = output;
                    break;

                case "FiveBtn":
                    output += 5;
                    OutputText.Content = output;
                    break;

                case "SixBtn":
                    output += 6;
                    OutputText.Content = output;
                    break;

                case "SevenBtn":
                    output += 7;
                    OutputText.Content = output;
                    break;

                case "EightBtn":
                    output += 8;
                    OutputText.Content = output;
                    break;

                case "NineBtn":
                    output += 9;
                    OutputText.Content = output;
                    break;

                case "ZeroBtn":
                    output += 0;
                    OutputText.Content = output;
                    break;
            }
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";
                operation = "Minus";
            }
        }

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "Minus":
                    double outputTemp = temp - double.Parse(output);
                    OutputText.Content = output;
                    break;
            }
        }
    }
}