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
using adapter = System.Data.SqlClient.SqlDataAdapter;
namespace frameworks
{
    public partial class Login :MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect con = new connect("Data Source=(local);Initial Catalog=login;Integrated Security=True");
            string query = "select name from tc where name ='" + textBox1.Text + "' and pass = '" + textBox2.Text + "'";
            adapter adp = new adapter(query, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count >= 1)
            {
                main ma = new main();
                ma.ShowDialog();
            }
            else
            {
                MessageBox.Show("INVALID USERID OR PASSWORD");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.ShowDialog();
        }
    }
}
