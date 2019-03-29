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
            string c;

            //-----------Reseteaza Lista-----------//
            grdCititori.Rows.Clear();

            //-----------Legatura cu baza de date-----------//
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();
            
            //-----------Verifica daca sunt completate campurile-----------//
            if (txtValue.Text == "" && cmbFiltru.Text!="Selecteaza filtrul de cautare")
            {
                MessageBox.Show("Nu ati completat campul!");
                return;
            }
            if (cmbFiltru.Text == "Selecteaza filtrul de cautare")
            {
                //-----------Construirea si executia comenzii: Afisarea tuturor cititorilor-----------//
                c = "Select* from `Cititori`";
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
                //-----------Construirea functiei-----------//
                if (cmbFiltru.Text == "nume prenume")
                {
                    int i = 2;
                    string[] imp = txtValue.Text.Split(' ');
                    string nume = imp[0],prenume=imp[1];
                    while(imp.Length > i)
                    {
                        prenume += imp[i];
                        i++;
                    }
                    c = "Select* from `Cititori` where nume='" + nume + "' and prenume='" + prenume + "'";
                }
                else
                {
                    c = "Select* from `Cititori` where " + cmbFiltru.Text + "='" + txtValue.Text + "'";
                }

                //-----------Executia functiei-----------//
                OleDbCommand cmd = new OleDbCommand(c, con);
                OleDbDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    grdCititori.Rows.Add(r["id"].ToString(), r["nume"].ToString(), r["prenume"].ToString(), r["clasa"].ToString(), r["profesor"].ToString());
                }
                r.Close();
            }

            //-----------Resetarea campului de cautare-----------//
            txtValue.Clear();

            //-----------Inchiderea legaturii cu baza de date-----------//
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (this.MdiParent as frmMain).fCautaCititor = null;
            Close();
        }
    }
}
