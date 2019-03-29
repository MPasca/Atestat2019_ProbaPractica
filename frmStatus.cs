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
    public partial class frmStatus : Form
    {
        public frmStatus()
        {
            InitializeComponent();
            //-----------Conexiunea cu baza de date-----------//
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();

            //-----------Construirea functiei-----------//
            string c = "Select* from carti,cititori,imprumuturi where imprumuturi.codCarte=carti.cod and imprumuturi.codCititor=cititori.id and carti.disponibil='nu'";
            OleDbCommand cmd = new OleDbCommand(c, con);
            OleDbDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                grdCarti.Rows.Add(r["codImprumut"].ToString(), r["codCarte"].ToString(), r["titlu"].ToString(), r["autor"].ToString(), r["codCititor"].ToString(), r["nume"].ToString(), r["prenume"].ToString(), r["data"].ToString());
            }
            r.Close();

            //-----------Inchiderea conexiunii cu baza de date-----------//
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.MdiParent as frmMain).fStatus = null;
            Close();
        }
    }
}
