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
    public partial class frmStergeCititor : Form
    {
        public frmStergeCititor()
        {
            InitializeComponent();
        }

        private void frmStergeCititor_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.MdiParent as frmMain).fStergeCititor = null;
        }

        private void btnCNP_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == "")
            {
                MessageBox.Show("Atentie! Nu ati introdus nici un cod!");
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
