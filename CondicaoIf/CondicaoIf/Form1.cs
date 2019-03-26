using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondicaoIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerifica_Click(object sender, EventArgs e)
        {
            //Aula de Condição IF

            // Declarando a variavel

            int idade;
            idade = Convert.ToInt32(textVerificar.Text);
          

            //Declarando codigo condição IF

            if (idade < 18)
            {
                MessageBox.Show("Parabéns, Vocé ainda é menor de idade.", "Messagem");
            }
            else
            {
                MessageBox.Show("Parabéns, Vocé é maior de idade.","Messagem");
            }


        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            //Declarando codigo limpar

            textVerificar.Text = " ";

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            //Declarando o codigo fechar

            Close();

            //Fim do programa

        }
    }
}
