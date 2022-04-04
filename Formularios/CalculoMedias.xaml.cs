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
    /// Lógica interna para CalculoMedias.xaml
    /// </summary>
    public partial class CalculoMedias : Window
    {
        public CalculoMedias()
        {
            InitializeComponent();
        }

        private void bt_fechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void bt_calcular_Click(object sender, RoutedEventArgs e)
        {
            if (txt_nome.Text == "")
            {
                MessageBox.Show("Falta preencher alguns campos");
            }
            else
            {
                if (txt_nota1.Text == "")
                {
                    MessageBox.Show("Falta preencher alguns campos");
                }
                else
                {
                    if (txt_nota2.Text == "")
                    {
                        MessageBox.Show("Falta preencher alguns campos");
                    }
                    else
                    {
                        if (txt_nota3.Text == "")
                        {
                            MessageBox.Show("Falta preencher alguns campos");
                        }
                        else
                        {
                            if (txt_nota4.Text == "")
                            {
                                MessageBox.Show("Falta preencher alguns campos");
                            }
                            else
                            {
                                float nota1 = Convert.ToSingle(txt_nota1.Text);
                                float nota2 = Convert.ToSingle(txt_nota2.Text);
                                float nota3 = Convert.ToSingle(txt_nota3.Text);
                                float nota4 = Convert.ToSingle(txt_nota4.Text);

                                float media = (nota1 + nota2 + nota3 + nota4) / 4;
                                txt_media.Text = Convert.ToString(media);
                                txt_nome.Clear();
                                txt_nota1.Clear();
                                txt_nota2.Clear();
                                txt_nota3.Clear();
                                txt_nota4.Clear();
                                if (media < 60)
                                    txt_situacao.Text = "Reprovado";
                                else
                                    txt_situacao.Text = "Aprovado";
                            }
                        }
                    }
                }
            }
        }
    }
}
