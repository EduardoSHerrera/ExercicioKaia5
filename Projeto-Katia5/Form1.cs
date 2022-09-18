using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Katia5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Jogador jog;
        Jogador[] v = new Jogador[3];
        int i = 0;

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if(i < 3)
            {
                jog = new Jogador();
                jog.Nome = TxtNome.Text;
                jog.Peso = Convert.ToDouble(TxtPeso.Text);
                jog.Altura = Convert.ToDouble(TxtAltura.Text);
                jog.Idade = Convert.ToInt32(TxtIdade.Text);
                jog.Camisa = Convert.ToInt32(TxtCamisa.Text);
                jog.Time = TxtTime.Text;
                v[i] = jog;
                i++;
            }
            else
            {
                MessageBox.Show("Não é possivel gravar mais dados!");
            }

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            for(int j = 0; j < 3; j++)
            {
                if (v[j].Nome.Equals(TxtNome.Text))
                {
                    TxtNome.Text = v[j].Nome;
                    TxtPeso.Text = v[j].Peso.ToString();
                    TxtAltura.Text = v[j].Altura.ToString();
                    TxtIdade.Text = v[j].Idade.ToString();
                    TxtCamisa.Text = v[j].Camisa.ToString();
                    TxtTime.Text = v[j].Time;
                    j = 2;
                }
                else
                {
                    if (j == 2) MessageBox.Show("O jogador informado não foi encontrado!");
                }

            }
        }
    }
}
