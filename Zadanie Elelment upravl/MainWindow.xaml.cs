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

namespace Zadanie_Elelment_upravl
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double fontSize =Convert.ToDouble( ((sender as ComboBox).SelectedItem as TextBlock).Text);
            if (textBox != null)
            {
                textBox.FontSize = fontSize;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string weight = "Bold";
            FontWeight fw = (FontWeight)new FontWeightConverter().ConvertFromString(weight);
            textBox.FontWeight = fw;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string style = "Italic";
            FontStyle fs = (FontStyle)new FontStyleConverter().ConvertFromString(style);
            textBox.FontStyle = fs;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextDecorationCollection tcd = new TextDecorationCollection(1);
            tcd.Add(TextDecorations.Underline);
            textBox.TextDecorations = tcd;  
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                Brush bl = (Brush)new BrushConverter().ConvertFromString("Black");
                textBox.Foreground = bl;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                Brush rd = (Brush)new BrushConverter().ConvertFromString("Red");
                textBox.Foreground = rd;
            }
        }
    }
}
