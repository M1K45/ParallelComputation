namespace Parallel_Computation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxSizeMatrix = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxThreadsNum = new TextBox();
            richTextBoxMatrixA = new RichTextBox();
            richTextBoxMatrixB = new RichTextBox();
            richTextBoxMatrixC = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonRun = new Button();
            label7 = new Label();
            richTextBoxData = new RichTextBox();
            checkBoxVisualize = new CheckBox();
            checkBoxLowLevel = new CheckBox();
            SuspendLayout();
            // 
            // textBoxSizeMatrix
            // 
            textBoxSizeMatrix.Location = new Point(12, 28);
            textBoxSizeMatrix.Name = "textBoxSizeMatrix";
            textBoxSizeMatrix.Size = new Size(100, 23);
            textBoxSizeMatrix.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(185, 15);
            label1.TabIndex = 1;
            label1.Text = "Size of matricies (both are square)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "Number of threads";
            // 
            // textBoxThreadsNum
            // 
            textBoxThreadsNum.Location = new Point(12, 90);
            textBoxThreadsNum.Name = "textBoxThreadsNum";
            textBoxThreadsNum.Size = new Size(100, 23);
            textBoxThreadsNum.TabIndex = 3;
            // 
            // richTextBoxMatrixA
            // 
            richTextBoxMatrixA.Location = new Point(19, 179);
            richTextBoxMatrixA.Name = "richTextBoxMatrixA";
            richTextBoxMatrixA.ReadOnly = true;
            richTextBoxMatrixA.Size = new Size(178, 187);
            richTextBoxMatrixA.TabIndex = 4;
            richTextBoxMatrixA.Text = "";
            // 
            // richTextBoxMatrixB
            // 
            richTextBoxMatrixB.Location = new Point(318, 179);
            richTextBoxMatrixB.Name = "richTextBoxMatrixB";
            richTextBoxMatrixB.ReadOnly = true;
            richTextBoxMatrixB.Size = new Size(178, 187);
            richTextBoxMatrixB.TabIndex = 5;
            richTextBoxMatrixB.Text = "";
            // 
            // richTextBoxMatrixC
            // 
            richTextBoxMatrixC.Location = new Point(564, 179);
            richTextBoxMatrixC.Name = "richTextBoxMatrixC";
            richTextBoxMatrixC.ReadOnly = true;
            richTextBoxMatrixC.Size = new Size(190, 187);
            richTextBoxMatrixC.TabIndex = 6;
            richTextBoxMatrixC.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 161);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "Matrix A ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 161);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 8;
            label4.Text = "Matrix B";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(564, 161);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 9;
            label5.Text = "Matrix C = A x B ";
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(12, 119);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(75, 23);
            buttonRun.TabIndex = 10;
            buttonRun.Text = "Run Higl-Level";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 10);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 14;
            label7.Text = "Wyniki:";
            // 
            // richTextBoxData
            // 
            richTextBoxData.Location = new Point(269, 28);
            richTextBoxData.Name = "richTextBoxData";
            richTextBoxData.Size = new Size(485, 96);
            richTextBoxData.TabIndex = 15;
            richTextBoxData.Text = "";
            // 
            // checkBoxVisualize
            // 
            checkBoxVisualize.AutoSize = true;
            checkBoxVisualize.Location = new Point(98, 145);
            checkBoxVisualize.Name = "checkBoxVisualize";
            checkBoxVisualize.Size = new Size(277, 19);
            checkBoxVisualize.TabIndex = 16;
            checkBoxVisualize.Text = "Doing measurements - no vizualization needed ";
            checkBoxVisualize.UseVisualStyleBackColor = true;
            // 
            // checkBoxLowLevel
            // 
            checkBoxLowLevel.AutoSize = true;
            checkBoxLowLevel.Location = new Point(98, 123);
            checkBoxLowLevel.Name = "checkBoxLowLevel";
            checkBoxLowLevel.Size = new Size(232, 19);
            checkBoxLowLevel.TabIndex = 17;
            checkBoxLowLevel.Text = "low-level computation (default is high)";
            checkBoxLowLevel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxLowLevel);
            Controls.Add(checkBoxVisualize);
            Controls.Add(richTextBoxData);
            Controls.Add(label7);
            Controls.Add(buttonRun);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(richTextBoxMatrixC);
            Controls.Add(richTextBoxMatrixB);
            Controls.Add(richTextBoxMatrixA);
            Controls.Add(textBoxThreadsNum);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSizeMatrix);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSizeMatrix;
        private Label label1;
        private Label label2;
        private TextBox textBoxThreadsNum;
        private RichTextBox richTextBoxMatrixA;
        private RichTextBox richTextBoxMatrixB;
        private RichTextBox richTextBoxMatrixC;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonRun;
        private Label label7;
        private RichTextBox richTextBoxData;
        private CheckBox checkBoxVisualize;
        private CheckBox checkBoxLowLevel;
    }
}
