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
            //Schimbare de plan
        }

        public frmModCarte fModCarte = null;
        private void modificareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Schimbare de plan
        }

        public frmModCititor fModCititor = null;
        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Schimbare de plan
        }

        public frmStergeCititor frmStergeCititor = null;
        private void modificareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Schimbare de plan
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        public frmIstoric fIstoric = null;
        private void istoricToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fIstoric == null)
            {
                fIstoric = new frmIstoric();
                fIstoric.MdiParent = this;
                fIstoric.Show();
            }
        }

        public frmAddImprumut fAddImprumut = null;
        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fAddImprumut == null)
            {
                fAddImprumut = new frmAddImprumut();
                fAddImprumut.MdiParent = this;
                fAddImprumut.Show();
            }
        }

        public frmStatus fStatus = null;
        private void istoricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fStatus == null)
            {
                fStatus = new frmStatus();
                fStatus.MdiParent = this;
                fStatus.Show();
            }
        }

        public frmCautaFisa fCautaFisa = null;
        private void cautaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fCautaFisa == null)
            {
                fCautaFisa = new frmCautaFisa();
                fCautaFisa.MdiParent = this;
                fCautaFisa.Show();
            }
        }
    }
}
