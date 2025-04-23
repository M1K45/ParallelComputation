using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Computation
{
    public class MultiplyLowLewel
    {
        
        public Matrix<double> multiply(Matrix<double> A, Matrix<double> B, int numThreads)
        {
            

            Matrix<double> C = Matrix<double>.Build.Dense(A.RowCount, B.ColumnCount);
            Thread[] threads = new Thread [numThreads];

            for (int i = 0; i < numThreads; i++)
            {
                int threadIndex = i;
                threads[i] = new Thread(() => divide(threadIndex, numThreads, C, A, B));
                threads[i].Start();
            }
            //foreach (Thread x in threads) x.Start();
            foreach (Thread x in threads) x.Join();
            return C;

        }

        static void divide(int threadIndex, int numThreads, Matrix<double>C, Matrix<double>A, Matrix<double>B) {
            for (int row = threadIndex; row < A.RowCount; row+= numThreads)
            {
                for (int col = 0;  col < B.ColumnCount; col++) // Iteracja po kolumnach macierzy B
                {
                    double sum = 0;
                    for (int element = 0; element < A.ColumnCount; element++) // Iteracja po elementach w wierszu A i kolumnie B
                    {
                        sum += A[row, element] * B[element, col];
                    }
                    C[row, col] = sum; // Zapisz wynik do C[i, j]
                }
            }
        }
    }
}
