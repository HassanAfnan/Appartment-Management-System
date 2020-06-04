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



namespace frameworks
{
    public partial class UpdateParking : MetroFramework.Forms.MetroForm
    {
        public UpdateParking()
        {
            InitializeComponent();
        }

        private void UpdateParking_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect con = new connect("Data Source=(local);Initial Catalog=appartment;Integrated Security=True");
            string query = "update parking set Model=@m,Name=@n,Pn=@p,plno=@pl where Fl=@f";
            command com = new command(query, con);
            com.Parameters.AddWithValue("@f", textBox1.Text);
            com.Parameters.AddWithValue("@m", textBox2.Text);
            com.Parameters.AddWithValue("@n", textBox3.Text);
            com.Parameters.AddWithValue("@p", textBox4.Text);
            com.Parameters.AddWithValue("@pl", textBox5.Text);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            MessageBox.Show("Successfully updated");
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
    }
}
