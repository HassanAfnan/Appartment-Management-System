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
    public partial class Absview : MetroFramework.Forms.MetroForm
    {
        public Absview()
        {
            InitializeComponent();
        }

        private void Absview_Load(object sender, EventArgs e)
        {
            TreeNode tnode;
        tnode = treeView1.Nodes.Add("ABSTRACT VIEW OF APARTMENT");
            treeView1.Nodes[0].Nodes.Add("1st floor");
            treeView1.Nodes[0].Nodes.Add("2nd floor");
            treeView1.Nodes[0].Nodes.Add("3rd floor");
            treeView1.Nodes[0].Nodes.Add("4th floor");
            treeView1.Nodes[0].Nodes.Add("5th floor");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("101");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("102");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("103");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("104");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("105");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("106");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("201");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("202");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("203");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("204");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("205");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("206");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("301");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("302");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("303");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("304");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("305");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("306");
            treeView1.Nodes[0].Nodes[3].Nodes.Add("401");
            treeView1.Nodes[0].Nodes[3].Nodes.Add("402");
            treeView1.Nodes[0].Nodes[3].Nodes.Add("403");
            treeView1.Nodes[0].Nodes[3].Nodes.Add("404");
            treeView1.Nodes[0].Nodes[3].Nodes.Add("405");
            treeView1.Nodes[0].Nodes[3].Nodes.Add("406");
            treeView1.Nodes[0].Nodes[4].Nodes.Add("501");
            treeView1.Nodes[0].Nodes[4].Nodes.Add("502");
            treeView1.Nodes[0].Nodes[4].Nodes.Add("503");
            treeView1.Nodes[0].Nodes[4].Nodes.Add("504");
            treeView1.Nodes[0].Nodes[4].Nodes.Add("505");
            treeView1.Nodes[0].Nodes[4].Nodes.Add("506");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = treeView1.SelectedNode.Text;
            SearchResident fm = new SearchResident(a);
            fm.ShowDialog();
        }
    }
}
