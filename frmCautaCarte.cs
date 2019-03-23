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
    public partial class frmCautaCarte : Form
    {
        public frmCautaCarte()
        {
            InitializeComponent();
        }

        private void frmCautaCarte_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.MdiParent as frmMain).fCautaCarte = null;
        }

        private void lblAdauga_Click(object sender, EventArgs e)
        {

        }

        private void frmCautaCarte_Load(object sender, EventArgs e)
        {

        }

        private void btnCod_Click(object sender, EventArgs e)
        {
            if (txtCodCarte.Text == "")
            {
                MessageBox.Show("Nu este introdus nici un cod!");
                return;
            }
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();
        }

        private void txtTitluCarte_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTitlu_Click(object sender, EventArgs e)
        {
            if (txtTitluCarte.Text == "")
            {
                MessageBox.Show("Nu este introdus nici un titlu!");
                return;
            }
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();
        }

        private void txtCodCarte_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCod_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.MdiParent as frmMain).fAddCititor = null;
            Close();
        }
    }
}
