using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;

namespace frameworks
{
    public partial class Security : MetroFramework.Forms.MetroForm
    {
        VideoCapture capture;
        public Security()
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
            imageBox2.Image = capture.QuerySmallFrame();
        }

        private void Security_Load(object sender, EventArgs e)
        {
            imageBox1.Visible = false;
            imageBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imageBox1.Visible = true;
            imageBox2.Visible = true;
            imageBox3.Visible = false;
            imageBox4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
