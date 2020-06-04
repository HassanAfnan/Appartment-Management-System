using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frameworks
{
    public partial class Notice : MetroFramework.Forms.MetroForm
    {
        public Notice()
        {
            InitializeComponent();
        }

        private void Notice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("NED APPARTMENTS", new Font("Times New Roman", 48, FontStyle.Bold), Brushes.Blue, new Point(85, 15));
            e.Graphics.DrawString(label4.Text, new Font("Times New Roman", 48, FontStyle.Bold), Brushes.Red, new Point(0, 50));
            e.Graphics.DrawString("Date : " + DateTime.Now, new Font("Times New Roman", 28), Brushes.Purple, new Point(25, 110));
            e.Graphics.DrawString(label4.Text, new Font("Times New Roman", 48, FontStyle.Bold), Brushes.Red, new Point(0, 130));
            e.Graphics.DrawString(" Notice ", new Font("Times New Roman", 36, FontStyle.Bold), Brushes.Red, new Point(300, 180));
            e.Graphics.DrawString(label4.Text, new Font("Times New Roman", 48, FontStyle.Bold), Brushes.Red, new Point(0, 200));
            e.Graphics.DrawString("", new Font("Times New Roman", 28, FontStyle.Bold), Brushes.Black, new Point(0, 250));
            e.Graphics.DrawString(textBox1.Text + " : ", new Font("Times New Roman", 28, FontStyle.Bold), Brushes.Black, new Point(0, 290));
            e.Graphics.DrawString("", new Font("Times New Roman", 28, FontStyle.Bold), Brushes.Black, new Point(0, 320));
            e.Graphics.DrawString(textBox3.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Regular), Brushes.Black, new Point(0, 340));
            e.Graphics.DrawString(textBox2.Text, new Font("Vladimir Script", 36, FontStyle.Bold), Brushes.Black, new Point(500, 750));
            e.Graphics.DrawString(label4.Text, new Font("Arial", 36, FontStyle.Bold), Brushes.Red, new Point(500, 800));
            e.Graphics.DrawString("( Signature )", new Font("Arial", 28, FontStyle.Bold), Brushes.Red, new Point(500, 850));
            e.Graphics.DrawString(label4.Text, new Font("Times New Roman", 48, FontStyle.Bold), Brushes.Red, new Point(0, 900));
        }
    }
}
