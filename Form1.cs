    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Net.Configuration;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web;
    using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double resultado = 0, num1 = 1, num2 = 2, num3 = 3, porcentagem, num4 = 4, num5 = 5, num6 = 6, num7 = 7, num8 = 8, num9 = 9, num0 = 0, numeros = 0, numeros2 = 0;
        string ponto = ",", l = "", variavel = "", operacao = "", hist="";
        string v = "";
        double memoria = 0;
        bool calcs=false, mem=false;
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblN2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                numeros = Convert.ToDouble(label1.Text);
                textBox1.Text = label1.Text + " / ";
                textBox1.Text = textBox1.Text;
                label1.Clear();
                operacao = "/";
            }
        }
        double valornum;
        double valorfin;
        private void BtnMais_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                numeros = Convert.ToDouble(label1.Text);
                textBox1.Text = label1.Text + " + ";
                textBox1.Text = textBox1.Text;
                label1.Clear();
                operacao = "+";
            }
        }

            private void Form1_Load(object sender, EventArgs e)
            {
                listBoxMemoria.Visible = false;
                listBoxHist.Visible = false;
                listBoxCalcs.Visible = false;
                BtnFecharCalcs.Visible = false;
                BtnFecharHist.Visible = false;
                BtnFecharMemoria.Visible = false;
                BtnLimparHist.Visible = false;
            }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
            {
                double n1, resultado;
                n1 = Convert.ToDouble(label1.Text);
                resultado = n1;
                label1.Text = Convert.ToString(resultado);
            }

            private void BtnMenos_Click(object sender, EventArgs e)
            {
                if (label1.Text != "")
                {
                    numeros = Convert.ToDouble(label1.Text);
                    textBox1.Text = label1.Text + " - ";
                    textBox1.Text = textBox1.Text;
                    label1.Clear();
                    operacao = "-";
                }
            }

            private void BtnMult_Click(object sender, EventArgs e)
            {
                if (label1.Text != "")
                {
                    numeros = Convert.ToDouble(label1.Text);
                    textBox1.Text = label1.Text + " x ";
                    textBox1.Text = textBox1.Text;
                    label1.Clear();
                    operacao = "x";
                }
            }

            private void button1_Click(object sender, EventArgs e)
            {
                valornum = 0; 
                valorfin=0;
                numeros = 0;
                numeros2 = 0;
                resultado = 0;
                label1.Text = l;
                textBox1.Text = l;
                operacao = "";
            }

            private void BtnSeis_Click(object sender, EventArgs e)
            {
                if (label1.Text == Convert.ToString(resultado))
                {
                    label1.Text = l;
                }
                label1.Text += num6;
            }

            private void BtnSete_Click(object sender, EventArgs e)
            {
                variavel = label1.Text;
                if (label1.Text == Convert.ToString(resultado))
                {
                     label1.Text = l;
                }
                label1.Text += num7;
            }

            private void BtnNove_Click(object sender, EventArgs e)
            {
                if (label1.Text == Convert.ToString(resultado))
                {   
                    label1.Text = l;
                }
                label1.Text += num9;
            }

            private void BtnC_Click(object sender, EventArgs e)
            {
                string C = label1.Text;
                if (C.Count() > 0)
                {
                    C = C.Substring(0, C.Count() - 1);
                    label1.Text = C;
                }
                else {
                    MessageBox.Show("Não há caracteres!");
                }
            }

            private void BtnPonto_Click(object sender, EventArgs e)
            {
                label1.Text += ponto;
            }

            private void button2_Click(object sender, EventArgs e)
            {
                if(!label1.Text.Contains(","))
                label1.Text += ",";
            }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                memoria += Convert.ToDouble(label1.Text);
                listBoxMemoria.Items.Add($"{memoria}");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                memoria -= Convert.ToDouble(label1.Text);
                listBoxMemoria.Items.Add($"{memoria}");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (mem == true)
            {
                listBoxMemoria.Visible=false;
            }
            mem = true;
            listBoxMemoria.Visible = true;
            BtnFecharMemoria.Visible = true;
            listBoxMemoria.Location = new Point(7, 169);
            BtnFecharMemoria.Location = new Point(231, 407);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(memoria);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            memoria = 0;
            listBoxMemoria.Items.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                listBoxMemoria.Items.Add($"{memoria}");
            }
        }

        private void BtnFecharListBox_Click(object sender, EventArgs e)
        {
            listBoxMemoria.Visible = false;
            BtnFecharMemoria.Visible = false;
            BtnLimparHist.Visible = false;
            listBoxMemoria.Location = new Point(320, 169);
            BtnFecharMemoria.Location = new Point(528, 183); 
        }

        private void LinkLblHist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxHist.Visible = true;
            BtnFecharHist.Visible = true;
            BtnLimparHist.Visible = true;
            listBoxHist.Location = new Point(7, 169);
            BtnFecharHist.Location = new Point(231, 367);
            BtnLimparHist.Location = new Point(231, 407);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            BtnFecharHist.Visible = false;
            BtnLimparHist.Visible=false;
            listBoxHist.Visible = false;
            listBoxHist.Location = new Point(626, 169);
            BtnFecharHist.Location = new Point(836, 183);
            BtnLimparHist.Location = new Point(836, 229);
        }

        private void listBoxHist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            listBoxHist.Items.Clear();
        }

        private void LinkLabelTresBarras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listBoxCalcs.Items.Count == 0)
            {
                listBoxCalcs.Visible = true;
                BtnFecharCalcs.Visible = true;
                listBoxCalcs.BringToFront();
                BtnFecharCalcs.BringToFront();
                listBoxCalcs.Items.Add($"🔢 Padrão");
                listBoxCalcs.Items.Add($"🔬 Científica");
                listBoxCalcs.Items.Add($"📈 Representação Gráfica");
                listBoxCalcs.Items.Add($"💻 Programador");
                listBoxCalcs.Items.Add($"📅 Cálculo de data");
                listBoxCalcs.Location = new Point(7, 35);
                BtnFecharCalcs.Location = new Point(151, 261);
            }
        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            listBoxCalcs.Visible = false;
            BtnFecharCalcs.Visible = false;
            listBoxCalcs.Location = new Point(459, 42);
            BtnFecharCalcs.Location = new Point(588, 59);
            listBoxHist.Items.Clear();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(label1.Text);
            a = -a;
            label1.Text=a.ToString();
        }

        private void listBoxMemoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
            {
                label1.Text = l;
            }

            private void button5_Click(object sender, EventArgs e)
            {
                if (label1.Text != "")
                {
                    numeros = Convert.ToDouble(label1.Text);
                    textBox1.Text = "1/ ( " + numeros + " )";
                    resultado = 1 / numeros;
                    label1.Text = Convert.ToString(resultado);
                }
                if (label1.Text != "")
                {
                    listBoxHist.Items.Add($"{textBox1.Text} = {resultado}");
                }
            }

            private void button4_Click_1(object sender, EventArgs e)
            {
                if (label1.Text != "")
                {
                    numeros = Convert.ToDouble(label1.Text);
                    textBox1.Text = "sqr (" + numeros + ")";
                    resultado = numeros * numeros;
                    label1.Text = Convert.ToString(resultado);
                }
                if (label1.Text != "")
                {
                    listBoxHist.Items.Add($"{textBox1.Text} = {resultado}");
                }
            }

            private void button3_Click(object sender, EventArgs e)
            {
                if (label1.Text != "")
                {
                    numeros = Convert.ToDouble(label1.Text);
                    textBox1.Text = "√ ( " + numeros + " )";
                    resultado = Math.Sqrt(numeros);
                    label1.Text = Convert.ToString(resultado);
                }
                if (label1.Text != "")
                {
                    listBoxHist.Items.Add($"{textBox1.Text} = {resultado}");
                }
            }

            private void label3_Click(object sender, EventArgs e)
            {
                textBox1.Text= label1.Text;
                label1.Text = l;
            }

            private void BtnPorcentagem_Click(object sender, EventArgs e)
            {
            if (label1.Text != "" && textBox1.Text != "")
            {
                double numero = Convert.ToDouble(label1.Text);
                double numperc = numero / 100;
                if (operacao == "+")
                {
                    porcentagem = numeros * (numero / 100.0);
                    resultado = numeros + porcentagem;
                    textBox1.Text = numeros + " + " + porcentagem + " = " + resultado;
                }
                if (operacao == "-")
                {
                    porcentagem = numeros * (numero / 100.0);
                    resultado = numeros - porcentagem;
                    textBox1.Text = numeros + " - " + porcentagem + " = " + resultado;
                }
                if (operacao == "x")
                {
                    resultado = numeros * (numero / 100.0);
                    textBox1.Text = numeros + " x " + numperc + " = " + resultado;
                }
                if (operacao == "/")
                {
                    resultado = numeros / (numero / 100.0);
                    textBox1.Text = numeros + " / " + numperc + " = " + resultado;
                }

                label1.Text = resultado.ToString();
                operacao = "";
                listBoxHist.Items.Add($"{textBox1.Text}");
                }
            }

            private void BtnOito_Click(object sender, EventArgs e)
            {
                if (label1.Text == Convert.ToString(resultado))
                {
                   label1.Text = l;
                }
                label1.Text += num8;
            }

            private void BtnCinco_Click(object sender, EventArgs e)
            {
                if (label1.Text == Convert.ToString(resultado))
                {
                    label1.Text = l;
                }
                label1.Text += num5;
            }

            private void BtnQuatro_Click(object sender, EventArgs e)
            {
                if (label1.Text == Convert.ToString(resultado))
                {
                    label1.Text = l;
                }
                label1.Text += num4;
            }

            private void BtnUm_Click(object sender, EventArgs e)
            {
                if (label1.Text == Convert.ToString(resultado))
                {
                    label1.Text = l;
                }
                label1.Text += num1;
            }

            private void BtnDois_Click(object sender, EventArgs e)
            {
                if (label1.Text == Convert.ToString(resultado))
                {
                    label1.Text = l;
                }
                label1.Text += num2;
            }

            private void BtnTres_Click(object sender, EventArgs e)
            {
                if (label1.Text == Convert.ToString(resultado))
                {
                    label1.Text = l;
                }
                label1.Text += num3;
            }

            private void BtnZero_Click(object sender, EventArgs e)
            {
                if (label1.Text == Convert.ToString(resultado))
                {
                    label1.Text = l;
                }
                label1.Text += num0;
            }

            private void TxtN1_TextChanged(object sender, EventArgs e)
            {

            }

            private void bntCalc_Click(object sender, EventArgs e)
            {
                if (label1.Text != "")
                {
                if (operacao == "+")
                {
                    numeros2 = Convert.ToDouble(label1.Text);
                    resultado = numeros + numeros2;
                    label1.Text = Convert.ToString(resultado);
                    textBox1.Text = Convert.ToString(textBox1.Text + numeros2 + " = ");
                    operacao = "";
                    label3.Text = label1.Text;
                }
                if (operacao == "-")
                {
                    numeros2 = Convert.ToDouble(label1.Text);
                    resultado = numeros - numeros2;
                    label1.Text = Convert.ToString(resultado);
                    textBox1.Text = Convert.ToString(textBox1.Text + numeros2 + " = ");
                    operacao = "";
                    label3.Text = label1.Text;
                }
                if (operacao == "x")
                {
                    numeros2 = Convert.ToDouble(label1.Text);
                    resultado = numeros * numeros2;
                    label1.Text = Convert.ToString(resultado);
                    textBox1.Text = Convert.ToString(textBox1.Text + numeros2 + " = ");
                    operacao = "";
                    label3.Text = label1.Text;
                }
                if (operacao == "/")
                {
                    numeros2 = Convert.ToDouble(label1.Text);
                    resultado = numeros / numeros2;
                    if (numeros == 0 || numeros2 == 0)
                    {
                        MessageBox.Show("Não é possível dividir um número por zero!");
                        label1.Clear();
                        textBox1.Text = l;
                    }
                    label1.Text = Convert.ToString(resultado);
                    textBox1.Text = Convert.ToString(textBox1.Text + numeros2 + " = ");
                    operacao = "";
                }
                if (label1.Text != "")
                {
                    listBoxHist.Items.Add($"{textBox1.Text} {resultado}");
                }
                }
            }

            private void label1_Click_2(object sender, EventArgs e)
            {
            
            }
        }
    }
