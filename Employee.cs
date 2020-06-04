using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using connect = System.Data.SqlClient.SqlConnection;
using command = System.Data.SqlClient.SqlCommand;


namespace frameworks
{
    public partial class Employee : MetroFramework.Forms.MetroForm
    {
        VideoCapture capture;
        public Employee()
        {
            InitializeComponent();
            Run();
        }
        private void Run()
        {
            try
            {
                capture = new VideoCapture();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }
            Application.Idle += ProcessFrame;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            imageBox1.Image = capture.QuerySmallFrame();
        }


        private void Employee_Load(object sender, EventArgs e)
        {
            imageBox1.Visible = false;
            imageBox2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            imageBox1.Visible = true;
            imageBox2.Visible = false;
        }
        string imagelocation = "";
        private void button4_Click(object sender, EventArgs e)
        {
            imageBox2.Image = imageBox1.Image;
            imageBox2.Image.Save(@"C:\Users\User\Desktop\Employee\" + textBox1.Text + ".png");
            imagelocation = @"C:\Users\User\Desktop\Employee\" + textBox1.Text + ".png";
            imageBox1.Visible = false;
            imageBox2.Visible = true;         
        }
        String gender;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
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
            connect con = new connect("Data Source=(local);Initial Catalog=appartment;Integrated Security=True");
            string query = "insert into emp values(@s,@n,@c,@a,@p,@g,@d,@i)";
            command com = new command(query,con);
            con.Open();
            com.Parameters.AddWithValue("@s",textBox1.Text);
            com.Parameters.AddWithValue("@n", textBox2.Text);
            com.Parameters.AddWithValue("@c", textBox3.Text);
            com.Parameters.AddWithValue("@a", textBox4.Text);
            com.Parameters.AddWithValue("@p", textBox5.Text);
            com.Parameters.AddWithValue("@g", gender);
            com.Parameters.AddWithValue("@d", textBox6.Text);
            com.Parameters.AddWithValue("@i", imagelocation);
            com.ExecuteNonQuery();
            con.Close();
            ClearTextbox(textBox1, textBox2,textBox3,textBox4,textBox5,textBox6);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            MessageBox.Show("Successfully inserted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextbox(textBox1,textBox2,textBox3,textBox4,textBox5,textBox6);
        }
    }
}
