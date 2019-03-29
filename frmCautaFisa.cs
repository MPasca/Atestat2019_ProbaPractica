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
    public partial class frmCautaFisa : Form
    {
        public frmCautaFisa()
        {
            InitializeComponent();
        }

        private void frmCautaFisa_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.MdiParent as frmMain).fCautaFisa = null;
            Close();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            //-----------Resetarea listei-----------//
            grdCarti.Rows.Clear();

            //-----------Conexiunea cu baza de date-----------//
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();

            if (txtValue.Text == "")
            {
                MessageBox.Show("Nu ati completat campul!");
                return;
            }
            if(cmbFiltru.Text == "Selecteaza filtrul de cautare")
            {
                MessageBox.Show("Nu ati selectat filtrul de cautare!");
                return;
            }

            //-----------Construirea bazei de date-----------//
            string c = "Select* from carti,cititori,imprumuturi where imprumuturi.codCarte=carti.cod and imprumuturi.codCititor=cititori.id and imprumuturi."+cmbFiltru.Text+"='"+txtValue.Text+"'";
            OleDbCommand cmd = new OleDbCommand(c, con);

            //-----------Executia comenzii-----------//
            OleDbDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                grdCarti.Rows.Add(r["codImprumut"].ToString(), r["codCarte"].ToString(), r["titlu"].ToString(), r["autor"].ToString(), r["codCititor"].ToString(), r["nume"].ToString(), r["prenume"].ToString(), r["data"].ToString(),r["returnare"].ToString());
            }
            r.Close();

            //-----------Resetarea campului de cautare-----------//
            txtValue.Clear();

            //-----------Inchiderea legaturii cu baza de date-----------//
            con.Close();
        }
    }
}
