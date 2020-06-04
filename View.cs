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
    public partial class View : MetroFramework.Forms.MetroForm
    {
        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appartmentDataSet5.tb' table. You can move, or remove it, as needed.
            this.tbTableAdapter.Fill(this.appartmentDataSet5.tb);
            // TODO: This line of code loads data into the 'appartmentDataSet4.emp' table. You can move, or remove it, as needed.
            this.empTableAdapter.Fill(this.appartmentDataSet4.emp);
            // TODO: This line of code loads data into the 'appartmentDataSet2.parking' table. You can move, or remove it, as needed.
            this.parkingTableAdapter.Fill(this.appartmentDataSet2.parking);
            // TODO: This line of code loads data into the 'appartmentDataSet1.tenant' table. You can move, or remove it, as needed.
            this.tenantTableAdapter.Fill(this.appartmentDataSet1.tenant);
            // TODO: This line of code loads data into the 'appartmentDataSet.resident' table. You can move, or remove it, as needed.
            this.residentTableAdapter.Fill(this.appartmentDataSet.resident);
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = true;
            dataGridView5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = true;
        }
    }
}
