﻿using System;
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
            (this.MdiParent as frmMain).fAddCarte = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtTitlu.Text == "" || txtAnulPublic.Text=="" || txtAutor.Text=="" || txtEditura.Text=="" || txtLoc.Text=="")
            {
                MessageBox.Show("Atentie! Nu sunt completate toate campurile!");
                return;
            }
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data source=biblioteca.accdb");
            con.Open();
            //string adauga = "INSERT INTO `Carti` ("+
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.MdiParent as frmMain).fAddCititor = null;
            Close();
        }
    }
}
