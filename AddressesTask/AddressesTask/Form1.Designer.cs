namespace AddressesTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            closeButton = new Button();
            richTextBox2 = new RichTextBox();
            solveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(752, 149);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(335, 41);
            numericUpDown1.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(84, 27);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(674, 62);
            numericUpDown2.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(78, 27);
            numericUpDown2.TabIndex = 2;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(430, 101);
            numericUpDown3.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(83, 27);
            numericUpDown3.TabIndex = 3;
            numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.IndianRed;
            closeButton.Location = new Point(281, 309);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(191, 29);
            closeButton.TabIndex = 4;
            closeButton.Text = "Закрыть";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = DockStyle.Top;
            richTextBox2.Location = new Point(0, 149);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(752, 112);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "\n";
            // 
            // solveButton
            // 
            solveButton.BackColor = Color.DarkSeaGreen;
            solveButton.Location = new Point(281, 274);
            solveButton.Name = "solveButton";
            solveButton.Size = new Size(191, 29);
            solveButton.TabIndex = 6;
            solveButton.Text = "Решить";
            solveButton.UseVisualStyleBackColor = false;
            solveButton.Click += solveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 350);
            ControlBox = false;
            Controls.Add(solveButton);
            Controls.Add(richTextBox2);
            Controls.Add(closeButton);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Задача об адресах";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button closeButton;
        protected RichTextBox richTextBox2;
        private Button solveButton;
    }
}
