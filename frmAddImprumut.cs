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
    public partial class frmAddImprumut : Form
    {
        public frmAddImprumut()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.MdiParent as frmMain).fAddCititor = null;
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_2(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();
            string disp = "Select disponibilitate from carti where cititori.id='" + txtCodCarte.Text + "'";
            OleDbCommand cmdDisp = new OleDbCommand(disp, con);
            OleDbDataReader r = cmdDisp.ExecuteReader();
            while (r.Read())
            {
                if (r["disponibilitate"].ToString() == "True")
                {
                    string add = "INSERT INTO `Imprumuturi` (`codCarte`, `codCititor`, `data`) VALUES ('" + txtCodCarte.Text + "','" + txtCodCititor.Text + "','" + date.Text + "')";
                    OleDbCommand cmdAdd = new OleDbCommand(add, con);
                    cmdAdd.ExecuteNonQuery();
                }
            }
            r.Close();
            con.Close();
        }
    }
}
