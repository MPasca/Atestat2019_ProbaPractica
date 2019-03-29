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
            if(txtPrenume.Text=="" || txtNume.Text=="" || txtClasa.Text == "" || cmbProf.Text=="")
            {
                MessageBox.Show("Atentie! Nu sunt completate toate campurile!");
                return;
            }
            //--------Legatura cu baza de date----------//
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();

            //-------------Constructia comenzii--------//
            string add = "INSERT INTO `Cititori` (`nume`, `prenume`, `clasa`, `profesor`) VALUES ('" + txtNume.Text + "','" + txtPrenume.Text + "','" + txtClasa.Text + "','" + cmbProf.Text + "')";
            OleDbCommand cmd = new OleDbCommand(add, con);

            //------------Executia comenzii-----------//
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cititorul a fost adaugat!");

            //------------Resetarea campurilor---------//
            txtClasa.Clear();
            txtNume.Clear();
            txtPrenume.Clear();

            //----------Inchiderea legaturii cu baza de date------//
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.MdiParent as frmMain).fAddCititor = null;
            Close();
        }
    }
}
