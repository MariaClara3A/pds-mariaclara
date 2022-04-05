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

namespace ATV01.Janelas
{
    /// <summary>
    /// Lógica interna para PrincipalWindow.xaml
    /// </summary>
    public partial class PrincipalWindow : Window
    {
        public PrincipalWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btCalculo_Click(object sender, RoutedEventArgs e)
        {
            int numX = int.Parse(txtNumX.Text);
            int numY = int.Parse(txtNumY.Text);
            int resultado = numX / numY;
            txtResultado.Text = resultado.ToString();
            
        }

        private void btFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
