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
            (this.MdiParent as frmMain).fAddImprumut = null;
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
            //-----------Conexiunea cu baza de date-----------//
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();

            //-----------Verificarea disponibilitatii cartii-----------//
            string disp = "Select* from `Carti` where cod="+txtCodCarte.Text;
            OleDbCommand cmd = new OleDbCommand(disp,con);
            OleDbDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                if (r["disponibil"].ToString() == "da")
                {
                    //-----------Constructia functiei-----------//
                    string add = "INSERT INTO `Imprumuturi` (`codCarte`, `codCititor`, `data`) VALUES ("+txtCodCarte.Text+","+txtCodCititor.Text+",date())";
                    OleDbCommand cmdAdd = new OleDbCommand(add, con);

                    //-----------Executia comenzii-----------//
                    cmdAdd.ExecuteNonQuery();
                    MessageBox.Show("Imprumutul a fost efectuat!");

                    //-----------Seteaza disponibilitatea cartii-----------//
                    string upd = "Update Carti Set disponibil = 'nu' where cod='" + txtCodCarte.Text + "'";
                }
                else
                {
                    MessageBox.Show("Cartea nu este disponibila!");
                    txtCodCititor.Clear();
                    txtCodCarte.Clear();
                    return;
                }
            }
            r.Close();

            //-----------Resetarea campurilor-----------//
            txtCodCititor.Clear();
            txtCodCarte.Clear();

            //-----------Inchiderea legaturii cu baza de date-----------//
            con.Close();
        }
    }
}
