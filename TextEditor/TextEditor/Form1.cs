using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        private string _strPrint = "";

        private PageSettings _pageSetting = new();
        private PrintDialog printDialog1 = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Menultem2_Click(object sender, EventArgs e)//テキストの保存
        {
            string filePath;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
            }
            else
            {
                return;
            }
            StreamWriter textFile = new(
                new FileStream(
                    filePath,
                    FileMode.Create)
                );
            textFile.WriteLine(textBox1.Text);
            textFile.Close();
        }

        private void Menultem1_Click(object sender, EventArgs e)//テキストの読み込み
        {
            string openFilePath;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialog1.FileName;
            }
            else
            {
                return;
            }
            textBox1.Clear();

            StreamReader textFile = new(openFilePath);

            textBox1.Text = textFile.ReadToEnd();

            textFile.Close();
        }

        private void Menultem3_Click(object sender, EventArgs e)//アプリの終了
        {
            Application.Exit();
        }

        private void Menulteme6_Click(object sender, EventArgs e)//ファイルの印刷
        {
            try
            {
                printDocument1.DefaultPageSettings = _pageSetting;
                _strPrint = textBox1.Text;

                printDialog1.Document = printDocument1;

                if (printDialog1.ShowDialog() == DialogResult.OK) // Fixed the 'if' statement
                {
                    printDocument1.Print();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー");
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)//印刷するページの設定
        {
            Font font = new Font("MS UI Gothic", 11);

            int numberChars;

            int numberLines;

            string printString;

            StringFormat format = new();

            RectangleF rectSquare = new(
                e.MarginBounds.Left,
                e.MarginBounds.Top,
                e.MarginBounds.Width,
                e.MarginBounds.Height
                );

            SizeF SquareSize = new(
                e.MarginBounds.Width,
                e.MarginBounds.Height - font.GetHeight(e.Graphics)
                );

            e.Graphics.MeasureString(
                _strPrint,
                font,
                SquareSize,
                format,
                out numberChars,
                out numberLines
                );

            printString = _strPrint.Substring(0, numberChars);

            e.Graphics.DrawString(
                printString,
                font,
                Brushes.Black,
                rectSquare,
                format
                );

            if (numberChars < _strPrint.Length)
            {
                _strPrint = _strPrint.Substring(numberChars);
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                _strPrint = textBox1.Text;
            }
        }

        private void Menulteme5_Click(object sender, EventArgs e)//印刷プレビュー
        {
            printDocument1.DefaultPageSettings = _pageSetting;
            _strPrint = textBox1.Text;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void Menulteme4_Click(object sender, EventArgs e)//ページセッティング
        {
            pageSetupDialog1.PageSettings = _pageSetting;
            pageSetupDialog1.ShowDialog();
        }
    }
}
