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

namespace Ejercicio5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            azulRadioButton.IsChecked = true;
        }

        private void azulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.Foreground = Brushes.Blue;
        }

        private void rojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.Foreground = Brushes.Red;
        }

        private void verdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.Foreground = Brushes.Green;
        }

        private void cursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.FontStyle=FontStyles.Italic;
        }

        private void cursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.FontStyle = FontStyles.Normal;
        }

        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.FontWeight = FontWeights.Bold;
        }

        private void negritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.FontWeight = FontWeights.Normal;
        }

        private void textoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoTextBlock.Text = textoTextBox.Text.ToString();
        }
    }
}
