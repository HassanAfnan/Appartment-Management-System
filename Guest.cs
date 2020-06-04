using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace frameworks
{
    public partial class Guest : MetroFramework.Forms.MetroForm
    {
        public Guest()
        {
            InitializeComponent();
        }

        private void Guest_Load(object sender, EventArgs e)
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
            using (StreamWriter str = new StreamWriter(textBox2.Text + ".txt"))
            {
                str.WriteLine("Flat number : " + textBox1.Text + ",");
                str.WriteLine("Name : " + textBox2.Text + ",");
                str.WriteLine("Nic number : " + textBox3.Text + ",");
                str.WriteLine("Arrival : " + textBox4.Text + ",");
                str.WriteLine("Departure : " + textBox5.Text + ",");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            MessageBox.Show("Data saved successfully");
        }
    }
}
