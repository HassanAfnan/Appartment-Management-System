using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using connect = System.Data.SqlClient.SqlConnection;
using command = System.Data.SqlClient.SqlCommand;
using reader = System.Data.SqlClient.SqlDataReader;


namespace frameworks
{
    public partial class SearchParking : MetroFramework.Forms.MetroForm
    {
        public SearchParking()
        {
            InitializeComponent();
        }

        private void SearchParking_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            main ma = new main();
            ma.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextbox(textBox1, textBox2, textBox3, textBox4, textBox5);
        }
        public void ClearTextbox(params TextBox[] textBoxes)
        {
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect con = new connect("Data Source=(local);Initial Catalog=appartment;Integrated Security=True");
            command cmd = new command("select * from parking where Fl=@f ", con);
            cmd.Parameters.AddWithValue("@f", textBox1.Text);
            con.Open();
            reader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                textBox2.Text = sdr[1].ToString();
                textBox3.Text = sdr[2].ToString();
                textBox4.Text = sdr[3].ToString();
                textBox5.Text = sdr[4].ToString();
            }
            con.Close();

        }
    }
}
