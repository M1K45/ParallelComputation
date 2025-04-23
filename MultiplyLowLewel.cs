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
                threads[i] = new Thread(() => divide(i, numThreads, C, A, B));  
            }

            foreach (Thread x in threads) x.Start();
            foreach (Thread x in threads) x.Join();





            return C;

        }

        static void divide(int threadIndex, int numThreads, Matrix<double>C, Matrix<double>A, Matrix<double>B) {
            int elements = A.RowCount * B.ColumnCount;

            for (int i = threadIndex; i < A.RowCount; i+= numThreads)
            {
                for (int j = 0; j < B.ColumnCount; j++) // Iteracja po kolumnach macierzy B
                {
                    double sum = 0;
                    for (int k = 0; k < A.ColumnCount; k++) // Iteracja po elementach w wierszu A i kolumnie B
                    {
                        // sprawdzenie, czy to jest ten z kolei 

                        sum += A[i, k] * B[k, j];
                    }
                    C[i, j] = sum; // Zapisz wynik do C[i, j]
                }
            }

        }
    }
}
