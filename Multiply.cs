using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using System.Threading;


namespace Parallel_Computation
{
    public class Multiply
    {
        // stwórz 2 macierze i wydrukuj je na ekranie
        public Matrix<double> multiply(Matrix<double> A, Matrix<double> B, int numThreads) {


            Matrix<double> C = Matrix<double>.Build.Dense(A.RowCount, B.ColumnCount);

            ParallelOptions opt = new ParallelOptions(){MaxDegreeOfParallelism = numThreads};
            Parallel.For(0, A.RowCount, opt, i =>
            {
                for (int j = 0; j < B.ColumnCount; j++) // Iteracja po kolumnach macierzy B
                {
                    double sum = 0;
                    for (int k = 0; k < A.ColumnCount; k++) // Iteracja po elementach w wierszu A i kolumnie B
                    {
                        sum += A[i, k] * B[k, j];
                    }
                    C[i, j] = sum; // Zapisz wynik do C[i, j]
                }
            });


            return C;
            
        }

    }
}
