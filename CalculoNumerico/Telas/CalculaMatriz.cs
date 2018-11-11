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
    public partial class CalculaMatriz : Form
    {
        public CalculaMatriz()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void btnLagrange_Click(object sender, EventArgs e)
        {
            Interpolacao interpolacao = new Interpolacao();
            this.Hide();
            interpolacao.Show();
        }

        private void btnSistemas_Click(object sender, EventArgs e)
        {
        }

        private TextBox[,] Matriz;
        private TextBox[,] MatrizResultante;
        private TextBox[,] MatrizResultado;

        int linha, coluna;
        int linhaR;
        private float determinante;
        Matriz matrix;
        Matriz result;

        private void btnGerarTransposta_Click(object sender, EventArgs e)
        {
            if (Matriz == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempResultante = new float[Matriz.GetLength(0), Matriz.GetLength(1)];

            for (int x = 0; x < Matriz.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            matrix = new Matriz(tempResultante);

            float[,] tempMatrizResultante = matrix.Transposta();
            int TamanhoText = groupBoxMatriz.Width / Matriz.GetLength(1);
            Matriz = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            groupBoxMatriz.Controls.Clear();
            for (int x = 0; x < Matriz.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz.GetLength(1); y++)
                {
                    Matriz[x, y] = new TextBox();
                    Matriz[x, y].Text = tempMatrizResultante[x, y].ToString();
                    Matriz[x, y].Top = (x * Matriz[x, y].Height) + 20;
                    Matriz[x, y].Left = y * TamanhoText + 6;
                    Matriz[x, y].Width = TamanhoText;
                    groupBoxMatriz.Controls.Add(Matriz[x, y]);
                }
            }

        }


        private void btnGerarDeterminante_Click(object sender, EventArgs e)
        {
            if (Matriz == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempResultante = new float[Matriz.GetLength(0), Matriz.GetLength(1)];

            for (int x = 0; x < Matriz.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            matrix = new Matriz(tempResultante);
            if (tempResultante.GetLength(0) == tempResultante.GetLength(1))
            {
                determinante = matrix.Determinante();
                MessageBox.Show("" + determinante, "Determinante");
            }
            else
            {
                MessageBox.Show("Nao e possivel gerar determinante !", "Error - Matriz invalida ");
            }
        }

        private void btnGerarInversa_Click(object sender, EventArgs e)
        {
            if (Matriz == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempResultante = new float[Matriz.GetLength(0), Matriz.GetLength(1)];
            float[,] inversa = new float[Matriz.GetLength(0), Matriz.GetLength(1)];
            if (tempResultante.GetLength(0) != 2 || tempResultante.GetLength(1) != 2)
            {
                if (tempResultante.GetLength(0) != 3 || tempResultante.GetLength(1) != 3)
                {
                    MessageBox.Show("Matriz invalida !", "Error - Matriz");
                    return;
                }
            }
            for (int x = 0; x < Matriz.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            matrix = new Matriz(tempResultante);
            if (tempResultante.GetLength(0) == tempResultante.GetLength(1))
            {
                determinante = matrix.Determinante();
            }
            else
            {
                MessageBox.Show("Matriz invalida !", "Error - Matriz");
                return;
            }
            if (determinante == 0)
            {
                MessageBox.Show("Matriz invalida, determinante igual a 0 !", "Error - Matriz");
                return;
            }
            inversa = matrix.Inversa();
            int TamanhoText = groupBoxMatriz.Width / Matriz.GetLength(1);
            for (int x = 0; x < Matriz.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz.GetLength(1); y++)
                {
                    Matriz[x, y].Text = inversa[x, y].ToString();
                }
            }
        }

        private void btnCriaResultante_Click(object sender, EventArgs e)
        {
            groupBoxResultante.Controls.Clear();
            if (!int.TryParse(edtR.Text, out linhaR))
            {
                MessageBox.Show("A linha da matriz é nula.", "Erro");
                return;
            }

            MatrizResultante = new TextBox[linhaR, 1];
            int TamanhoText = groupBoxResultante.Width;
            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    MatrizResultante[x, y] = new TextBox();
                    MatrizResultante[x, y].Text = "0";
                    MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                    MatrizResultante[x, y].Left = y * TamanhoText + 6;
                    MatrizResultante[x, y].Width = TamanhoText;
                    groupBoxResultante.Controls.Add(MatrizResultante[x, y]);
                }
            }

        }

        private void btnGeraMultiplica_Click(object sender, EventArgs e)
        {
            if (Matriz == null || MatrizResultante == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempMatriz = new float[Matriz.GetLength(0), Matriz.GetLength(1)];
            float[,] tempMatrizResultante = new float[MatrizResultante.GetLength(0), MatrizResultante.GetLength(1)];
            if (tempMatriz.GetLength(1) != tempMatrizResultante.GetLength(0))
            {
                MessageBox.Show("So e possivel a multiplicacao de matrizes onde a coluna da matriz 1 e igual a linha da matriz 2!", "Erro - Multiplicacao Matrizes");
                return;
            }

            for (int x = 0; x < Matriz.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz[x, y].Text, out n);
                    tempMatriz[x, y] = n;
                }
            }
            matrix = new Matriz(tempMatriz);
            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizResultante[x, y].Text, out n);
                    tempMatrizResultante[x, y] = n;
                }
            }
            result = new Matriz(tempMatrizResultante);

            float[,] tempMatrizResultado = matrix.Multiplicacao(tempMatrizResultante);
            MatrizResultado = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            int TamanhoText = groupBoxResultante.Width;
            groupBoxResultante.Controls.Clear();
            for (int x = 0; x < MatrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultado.GetLength(1); y++)
                {
                    MatrizResultado[x, y] = new TextBox();
                    MatrizResultado[x, y].Text = tempMatrizResultado[x, y].ToString();
                    MatrizResultado[x, y].Top = (x * MatrizResultado[x, y].Height) + 20;
                    MatrizResultado[x, y].Left = y * TamanhoText + 6;
                    MatrizResultado[x, y].Width = TamanhoText;
                    groupBoxResultante.Controls.Add(MatrizResultado[x, y]);
                }
            }
            groupBoxMatriz.Controls.Clear();
        }

        private void btnGerarFuncaoInv_Click(object sender, EventArgs e)
        {
            if (Matriz == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempResultante = new float[Matriz.GetLength(0), Matriz.GetLength(1)];
            float[,] inversa = new float[Matriz.GetLength(0), Matriz.GetLength(1)];
            if (tempResultante.GetLength(0) != 2 || tempResultante.GetLength(1) != 2)
            {
                if (tempResultante.GetLength(0) != 3 || tempResultante.GetLength(1) != 3)
                {
                    MessageBox.Show("Matriz invalida !", "Error - Matriz");
                    return;
                }
            }
            for (int x = 0; x < Matriz.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(Matriz[x, y].Text, out n);
                    tempResultante[x, y] = n;
                }
            }
            matrix = new Matriz(tempResultante);
            if (tempResultante.GetLength(0) == tempResultante.GetLength(1))
            {
                determinante = matrix.Determinante();
            }
            else
            {
                MessageBox.Show("Matriz invalida !", "Error - Matriz");
                return;
            }
            if (determinante == 0)
            {
                MessageBox.Show("Matriz invalida, determinante igual a 0 !", "Error - Matriz");
                return;
            }
            inversa = matrix.Inversa();
            int TamanhoText = groupBoxMatriz.Width / Matriz.GetLength(1);
            for (int x = 0; x < Matriz.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz.GetLength(1); y++)
                {
                    Matriz[x, y].Text = inversa[x, y].ToString();
                }
            }

            if (inversa == null || MatrizResultante == null)
            {
                MessageBox.Show("Matriz nula !", "Error - Matriz");
                return;
            }
            float[,] tempMatrizInversa = new float[inversa.GetLength(0), inversa.GetLength(1)];
            float[,] tempMatrizResultante = new float[MatrizResultante.GetLength(0), MatrizResultante.GetLength(1)];
            if (tempMatrizInversa.GetLength(1) != tempMatrizResultante.GetLength(0))
            {
                MessageBox.Show("So e possivel a multiplicacao de matrizes onde a coluna da matriz 1 e igual a linha da matriz 2!", "Erro - Multiplicacao Matrizes");
                return;
            }

            for (int x = 0; x < inversa.GetLength(0); x++)
            {
                for (int y = 0; y < inversa.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(inversa[x, y].ToString(), out n);
                    tempMatrizInversa[x, y] = n;
                }
            }
            matrix = new Matriz(tempMatrizInversa);
            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    float n = 0;
                    float.TryParse(MatrizResultante[x, y].Text, out n);
                    tempMatrizResultante[x, y] = n;
                }
            }
            result = new Matriz(tempMatrizResultante);

            float[,] tempMatrizResultado = matrix.Multiplicacao(tempMatrizResultante);
            MatrizResultado = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
            int TamanhoText1 = groupBoxResultante.Width;
            groupBoxResultante.Controls.Clear();
            for (int x = 0; x < MatrizResultado.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultado.GetLength(1); y++)
                {
                    MatrizResultado[x, y] = new TextBox();
                    MatrizResultado[x, y].Text = tempMatrizResultado[x, y].ToString();
                    MatrizResultado[x, y].Top = (x * MatrizResultado[x, y].Height) + 20;
                    MatrizResultado[x, y].Left = y * TamanhoText1 + 6;
                    MatrizResultado[x, y].Width = TamanhoText1;
                    groupBoxResultante.Controls.Add(MatrizResultado[x, y]);
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Informacao3 informacao = new Informacao3();
            informacao.Show();
        }

        private void métodoDeGaussToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 gauss = new Form1();
            this.Hide();
            gauss.Show();
        }

        private void btnCriarMatriz_Click(object sender, EventArgs e)
        {
            groupBoxMatriz.Controls.Clear();
            if (!int.TryParse(edtX.Text, out linha))
            {
                MessageBox.Show("A linha da matriz é nula.", "Erro");
                return;
            }
            if (!int.TryParse(edtY.Text, out coluna))
            {
                MessageBox.Show("A coluna da matriz é nula.", "Erro");
                return;
            }

            Matriz = new TextBox[linha, coluna];
            int TamanhoText = groupBoxMatriz.Width / coluna;
            for (int x = 0; x < Matriz.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz.GetLength(1); y++)
                {
                    Matriz[x, y] = new TextBox();
                    Matriz[x, y].Text = "0";
                    Matriz[x, y].Top = (x * Matriz[x, y].Height) + 20;
                    Matriz[x, y].Left = y * TamanhoText + 6;
                    Matriz[x, y].Width = TamanhoText;
                    groupBoxMatriz.Controls.Add(Matriz[x, y]);
                }
            }
        }
    }
}
