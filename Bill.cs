using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace frameworks
{
    public partial class Bill : MetroFramework.Forms.MetroForm
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox4.Text = "Bill paid";
                radioButton2.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=appartment;Integrated Security=True");
            string query = "insert into tb values(@f,@n,@a,@s,@d)";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@f", textBox1.Text);
            com.Parameters.AddWithValue("@n", textBox2.Text);
            com.Parameters.AddWithValue("@a", textBox3.Text);
            com.Parameters.AddWithValue("@s", textBox4.Text);
            com.Parameters.AddWithValue("@d", DateTime.Now.ToShortDateString());
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            radioButton2.Checked = false;
            MessageBox.Show("Successfully Saved");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("NED APPARTMENTS", new Font("Times New Roman", 48, FontStyle.Bold), Brushes.Blue, new Point(85, 15));
            e.Graphics.DrawString(label4.Text, new Font("Times New Roman", 48, FontStyle.Bold), Brushes.Red, new Point(0, 50));
            e.Graphics.DrawString("Flat Number : " + textBox1.Text, new Font("Times New Roman", 28, FontStyle.Regular), Brushes.Purple, new Point(25, 110));
            e.Graphics.DrawString("Date : " + DateTime.Now, new Font("Times New Roman", 28), Brushes.Purple, new Point(25, 160));
            e.Graphics.DrawString(label4.Text, new Font("Times New Roman", 48, FontStyle.Bold), Brushes.Red, new Point(0, 180));
            e.Graphics.DrawString("Maintainance Bill ", new Font("Times New Roman", 36, FontStyle.Bold), Brushes.Red, new Point(200, 250));
            e.Graphics.DrawString(label4.Text, new Font("Times New Roman", 48, FontStyle.Bold), Brushes.Red, new Point(0, 280));
            e.Graphics.DrawString("Resident Name : " + textBox2.Text, new Font("Times New Roman", 28, FontStyle.Regular), Brushes.Black, new Point(25, 350));
            e.Graphics.DrawString("Amount : " + textBox3.Text, new Font("Times New Roman", 28, FontStyle.Regular), Brushes.Black, new Point(25, 420));
            e.Graphics.DrawString("Status : " + textBox4.Text, new Font("Times New Roman", 28, FontStyle.Regular), Brushes.Black, new Point(25, 490));
            e.Graphics.DrawString(label4.Text, new Font("Times New Roman", 48, FontStyle.Bold), Brushes.Red, new Point(0, 580));
            e.Graphics.DrawString("Total : " + textBox3.Text + " /=", new Font("Times New Roman", 28, FontStyle.Regular), Brushes.Black, new Point(590, 670));
            e.Graphics.DrawString(label4.Text, new Font("Times New Roman", 48, FontStyle.Bold), Brushes.Red, new Point(0, 700));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearTextbox(textBox1, textBox2, textBox3, textBox4);
        }
        public void ClearTextbox(params TextBox[] textBoxes)
        {
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Clear();
            }
        }
    }
}
