using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace atestat
{
    public partial class frmCautaCititor : Form
    {
        public frmCautaCititor()
        {
            InitializeComponent();
        }

        private void frmCautaCititor_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.MdiParent as frmMain).fCautaCititor = null;
        }

        private void btnNumeCititor_Click(object sender, EventArgs e)
        {
            if (txtNumeCititor.Text == "")
            {
                MessageBox.Show("Nu este introdus nici un nume!");
                return;
            }
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();
        }

        private void btnClasaCititor_Click(object sender, EventArgs e)
        {
            if (txtClasaCititor.Text == "")
            {
                MessageBox.Show("Nu este introdusa nici o clasa!");
                return; 
            }
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.MdiParent as frmMain).fAddCititor = null;
            Close();
        }
    }
}
