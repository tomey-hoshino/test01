namespace C__kai
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
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic UI", 12F);
            textBox1.Location = new Point(1, 509);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(635, 29);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 12F);
            button1.Location = new Point(633, 507);
            button1.Name = "button1";
            button1.Size = new Size(144, 31);
            button1.TabIndex = 1;
            button1.Text = "話す";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.Font = new Font("Yu Gothic UI", 16F);
            label1.Location = new Point(258, 305);
            label1.Name = "label1";
            label1.Size = new Size(519, 181);
            label1.TabIndex = 2;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label2.Location = new Point(406, 545);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label3.Location = new Point(273, 545);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 4;
            label3.Text = "C#ちゃんの機嫌値";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Yu Gothic UI", 10F);
            textBox2.Location = new Point(1, 1);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(251, 485);
            textBox2.TabIndex = 5;
            // 
            // pictureBox1
            // 

            pictureBox1.Location = new Point(258, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(519, 301);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 575);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "C#ちゃん";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private PictureBox pictureBox1;
    }
}
