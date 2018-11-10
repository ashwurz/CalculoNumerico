﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            double[][] rows = new double[textBox1.Lines.Length][];
            for (int i = 0; i < rows.Length; i++)
            {
                try
                {
                    rows[i] = (double[])Array.ConvertAll(textBox1.Lines[i].Split(' '), new Converter<string, double>(Double.Parse));
                }
                catch (FormatException)
                {
                    textBox1.Clear();
                    string mensagem = "Por gentileza digite somente números e seguindo o padrão de Input conforme descrito no botão de Informações!";
                    string caption = "Erro detectado no Input";
                    MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                    DialogResult resultado;
                    resultado = MessageBox.Show(mensagem, caption, boxButtons);
                    return;
                }
            }

            int length = rows[0].Length;
            for (int i = 0; i < rows.Length - 1; i++)
            {
                for (int j = i; j < rows.Length; j++)
                {
                    double[] d = new double[length];
                    for (int x = 0; x < length; x++)
                    {
                        if (i == j && rows[j][i] == 0)
                        {
                            bool changed = false;
                            for (int z = rows.Length - 1; z > i; z--)
                            {
                                if (rows[z][i] != 0)
                                {
                                    double[] temp = new double[length];
                                    temp = rows[z];
                                    rows[z] = rows[j];
                                    rows[j] = temp;
                                    changed = true;
                                }
                            }
                            if (!changed)
                            {
                                textBox2.Text += "Sem Solução!\r\n";
                                return;
                            }
                        }
                        if (rows[j][i] != 0)
                        {
                            d[x] = rows[j][x] / rows[j][i];
                        }
                        else
                        {
                            d[x] = rows[j][x];
                        }
                    }
                    rows[j] = d;
                }
                for (int y = i + 1; y < rows.Length; y++)
                {
                    double[] f = new double[length];
                    for (int g = 0; g < length; g++)
                    {
                        if (rows[y][i] != 0)
                        {
                            f[g] = rows[y][g] - rows[i][g];
                        }
                        else
                        {
                            f[g] = rows[y][g];
                        }
                    }
                    rows[y] = f;
                }
            }
            double val = 0;
            int k = length - 2;
            double[] result = new double[rows.Length];
            for (int i = rows.Length - 1; i >= 0; i--)
            {
                val = rows[i][length - 1];
                for (int x = length - 2; x > k; x--)
                {
                    try
                    {
                        val -= rows[i][x] * result[x];
                    }
                    catch(IndexOutOfRangeException message)
                    {
                        textBox2.Text = "Sistema Possível e Indeterminado";
                        textBox1.Clear();
                        return;
                    }
                }
                result[i] = val / rows[i][i];
                if (result[i].ToString() == "NaN" || result[i].ToString().Contains("Infinity"))
                {
                    textBox2.Text += "Sem soluçao!\n";
                    return;
                }
                k--;
            }
            for (int i = 0; i < result.Length; i++)
            {
                textBox2.Text += string.Format("X{0} = {1}\r\n", i + 1, Math.Round(result[i], 10));
            }
            textBox1.Clear();
        }

        private void btnLagrange_Click(object sender, EventArgs e)
        {
            Interpolacao interpolacao = new Interpolacao();
            this.Hide();
            interpolacao.Show();
        }
    }
}
