using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace frameworks
{
    public partial class main :MetroFramework.Forms.MetroForm
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SpeakAsync("Welcome to the N E D apartments management system we will provide you a better way of living");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nEWEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rESIDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewResident nr = new NewResident();
            nr.ShowDialog();
        }

        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parking par = new Parking();
            par.ShowDialog();
        }

        private void rESIDENTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateResident ur = new UpdateResident();
            ur.ShowDialog();
        }

        private void pARKINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateParking up = new UpdateParking();
            up.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rESIDENTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SearchResident sr = new SearchResident();
            sr.ShowDialog();
        }

        private void pARKINGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchParking sp = new SearchParking();
            sp.ShowDialog();
        }

        private void bILLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill bl = new Bill();
            bl.ShowDialog();
        }

        private void nOTICEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notice no = new Notice();
            no.ShowDialog();
        }

        private void cOMPLAINSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Complains co = new Complains();
            co.ShowDialog();
        }

        private void sECURITYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Security sc = new Security();
            sc.ShowDialog();
        }

        private void gUESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guest gus = new Guest();
            gus.ShowDialog();
        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.ShowDialog();
        }

        private void dETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Details de = new Details();
            de.ShowDialog();
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View ve = new View();
            ve.ShowDialog();
        }

        private void eMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee el = new Employee();
            el.ShowDialog();
        }

        private void eMPLOYEEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateEmployee up = new UpdateEmployee();
            up.ShowDialog();
        }

        private void eMPLOYEEToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SearchEmployee se = new SearchEmployee();
            se.ShowDialog();
        }

        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mESSAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            message ms = new message();
            ms.ShowDialog();
        }

        private void aBSTRACTVIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Absview ab = new Absview();
            ab.ShowDialog();
        }
    }
}
