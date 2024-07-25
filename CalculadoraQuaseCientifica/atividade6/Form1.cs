using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade6
{
    public partial class Form1 : Form
    {

        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,
            Potencia,
            Raiz,
            Regist
        }
        double valor1 = 0;
        double valor2 = 0;
        string RegistradorValor;
        List<string> Registrador = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            rtxtbDisplay.AppendText("1");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            rtxtbDisplay.AppendText("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            rtxtbDisplay.AppendText("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            rtxtbDisplay.AppendText("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            rtxtbDisplay.AppendText("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            rtxtbDisplay.AppendText("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            rtxtbDisplay.AppendText("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            rtxtbDisplay.AppendText("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            rtxtbDisplay.AppendText("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            rtxtbDisplay.AppendText("0");
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            rtxtbOperacao.Text = ("+");
            valor1 = double.Parse(rtxtbDisplay.Text);
            rtxtbDisplay.Text = ("");
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            rtxtbOperacao.Text = ("-");
            valor1 = double.Parse(rtxtbDisplay.Text);
            rtxtbDisplay.Text = ("");
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            rtxtbOperacao.Text = ("×");
            valor1 = double.Parse(rtxtbDisplay.Text);
            rtxtbDisplay.Text = ("");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            rtxtbOperacao.Text = ("÷");
            valor1 = double.Parse(rtxtbDisplay.Text);
            rtxtbDisplay.Text = ("");
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    valor2 = double.Parse(rtxtbDisplay.Text);
                    valor1 = valor1 + valor2;
                    rtxtbDisplay.Text = (valor1.ToString());
                    rtxtbOperacao.Text = ("");
                    break;
                case Operacao.Subtracao:
                    valor2 = double.Parse(rtxtbDisplay.Text);
                    valor1 = valor1 - valor2;
                    rtxtbDisplay.Text = (valor1.ToString());
                    rtxtbOperacao.Text = ("");
                    break;
                case Operacao.Multiplicacao:
                    valor2 = double.Parse(rtxtbDisplay.Text);
                    valor1 = valor1 * valor2;
                    rtxtbDisplay.Text = (valor1.ToString());
                    rtxtbOperacao.Text = ("");
                    break;
                case Operacao.Divisao:
                    valor2 = double.Parse(rtxtbDisplay.Text);
                    if (valor2 == 0)
                    {
                        MessageBox.Show("Não pode dividir por 0");
                    }
                    else
                    {
                        valor1 = valor1 / valor2;
                        rtxtbDisplay.Text = (valor1.ToString());
                        rtxtbOperacao.Text = ("");
                    }
                    break;
                case Operacao.Potencia:
                    valor2 = double.Parse(rtxtbDisplay.Text);
                    valor1 = Math.Pow(valor1, valor2);
                    rtxtbDisplay.Text = valor1.ToString();
                    rtxtbOperacao.Text = ("");
                    break;
                case Operacao.Raiz:
                    valor2 = double.Parse(rtxtbDisplay.Text);
                    valor1 = Math.Pow(valor1, 1 / valor2);
                    rtxtbDisplay.Text = valor1.ToString();
                    rtxtbOperacao.Text = ("");
                    break;
                case Operacao.Regist:
                    valor1 = double.Parse(rtxtbDisplay.Text);
                    int indice;
                    if (int.TryParse(valor1.ToString(), out indice) && indice >= 0 && indice < Registrador.Count)
                    {
                        rtxtbDisplay.Text = Registrador[indice];
                    }
                    else
                    {
                        MessageBox.Show("Índice inválido no registrador.");
                    }
                    break;
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            rtxtbDisplay.AppendText(",");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            rtxtbDisplay.Text = ("");
        }

        private void btnApagarCompleto_Click(object sender, EventArgs e)
        {
            rtxtbDisplay.Text = ("");
            rtxtbOperacao.Text = ("");
            valor1 = 0;
            valor2 = 0;
        }

        private void btnParenteses2_Click(object sender, EventArgs e)
        {
            rtxtbDisplay.AppendText("(");
        }

        private void btnParenteses1_Click(object sender, EventArgs e)
        {
            rtxtbDisplay.AppendText(")");
        }

        private void btnRaizQDR_Click(object sender, EventArgs e)
        {
            rtxtbOperacao.Text = ("²√");
            valor1 = double.Parse(rtxtbDisplay.Text);
            valor1 = Math.Sqrt(valor1);
            rtxtbDisplay.Text = valor1.ToString();
        }

        private void btnPotenciaQDR_Click(object sender, EventArgs e)
        {
            rtxtbOperacao.Text = ("x²");
            valor1 = double.Parse(rtxtbDisplay.Text);
            valor1 = valor1 * valor1;
            rtxtbDisplay.Text = valor1.ToString();
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Potencia;
            rtxtbOperacao.Text = ("xʸ");
            valor1 = double.Parse(rtxtbDisplay.Text);
            rtxtbDisplay.Text = ("");
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Raiz;
            rtxtbOperacao.Text = ("ʸ√x");
            valor1 = double.Parse(rtxtbDisplay.Text);
            rtxtbDisplay.Text = ("");
        }

        private void btnSen_Click(object sender, EventArgs e)
        {
            rtxtbOperacao.Text = ("sen");
            valor1 = double.Parse(rtxtbDisplay.Text);
            valor1 = Math.Sin(valor1 * (Math.PI / 180));
            rtxtbDisplay.Text = valor1.ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            rtxtbOperacao.Text = ("cos");
            valor1 = double.Parse(rtxtbDisplay.Text);
            valor1 = Math.Cos(valor1 * (Math.PI / 180));
            rtxtbDisplay.Text = valor1.ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            rtxtbOperacao.Text = ("tan");
            valor1 = double.Parse(rtxtbDisplay.Text);
            valor1 = Math.Tan(valor1 * (Math.PI / 180));
            rtxtbDisplay.Text = valor1.ToString();
        }

        private void btnRegistradorSalvar_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(rtxtbDisplay.Text);
            RegistradorValor = valor1.ToString();
            Registrador.Add(RegistradorValor);

            if(Registrador.Count() > 10)
            {
                MessageBox.Show("O registrador está cheio, exclua algum resultado antes de tentar salvar");
                return;
            }

            AtualizarRTXTBOXRegistrador();
        }

        private void AtualizarRTXTBOXRegistrador()
        {
            rtxtboxRegistrador.Clear();
            foreach(var RegistradorValor in Registrador)
            {
                rtxtboxRegistrador.AppendText(RegistradorValor + "\n");
            }
        }

        private void btnRegistradorSelecionar_Click(object sender, EventArgs e)
        {
            if (Registrador.Count > 0)
            {
                Registrador.RemoveAt(0);
                AtualizarRTXTBOXRegistrador();
            }
            else
            {
                MessageBox.Show("O registrador está vazio, não existe resultados para excluir");
            }
        }

        private void btnRegistradorApagar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Regist;
            rtxtbOperacao.Text = ("Regist");
        }
    }
}
