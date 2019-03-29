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
            
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();
        }

        private void txtTitluCarte_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTitlu_Click(object sender, EventArgs e)
        {
           
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

        private void btnCautare_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbFiltru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            grdCarti.Rows.Clear();
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();
            if (txtValue.Text == "" && cmbFiltru.Text!= "Selecteaza filtrul de cautare")
            {
                MessageBox.Show("Nu ati completat campul!");
                return;
            }
            if (cmbFiltru.Text == "Selecteaza filtrul de cautare")
            {
                string c = "Select* from `Carti`";
                OleDbCommand cmd = new OleDbCommand(c, con);
                OleDbDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    grdCarti.Rows.Add(r["cod"].ToString(), r["titlu"].ToString(), r["autor"].ToString(), r["editura"].ToString(), r["anulPublicarii"].ToString(), r["locatie"].ToString(), r["disponibilitate"].ToString());
                }
                r.Close();
            }
            else
            {
                string c = "Select* from `Carti` where " + cmbFiltru.Text + "='" + txtValue.Text + "'";
                OleDbCommand cmd = new OleDbCommand(c, con);
                OleDbDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    grdCarti.Rows.Add(r["cod"].ToString(), r["titlu"].ToString(), r["autor"].ToString(), r["editura"].ToString(), r["anulPublicarii"].ToString(), r["locatie"].ToString(), r["disponibilitate"].ToString());
                }
                r.Close();
            }
            con.Close();
        }
        public frmModCarte fModCarte = null;
        private void grdCarti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //--------Meniul de modificare--------//
            fModCarte = new frmModCarte();
            fModCarte.MdiParent = this;
            fModCarte.Show();

        }
    }
}
