using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Random;
using Microsoft.VisualBasic;
using CsvHelper;
using System.Globalization;


namespace Parallel_Computation
{
    public partial class Save : Form
    {
        public string fileName = "data.csv";
        Random rng = new Random();
        int attemptsNumber = 1;
        List<Measurements> DataList = new List<Measurements>();

        public Save()
        {
            InitializeComponent();  

        }

        private void button1_Click(object sender, EventArgs e)
        {
                    Measurements measurement = new Measurements();
                    measurement.dimension = Int32.Parse(textBoxSizeMatrix.Text);

                    measurement.threadsNum = Int32.Parse(textBoxThreadsNum.Text);
                    measurement.time = 0;

                    richTextBoxMatrixA.Text = null;
                    richTextBoxMatrixB.Text = null;
                    richTextBoxMatrixC.Text = null;
                    attemptsNumber = 1;




                    var watch = System.Diagnostics.Stopwatch.StartNew();

                    if (checkBoxLowLevel.Checked)
                    {
                        measurement.paralellType = "low";

                        if (checkBoxVisualize.Checked)
                        {
                            attemptsNumber = 10;
                            richTextBoxData.Text += $"\n[Research Mode | Low-Level]";
                            measurement.isResearch = true;
                        }
                        else
                        {
                            richTextBoxData.Text += $"\n[Vizualization Mode | Low-Level]";
                            measurement.isResearch = false;

                        }

                        MultiplyLowLewel multiply = new MultiplyLowLewel();

                        for (int i = 0; i < attemptsNumber; i++)
                        {
                            // generating matricies (integers for easier checking)
                            Matrix<double> A = Matrix<double>.Build.Dense(measurement.dimension, measurement.dimension, (i, j) => rng.Next(0, 10));
                            Matrix<double> B = Matrix<double>.Build.Dense(measurement.dimension, measurement.dimension, (i, j) => rng.Next(0, 10));

                            watch = System.Diagnostics.Stopwatch.StartNew();
                            Matrix<double> C = multiply.multiply(A, B, measurement.threadsNum);
                            watch.Stop();
                            measurement.time += watch.ElapsedMilliseconds;

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
                        measurement.paralellType = "high";

                        Multiply multiply = new Multiply();

                        if (checkBoxVisualize.Checked)
                        {
                            attemptsNumber = 10;
                            richTextBoxData.Text += $"\n[Research Mode | High-Level]";
                            measurement.isResearch = true;

                        }
                        else
                        {
                            richTextBoxData.Text += $"\n[Vizualization Mode | High-Level]";
                            measurement.isResearch = false;

                        }
                        // loop mutiplying matricies 
                        for (int i = 0; i < attemptsNumber; i++)
                        {

                            // generating matricies (integers for easier checking)
                            Matrix<double> A = Matrix<double>.Build.Dense(measurement.dimension, measurement.dimension, (i, j) => rng.Next(0, 10));
                            Matrix<double> B = Matrix<double>.Build.Dense(measurement.dimension, measurement.dimension, (i, j) => rng.Next(0, 10));

                            watch = System.Diagnostics.Stopwatch.StartNew();
                            Matrix<double> C = multiply.multiply(A, B, measurement.threadsNum);
                            watch.Stop();
                            measurement.time += watch.ElapsedMilliseconds;

                            if (attemptsNumber == 1)
                            {
                                richTextBoxMatrixA.Text = A.ToString();
                                richTextBoxMatrixB.Text = B.ToString();
                                richTextBoxMatrixC.Text = C.ToString();
                            }
                        }

                    }
                    // recieving avg time 
                    measurement.time /= attemptsNumber;

                    if (measurement.isResearch)
                    {

                    }
                    // podanie czasu wykonania

                    DataList.Add(measurement);
                    Data data = new(measurement.time, measurement.dimension, measurement.threadsNum);

                    richTextBoxData.Text += data.ToString();
                
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            richTextBoxData.Text = string.Empty;
        }
    }
}