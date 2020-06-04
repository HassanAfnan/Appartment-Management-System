using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frameworks
{
    public partial class Details : MetroFramework.Forms.MetroForm
    {
        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            crystalReportViewer4.Visible = false;
            crystalReportViewer5.Visible = false;
            crystalReportViewer6.Visible = false;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer4.Visible = true;
            crystalReportViewer5.Visible = false;
            crystalReportViewer6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crystalReportViewer4.Visible = false;
            crystalReportViewer5.Visible = true;
            crystalReportViewer6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            crystalReportViewer4.Visible = false;
            crystalReportViewer5.Visible = false;
            crystalReportViewer6.Visible = true;
        }

        private void Details_Load_1(object sender, EventArgs e)
        {
            crystalReportViewer4.Visible = false;
            crystalReportViewer5.Visible = false;
            crystalReportViewer6.Visible = false;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;

        }

        private void crystalReportViewer4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            crystalReportViewer4.Visible = true;
            crystalReportViewer5.Visible = false;
            crystalReportViewer6.Visible = false;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            crystalReportViewer4.Visible = false;
            crystalReportViewer5.Visible = true;
            crystalReportViewer6.Visible = false;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            crystalReportViewer4.Visible = false;
            crystalReportViewer5.Visible = false;
            crystalReportViewer6.Visible = true;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = false;
        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            crystalReportViewer4.Visible = false;
            crystalReportViewer5.Visible = false;
            crystalReportViewer6.Visible = false;
            crystalReportViewer1.Visible = true;
            crystalReportViewer2.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            crystalReportViewer4.Visible = false;
            crystalReportViewer5.Visible = false;
            crystalReportViewer6.Visible = false;
            crystalReportViewer1.Visible = false;
            crystalReportViewer2.Visible = true;
        }
    }
}
