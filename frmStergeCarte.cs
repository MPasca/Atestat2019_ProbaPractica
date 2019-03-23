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
    public partial class frmStergeCarte : Form
    {
        public frmStergeCarte()
        {
            InitializeComponent();
        }

        private void frmStergeCarte_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.MdiParent as frmMain).fStergeCarte = null;
        }

        private void btnCodCarte_Click(object sender, EventArgs e)
        {
            if (txtCodCarte.Text == "")
            {
                MessageBox.Show("Nu ati introdus nici un cod!");
                return;
            }
            if(MessageBox.Show("Sunteti sigur ca vreti sa stergeti cartea?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No){
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
