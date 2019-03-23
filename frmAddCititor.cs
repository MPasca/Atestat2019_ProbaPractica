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
    public partial class frmAddCititor : Form
    {
        public frmAddCititor()
        {
            InitializeComponent();
        }

        private void frmAddCititor_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.MdiParent as frmMain).fAddCititor = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtPrenume.Text=="" || txtNume.Text=="" || txtClasa.Text == "")
            {
                MessageBox.Show("Atentie! Nu sunt completate toate campurile!");
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
