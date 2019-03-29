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
            
        }

        private void btnClasaCititor_Click(object sender, EventArgs e)
        {
            /*lstId.Items.Clear();
            lstNume.Items.Clear();
            lstPrenume.Items.Clear();
            lstClasa.Items.Clear();
            lstProfesor.Items.Clear();*/
            /*if (cmbFiltru.Text == "Selecteaza filtrul de cautare")
            {
                MessageBox.Show("Nu ati ales filtrul de cautare!");
                return;
            }
            if (txtValue.Text == "")
            {
                MessageBox.Show("Nu ati completat campul!");
                return;
            }
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();
            string c = "Select* from Cititori where "+cmbFiltru.Text+"='" + txtValue.Text+"'";
            OleDbCommand cmd = new OleDbCommand(c, con);
            OleDbDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                
            }
            con.Close();*/
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.MdiParent as frmMain).fAddCititor = null;
            Close();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void lblTitlu_Click(object sender, EventArgs e)
        {

        }

        private void cmbFiltru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            grdCititori.Rows.Clear();
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();
            if (txtValue.Text == "" && cmbFiltru.Text!="Selecteaza filtrul de cautare")
            {
                MessageBox.Show("Nu ati completat campul!");
                return;
            }
            if (cmbFiltru.Text == "Selecteaza filtrul de cautare")
            {
                string c = "Select* from `Cititori`";
                OleDbCommand cmd = new OleDbCommand(c, con);
                OleDbDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    grdCititori.Rows.Add(r["id"].ToString(), r["nume"].ToString(), r["prenume"].ToString(), r["clasa"].ToString(), r["profesor"].ToString());
                }
                r.Close();
            }
            else
            {
                string c = "Select* from `Cititori` where " + cmbFiltru.Text + "='" + txtValue.Text + "'";
                OleDbCommand cmd = new OleDbCommand(c, con);
                OleDbDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    grdCititori.Rows.Add(r["id"].ToString(), r["nume"].ToString(), r["prenume"].ToString(), r["clasa"].ToString(), r["profesor"].ToString());
                }
                r.Close();
            }
            
            con.Close();
        }
    }
}
