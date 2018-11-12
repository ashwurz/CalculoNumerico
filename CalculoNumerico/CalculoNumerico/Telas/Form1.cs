using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculoNumerico.Telas;

namespace CalculoNumerico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            double[][] linhas = new double[textBox1.Lines.Length][];
            for (int i = 0; i < linhas.Length; i++)
            {
                try
                {
                    linhas[i] = (double[])Array.ConvertAll(textBox1.Lines[i].Split(' '), new Converter<string, double>(Double.Parse));
                }
                catch (Exception)
                {
                    textBox1.Clear();
                    string mensagem = "Por gentileza digite somente números e seguindo o padrão de Input conforme descrito no botão de Informações!";
                    string caption = "Erro detectado no Input";
                    MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                    DialogResult resultado1;
                    resultado1 = MessageBox.Show(mensagem, caption, boxButtons);
                    return;
                }
            }

            int tamanho = linhas[0].Length;
            for (int i = 0; i < linhas.Length - 1; i++)
            {
                for (int j = i; j < linhas.Length; j++)
                {
                    double[] d = new double[tamanho];
                    for (int x = 0; x < tamanho; x++)
                    {
                        if (i == j && linhas[j][i] == 0)
                        {
                            bool mudou = false;
                            for (int z = linhas.Length - 1; z > i; z--)
                            {
                                if (linhas[z][i] != 0)
                                {
                                    double[] temp = new double[tamanho];
                                    temp = linhas[z];
                                    linhas[z] = linhas[j];
                                    linhas[j] = temp;
                                    mudou = true;
                                }
                            }
                            if (!mudou)
                            {
                                textBox2.Text += "Sem Solução!\r\n";
                                return;
                            }
                        }
                        if (linhas[j][i] != 0)
                        {
                            d[x] = linhas[j][x] / linhas[j][i];
                        }
                        else
                        {
                            d[x] = linhas[j][x];
                        }
                    }
                    linhas[j] = d;
                }
                for (int y = i + 1; y < linhas.Length; y++)
                {
                    double[] f = new double[tamanho];
                    for (int g = 0; g < tamanho; g++)
                    {
                        if (linhas[y][i] != 0)
                        {
                            f[g] = linhas[y][g] - linhas[i][g];
                        }
                        else
                        {
                            f[g] = linhas[y][g];
                        }
                    }
                    linhas[y] = f;
                }
            }
            double val = 0;
            int k = tamanho - 2;
            double[] resultado = new double[linhas.Length];
            for (int i = linhas.Length - 1; i >= 0; i--)
            {
                val = linhas[i][tamanho - 1];
                for (int x = tamanho - 2; x > k; x--)
                {
                    try
                    {
                        val -= linhas[i][x] * resultado[x];
                    }
                    catch(IndexOutOfRangeException)
                    {
                        textBox2.Text = "Sistema Possível e Indeterminado";
                        textBox1.Clear();
                        return;
                    }
                }
                resultado[i] = val / linhas[i][i];
                if (resultado[i].ToString() == "NaN" || resultado[i].ToString().Contains("Infinity"))
                {
                    textBox2.Text += "Sem soluçao!\n";
                    return;
                }
                k--;
            }
            for (int i = 0; i < resultado.Length; i++)
            {
                textBox2.Text += string.Format("X{0} = {1}\r\n", i + 1, Math.Round(resultado[i], 10));
            }
            textBox1.Clear();
        }

        private void btnLagrange_Click(object sender, EventArgs e)
        {
            Interpolacao interpolacao = new Interpolacao();
            this.Hide();
            interpolacao.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Informacao informacao = new Informacao();
            informacao.Show();
        }

        private void funçãoInversaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculaMatriz matriz = new CalculaMatriz();
            this.Hide();
            matriz.Show();
        }
    }
}
