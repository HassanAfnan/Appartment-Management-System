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
    public partial class SearchResident : MetroFramework.Forms.MetroForm
    {
        public SearchResident()
        {
            InitializeComponent();
        }
        public SearchResident(string s)
        {
            InitializeComponent();
            textBox1.Text = s;
        }
        private void SearchResident_Load(object sender, EventArgs e)
        {                      
                panel1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            main ma = new main();
            ma.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            main ma = new main();
            ma.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearTextbox(textBox11, textBox7, textBox8, textBox9, textBox10);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = "";
            connect con = new connect("Data Source=(local);Initial Catalog=appartment;Integrated Security=True");
            command cmd = new command("select * from tenant where Flatno = @f", con);
            cmd.Parameters.AddWithValue("@f", textBox11.Text);
            con.Open();
            reader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                path = sdr["Img1"].ToString();
                textBox7.Text = sdr[1].ToString();
                textBox8.Text = sdr[2].ToString();
                textBox9.Text = sdr[3].ToString();
                textBox10.Text = sdr[4].ToString();
            }
            con.Close();
            imageBox2.Visible = true;
            imageBox2.ImageLocation = path;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "";
            connect con = new connect("Data Source=(local);Initial Catalog=appartment;Integrated Security=True");
            command cmd = new command("select * from resident where Fno=@fn ", con);
            cmd.Parameters.AddWithValue("@fn", textBox1.Text);
            con.Open();
            reader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                
                textBox2.Text = sdr[1].ToString();
                textBox3.Text = sdr[2].ToString();
                textBox4.Text = sdr[3].ToString();
                textBox5.Text = sdr[4].ToString();
                textBox6.Text = sdr[5].ToString();
                path = sdr["Img"].ToString();
            }
            con.Close();
            imageBox1.Visible = true;
            imageBox1.ImageLocation = path;
        }
        public void ClearTextbox(params TextBox[] textBoxes)
        {
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextbox(textBox1,textBox2,textBox3,textBox4,textBox5,textBox6);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                panel1.Enabled = true;
            }
        }

        private void SearchResident_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
