using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Aula_01.Formularios
{
    /// <summary>
    /// Lógica interna para Atividade.xaml
    /// </summary>
    public partial class Atividade : Window
    {
        public Atividade()
        {
            InitializeComponent();
        }

        private void bt_fechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void bt_importante_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cadastro meramente ilustrativo, apenas para demosntrar o grid");
        }
    }
}
