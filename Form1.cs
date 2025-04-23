using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Random;


namespace Parallel_Computation
{
    public partial class Form1 : Form
    {
        int dimension = 0;
        Random rng = new Random();
        int attemptsNumber = 1;
        float time = 0;
        long watch;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dimension = Int32.Parse(textBoxSizeMatrix.Text);

            var watch = System.Diagnostics.Stopwatch.StartNew();

            if (checkBoxLowLevel.Checked)
            {
                if (checkBoxVisualize.Checked)
                {
                    attemptsNumber = 10;
                    richTextBoxData.Text += $"\n[Research Mode | Low-Level]";
                }
                else
                {
                    richTextBoxData.Text += $"\n[Vizualization Mode | Low-Level]";

                }

                MultiplyLowLewel multiply = new MultiplyLowLewel();

                for (int i = 0; i < attemptsNumber; i++)
                {
                    // generating matricies (integers for easier checking)
                    Matrix<double> A = Matrix<double>.Build.Dense(dimension, dimension, (i, j) => rng.Next(0, 10));
                    Matrix<double> B = Matrix<double>.Build.Dense(dimension, dimension, (i, j) => rng.Next(0, 10));

                    watch = System.Diagnostics.Stopwatch.StartNew();
                    Matrix<double> C = multiply.multiply(A, B, Int32.Parse(textBoxThreadsNum.Text));
                    watch.Stop();
                    time += watch.ElapsedMilliseconds;

                    if (attemptsNumber == 1)
                    {
                        richTextBoxMatrixA.Text = A.ToString();
                        richTextBoxMatrixB.Text = B.ToString();
                        richTextBoxMatrixC.Text = C.ToString();
                    }
                }
            }
            else
            {
                Multiply multiply = new Multiply();

                if (checkBoxVisualize.Checked)
                {
                    attemptsNumber = 10;
                    richTextBoxData.Text += $"\n[Research Mode | High-Level]";
                }
                else
                {
                    richTextBoxData.Text += $"\n[Vizualization Mode | High-Level]";

                }
                // loop mutiplying matricies 
                for (int i = 0; i < attemptsNumber; i++)
                {

                    // generating matricies (integers for easier checking)
                    Matrix<double> A = Matrix<double>.Build.Dense(dimension, dimension, (i, j) => rng.Next(0, 10));
                    Matrix<double> B = Matrix<double>.Build.Dense(dimension, dimension, (i, j) => rng.Next(0, 10));

                    watch = System.Diagnostics.Stopwatch.StartNew();
                    Matrix<double> C = multiply.multiply(A, B, Int32.Parse(textBoxThreadsNum.Text));
                    watch.Stop();
                    time += watch.ElapsedMilliseconds;

                    if (attemptsNumber == 1)
                    {
                        richTextBoxMatrixA.Text = A.ToString();
                        richTextBoxMatrixB.Text = B.ToString();
                        richTextBoxMatrixC.Text = C.ToString();
                    }
                }

            }
            // recieving avg time 
            time /= attemptsNumber;

            // podanie czasu wykonania
            Data data = new(time, dimension, Int32.Parse(textBoxThreadsNum.Text));
            richTextBoxData.Text += data.ToString();
        }

    }
}
//  zad 2 niksopoziomowo klasas thread 
// osobno ka¿dy w¹tek,d do niego funkcjêi wystartowaæ / macierz podziel miêdzy w¹tki 
// potrzebna jeat pewenosc skoñczonej pracy w¹tkow 
