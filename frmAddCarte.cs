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
    public partial class frmAddCarte : Form
    {
        public frmAddCarte()
        {
            InitializeComponent();
        }

        private void frmAddCarte_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Legatura cu frmMain
            (this.MdiParent as frmMain).fAddCarte = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtTitlu.Text == "" || txtAnulPublic.Text=="" || txtAutor.Text=="" || txtEditura.Text=="" || txtLoc.Text=="")
            {
                //Verifica daca toate campurile sunt completate
                MessageBox.Show("Atentie! Nu sunt completate toate campurile!");
                return;
            }

            //----------Legatura cu baza de date-----------//
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();

            //------------constructia comenzii------------//
            string add = "INSERT INTO `Carti` (`titlu`, `autor`, `editura`, `anulPublicarii`, `locatie`) VALUES ('"+txtTitlu.Text+"','"+txtAutor.Text + "','" + txtEditura.Text + "','" + txtAnulPublic.Text + "','" + txtLoc.Text + "'" + ")";
            OleDbCommand cmd = new OleDbCommand(add, con);

            //-----------Executia comenzii----------------//
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cartea a fost adaugata!");

            //----------Reseteaza campurile---------------//
            txtAnulPublic.Clear();
            txtAutor.Clear();
            txtEditura.Clear();
            txtLoc.Clear();
            txtTitlu.Clear();

            //-----------Inchiderea legaturii cu baza de date-------//
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.MdiParent as frmMain).fAddCarte = null;
            Close();
        }
    }
}
