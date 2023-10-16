namespace Montecarlo
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 52);
            label1.Name = "label1";
            label1.Size = new Size(440, 45);
            label1.TabIndex = 0;
            label1.Text = "Simulación de Montecarlo:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(545, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1360, 300);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(207, 318);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 209);
            label2.Name = "label2";
            label2.Size = new Size(293, 32);
            label2.TabIndex = 3;
            label2.Text = "Número de experimentos:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(350, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 39);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(545, 52);
            label3.Name = "label3";
            label3.Size = new Size(604, 40);
            label3.TabIndex = 5;
            label3.Text = "Experimento de funcionamiento del satélite. ";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(545, 482);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.RowTemplate.Height = 41;
            dataGridView2.Size = new Size(457, 189);
            dataGridView2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1954, 699);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private DataGridView dataGridView2;
    }
}