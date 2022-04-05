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
using ATV01.Janelas;

namespace ATV01
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btEnter_Click(object sender, RoutedEventArgs e)
        {
            string ususario = txtLogin.Text;
            string senha = passBoxSenha.Password.ToString();

            if (ususario == "mariazinha" && senha == "1503")
            {
                MessageBox.Show("Login realizado com sucesso!");
                PrincipalWindow principal = new PrincipalWindow();
                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha ou Usuário Incorretos! ", "Aviso", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btCadastrar_Click(object sender, RoutedEventArgs e)
        { 
            cadastro principal = new cadastro();
            principal.ShowDialog();
        }
    }
}
