using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoNumerico
{
    class Matriz
    {
        float[,] matriz;

        public Matriz(float[,] m)
        {
            matriz = m;
        }

        public float Determinante()
        {
            if (matriz.GetLength(0) != matriz.GetLength(1))
                MessageBox.Show("Matriz não é quadrada!", "Error - Formato");
            return Determinante(this.matriz);
        }

        private float[,] ElimFilCol(float[,] a, int fila, int column)
        {
            float[,] result = new float[a.GetLength(0) - 1, a.GetLength(1) - 1];
            bool fil = false;
            bool col = false;
            for (int i = 0; i < result.GetLength(0); i++)
            {
                col = false;
                if (i == fila) { fil = true; }
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    if (j == column) { col = true; }
                    if (!fil && !col) { result[i, j] = a[i, j]; }
                    if (!fil && col) { result[i, j] = a[i, j + 1]; }
                    if (fil && !col) { result[i, j] = a[i + 1, j]; }
                    if (fil && col) { result[i, j] = a[i + 1, j + 1]; }

                }
            }
            return result;
        }

        private float Determinante(float[,] m)
        {
            float determinante = 0;


            if (m.Length == 1)
                return m[0, 0];

            else
            {
                for (int i = 0; i < m.GetLength(0); i++)
                {
                    determinante += (float)Math.Pow(-1, i) * m[i, 0] * Determinante(ElimFilCol(m, i, 0));
                }
            }

            return determinante;
        }

        public float[,] Inversa()
        {
            float determinante = Determinante();
            if (determinante == 0)
            {
                return matriz;
            }
            else
            {
                float[,] result = new float[matriz.GetLength(0), matriz.GetLength(1)];
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        result[i, j] = (float)Math.Pow(-1, i + j) * Determinante(ElimFilCol(matriz, i, j));
                    }
                }
                result = EscalarMult(Transposta(result), 1 / determinante);
                return result;
            }
        }

        float[,] EscalarMult(float[,] matriz, float escalar)
        {
            float[,] multiplicada = new float[matriz.GetLength(0), matriz.GetLength(1)];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    multiplicada[i, j] = escalar * matriz[i, j];
                }
            }

            return multiplicada;
        }

        float[,] Transposta(float[,] m)
        {
            float[,] result = new float[m.GetLength(0), m.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = m[j, i];
                }
            }
            return result;
        }

        public float[,] Transposta()
        {
            float[,] result = new float[matriz.GetLength(0), matriz.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = matriz[j, i];
                }
            }
            return result;
        }

        public float[,] Multiplicacao(float[,] b)
        {
            if (matriz.GetLength(1) != b.GetLength(0))
                MessageBox.Show("Matriz não são possiveis de se multiplicar!", "Error - Produto");
            float[,] result = new float[matriz.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                    for (int k = 0; k < matriz.GetLength(1); k++)
                    {
                        result[i, j] += matriz[i, k] * b[k, j];
                    }
            return result;
        }
    }
}
