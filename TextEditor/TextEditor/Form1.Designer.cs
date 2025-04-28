namespace TextEditor
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
            menuStrip1 = new MenuStrip();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            Menultem1 = new ToolStripMenuItem();
            Menultem2 = new ToolStripMenuItem();
            Menultem3 = new ToolStripMenuItem();
            印刷ToolStripMenuItem = new ToolStripMenuItem();
            Menulteme4 = new ToolStripMenuItem();
            Menulteme5 = new ToolStripMenuItem();
            Menulteme6 = new ToolStripMenuItem();
            textBox1 = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            pageSetupDialog1 = new PageSetupDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem, 印刷ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(684, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "ファイル";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Menultem1, Menultem2, Menultem3 });
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(53, 20);
            ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // Menultem1
            // 
            Menultem1.Name = "Menultem1";
            Menultem1.Size = new Size(98, 22);
            Menultem1.Text = "開く";
            Menultem1.Click += Menultem1_Click;
            // 
            // Menultem2
            // 
            Menultem2.Name = "Menultem2";
            Menultem2.Size = new Size(98, 22);
            Menultem2.Text = "保存";
            Menultem2.Click += Menultem2_Click;
            // 
            // Menultem3
            // 
            Menultem3.Name = "Menultem3";
            Menultem3.Size = new Size(98, 22);
            Menultem3.Text = "終了";
            Menultem3.Click += Menultem3_Click;
            // 
            // 印刷ToolStripMenuItem
            // 
            印刷ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Menulteme4, Menulteme5, Menulteme6 });
            印刷ToolStripMenuItem.Name = "印刷ToolStripMenuItem";
            印刷ToolStripMenuItem.Size = new Size(43, 20);
            印刷ToolStripMenuItem.Text = "印刷";
            // 
            // Menulteme4
            // 
            Menulteme4.Name = "Menulteme4";
            Menulteme4.Size = new Size(180, 22);
            Menulteme4.Text = "ページ設定";
            Menulteme4.Click += Menulteme4_Click;
            // 
            // Menulteme5
            // 
            Menulteme5.Name = "Menulteme5";
            Menulteme5.Size = new Size(180, 22);
            Menulteme5.Text = "印刷プレビュー";
            Menulteme5.Click += Menulteme5_Click;
            // 
            // Menulteme6
            // 
            Menulteme6.Name = "Menulteme6";
            Menulteme6.Size = new Size(180, 22);
            Menulteme6.Text = "印刷";
            Menulteme6.Click += Menulteme6_Click;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Yu Gothic UI", 11F);
            textBox1.Location = new Point(0, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(684, 437);
            textBox1.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "テキストファイル(*.txt)|*.txt";
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "テキストファイル(*.txt)|*.txt";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "テキストエディター";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem Menultem1;
        private ToolStripMenuItem Menultem2;
        private ToolStripMenuItem Menultem3;
        private TextBox textBox1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem 印刷ToolStripMenuItem;
        private ToolStripMenuItem Menulteme4;
        private ToolStripMenuItem Menulteme5;
        private ToolStripMenuItem Menulteme6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PageSetupDialog pageSetupDialog1;
    }
}
