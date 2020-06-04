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
using Emgu.CV;


namespace frameworks
{
    public partial class UpdateEmployee : MetroFramework.Forms.MetroForm
    {
        VideoCapture capture;
        public UpdateEmployee()
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

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            imageBox1.Visible = false;
            imageBox2.Visible = false;
        }
        string path = "";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect con = new connect("Data Source=(local);Initial Catalog=appartment;Integrated Security=True");
                string query = "select * from emp where Serial =@id";
                command com = new command(query, con);
                com.Parameters.AddWithValue("@id", textBox1.Text);
                con.Open();
                reader rd = com.ExecuteReader();
                while (rd.Read())
                {
                    string name = rd["Gender"].ToString();
                    textBox2.Text = rd[1].ToString();
                    textBox3.Text = rd[2].ToString();
                    textBox4.Text = rd[3].ToString();
                    textBox5.Text = rd[4].ToString();
                    if (name == "male")
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }
                    textBox6.Text = rd[6].ToString();
                    path = rd["Img"].ToString();
                }
                con.Close();
                imageBox2.Visible = true;
                imageBox2.ImageLocation = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string imagelocation = "";
        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                string Male = "male";
                string Female = "female";
                connect con = new connect("Data Source=(local);Initial Catalog=appartment;Integrated Security=True");
                string query = "Update emp set Name = @n,CNIC = @c,Address = @a,Phone = @p,Gender = @g,Designation = @d,Img = @i where Serial = @id";
                command com = new command(query,con);
                com.Parameters.AddWithValue("@id",textBox1.Text);
                com.Parameters.AddWithValue("@n", textBox2.Text);
                com.Parameters.AddWithValue("@c", textBox3.Text);
                com.Parameters.AddWithValue("@a", textBox4.Text);
                com.Parameters.AddWithValue("@p", textBox5.Text);
                if(radioButton1.Checked == true)
                {
                    com.Parameters.AddWithValue("@g",Male);
                }
                else
                {
                    com.Parameters.AddWithValue("@g", Female);
                }
                com.Parameters.AddWithValue("@d", textBox6.Text);
                com.Parameters.AddWithValue("@i", imagelocation);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                textBox6.Text = "";
                MessageBox.Show("Successfully Updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            imageBox1.Visible = true;
            imageBox2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            imageBox2.Image = imageBox1.Image;
            imageBox2.Image.Save(@"C:\Users\User\Desktop\Employee\" + textBox1.Text + ".png");
            imagelocation = @"C:\Users\User\Desktop\Employee\" + textBox1.Text + ".png";
            imageBox1.Visible = false;
            imageBox2.Visible = true;
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
            ClearTextbox(textBox1, textBox2, textBox3, textBox4, textBox5, textBox6);
        }
    }
}
