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
    public partial class Interpolacao : Form
    {
        public Interpolacao()
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
            try
            {
                double[] xd = (double[])Array.ConvertAll(arrayX.Lines[0].Split(' '), new Converter<string, double>(Double.Parse));
                double[] yd = (double[])Array.ConvertAll(arrayY.Lines[0].Split(' '), new Converter<string, double>(Double.Parse));
                double x = double.Parse(valorX.Text);
                arrayX.Clear();
                arrayY.Clear();
                valorX.Clear();
                resposta.Text = Convert.ToString(Lagrange(x, xd, yd));
            }
            catch(Exception)
            {
                arrayX.Clear();
                arrayY.Clear();
                valorX.Clear();
                string mensagem = "Por gentileza digite somente números e seguindo o padrão de Input conforme descrito no botão de Informações!";
                string caption = "Erro detectado no Input";
                MessageBoxButtons boxButtons = MessageBoxButtons.OK;
                DialogResult resultado;
                resultado = MessageBox.Show(mensagem, caption, boxButtons);
            }
            
        }

        static public double Lagrange(double x, double[] xd, double[] yd)
        {
            if (xd.Length != yd.Length)
            {
                throw new ArgumentException("Os vetores devem ser de mesmo tamanho"); 
            }
            double sum = 0;
            for (int i = 0, n = xd.Length; i < n; i++)
            {
                if (x - xd[i] == 0)
                {
                    return yd[i];
                }
                double product = yd[i];
                for (int j = 0; j < n; j++)
                {
                    if ((i == j) || (xd[i] - xd[j] == 0))
                    {
                        continue;
                    }
                    product *= (x - xd[j]) / (xd[i] - xd[j]);
                }
                sum += product;
            }
            return sum;
        }

        private void btnSistemas_Click(object sender, EventArgs e)
        {
            Form1 sistemas = new Form1();
            this.Hide();
            sistemas.Show();
        }

        private void calcularMatrizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculaMatriz matrizes = new CalculaMatriz();
            this.Hide();
            matrizes.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Informacao2 informacao = new Informacao2();
            informacao.Show();
        }
    }
}
