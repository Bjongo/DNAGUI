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

namespace DNAFinderGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {


            DNAOut.Clear();
            foreach (char letter in RNA.Text.ToUpper())
            {

                switch (letter)
                {
                    default:
                        DNAOut.Text = "contains a non-nitrogen containing base \n";
                        break;
                    case 'A':
                        DNAOut.Text += letter + "T \n";
                        break;
                    case 'T':
                        DNAOut.Text += letter + "A \n";
                        break;
                    case 'C':
                        DNAOut.Text += letter + "G \n";
                        break;
                    case 'G':
                        DNAOut.Text += letter + "C \n";
                        break;
                }
            }
        }
    }
}
