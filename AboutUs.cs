using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System;
using System.IO;

namespace frameworks
{
    public partial class AboutUs : MetroFramework.Forms.MetroForm
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            string filetext = File.ReadAllText(@"C:\Users\User\Desktop\oop Class work\amf.txt");
            richTextBox1.Text = filetext;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
