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
using Aula_01.Formularios;


namespace Aula_01
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

        private void bt_fechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void bt_logar_Click(object sender, RoutedEventArgs e)
        {
            if (txt_email.Text == "")
            {
                MessageBox.Show("Preencha os campos necessarios");
            }
            else
            {
                if(txt_senha.Text == "")
                {
                    MessageBox.Show("Preencha os campos necessarios");
                }
                else
                {
                    CalculoMedias cm = new CalculoMedias();
                    cm.ShowDialog();
                }
            }
        }

        private void bt_cadastrar_Click(object sender, RoutedEventArgs e)
        {
            Atividade atv = new Atividade();
            atv.ShowDialog();
        }
    }
}
