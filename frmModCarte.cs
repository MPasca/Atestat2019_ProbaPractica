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
    public partial class frmModCarte : Form
    {
        public frmModCarte()
        {
            InitializeComponent();
            //-----------Conexiunea cu baza de date-----------//
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();

            if (checkSterge.ToString()=="True")
            {
                if(MessageBox.Show("Sunteti sigur?", "Confirmati", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string del = "Delete from `";
                }
            }
            /*
            string c = "Select* from `Carti` where " +  + "='" +  + "'";
            OleDbCommand cmd = new OleDbCommand(c, con);
            OleDbDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                grdCarti.Rows.Add(r["cod"].ToString(), r["titlu"].ToString(), r["autor"].ToString(), r["editura"].ToString(), r["anulPublicarii"].ToString(), r["locatie"].ToString(), r["disponibilitate"]);
            }
            r.Close();*/
            con.Close();
        }

        private void frmModCarte_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.MdiParent as frmMain).fModCarte = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();

            //----------------Construirea functiei---------//
            string mod = "UPDATE `Carti`";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.MdiParent as frmMain).fModCarte = null;
            Close();
        }

        private void txtTitlu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
