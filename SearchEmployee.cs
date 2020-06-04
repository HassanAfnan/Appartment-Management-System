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
    public partial class SearchEmployee : MetroFramework.Forms.MetroForm
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void SearchEmployee_Load(object sender, EventArgs e)
        {

        }
        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect con = new connect("Data Source=(local);Initial Catalog=appartment;Integrated Security=True");
                string query = "select * from emp where Serial =@id";
                command com = new command(query, con);
                com.Parameters.AddWithValue("@id",textBox1.Text);
                con.Open();
                reader rd = com.ExecuteReader();
                while (rd.Read())
                {
                    string name = rd["Gender"].ToString();
                    textBox2.Text = rd[1].ToString();
                    textBox3.Text = rd[2].ToString();
                    textBox4.Text = rd[3].ToString();
                    textBox5.Text = rd[4].ToString();
                    if( name == "male")
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            ClearTextbox(textBox1,textBox2,textBox3,textBox4,textBox5,textBox6);
        }
    }
}
