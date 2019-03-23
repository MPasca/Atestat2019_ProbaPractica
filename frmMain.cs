using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atestat
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public frmAddCititor fAddCititor = null;
        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fAddCititor == null)
            {
                fAddCititor = new frmAddCititor();
                fAddCititor.MdiParent = this;
                fAddCititor.Show();
            }
        }
        public frmAddCarte fAddCarte = null;
        private void adaugareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(fAddCarte == null)
            {
                fAddCarte = new frmAddCarte();
                fAddCarte.MdiParent = this;
                fAddCarte.Show();
            }
        }
        public frmCautaCititor fCautaCititor = null;
        private void cautareFisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fCautaCititor == null)
            {
                fCautaCititor = new frmCautaCititor();
                fCautaCititor.MdiParent = this;
                fCautaCititor.Show();
            }
        }
        public frmCautaCarte fCautaCarte = null;
        private void cautareCarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fCautaCarte == null)
            {
                fCautaCarte = new frmCautaCarte();
                fCautaCarte.MdiParent = this;
                fCautaCarte.Show();
            }
        }

        public frmStergeCarte fStergeCarte = null; 
        private void stergereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(fStergeCarte == null)
            {
                fStergeCarte = new frmStergeCarte();
                fStergeCarte.MdiParent = this;
                fStergeCarte.Show();
            }
        }

        public frmModCarte fModCarte = null;
        private void modificareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(fModCarte == null)
            {
                fModCarte = new frmModCarte();
                fModCarte.MdiParent = this;
                fModCarte.Show();
            }
        }

        public frmModCititor fModCititor = null;
        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fModCititor == null)
            {
                fModCititor = new frmModCititor();
                fModCititor.MdiParent = this;
                fModCititor.Show();
            }
        }

        public frmStergeCititor fStergeCititor = null;
        private void modificareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fStergeCititor == null)
            {
                fStergeCititor = new frmStergeCititor();
                fStergeCititor.MdiParent = this;
                fStergeCititor.Show();
            }
        }
    }
}
