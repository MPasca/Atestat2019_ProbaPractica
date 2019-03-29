namespace atestat
{
    partial class frmCautaCarte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdCarti = new System.Windows.Forms.DataGridView();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cmbFiltru = new System.Windows.Forms.ComboBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.lblCarte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(1200, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 46);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "X";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(393, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 50);
            this.label1.TabIndex = 29;
            this.label1.Text = "Carti gasite:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grdCarti
            // 
            this.grdCarti.BackgroundColor = System.Drawing.Color.LightGray;
            this.grdCarti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdCarti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCarti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colTitlu,
            this.colAutor,
            this.colEditura,
            this.colAn,
            this.colLoc,
            this.colDisp});
            this.grdCarti.GridColor = System.Drawing.Color.Black;
            this.grdCarti.Location = new System.Drawing.Point(400, 103);
            this.grdCarti.Name = "grdCarti";
            this.grdCarti.Size = new System.Drawing.Size(843, 354);
            this.grdCarti.TabIndex = 43;
            this.grdCarti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCarti_CellContentClick);
            // 
            // colCod
            // 
            this.colCod.HeaderText = "Cod";
            this.colCod.MinimumWidth = 33;
            this.colCod.Name = "colCod";
            this.colCod.ReadOnly = true;
            this.colCod.Width = 33;
            // 
            // colTitlu
            // 
            this.colTitlu.HeaderText = "Titlu";
            this.colTitlu.MinimumWidth = 250;
            this.colTitlu.Name = "colTitlu";
            this.colTitlu.Width = 250;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.MinimumWidth = 150;
            this.colAutor.Name = "colAutor";
            this.colAutor.Width = 150;
            // 
            // colEditura
            // 
            this.colEditura.HeaderText = "Editura";
            this.colEditura.MinimumWidth = 100;
            this.colEditura.Name = "colEditura";
            // 
            // colAn
            // 
            this.colAn.HeaderText = "Anul Publicarii";
            this.colAn.MinimumWidth = 60;
            this.colAn.Name = "colAn";
            this.colAn.Width = 80;
            // 
            // colLoc
            // 
            this.colLoc.HeaderText = "Locatie";
            this.colLoc.MinimumWidth = 105;
            this.colLoc.Name = "colLoc";
            this.colLoc.Width = 105;
            // 
            // colDisp
            // 
            this.colDisp.HeaderText = "Disponibila";
            this.colDisp.MinimumWidth = 80;
            this.colDisp.Name = "colDisp";
            this.colDisp.Width = 80;
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.Color.White;
            this.txtValue.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.ForeColor = System.Drawing.Color.DimGray;
            this.txtValue.Location = new System.Drawing.Point(67, 240);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(255, 30);
            this.txtValue.TabIndex = 47;
            // 
            // cmbFiltru
            // 
            this.cmbFiltru.BackColor = System.Drawing.Color.White;
            this.cmbFiltru.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltru.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFiltru.FormattingEnabled = true;
            this.cmbFiltru.Items.AddRange(new object[] {
            "cod",
            "titlu",
            "autor",
            "editura",
            "locatie"});
            this.cmbFiltru.Location = new System.Drawing.Point(66, 192);
            this.cmbFiltru.Name = "cmbFiltru";
            this.cmbFiltru.Size = new System.Drawing.Size(256, 27);
            this.cmbFiltru.TabIndex = 46;
            this.cmbFiltru.Text = "Selecteaza filtrul de cautare";
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.ForeColor = System.Drawing.Color.DimGray;
            this.btnCauta.Location = new System.Drawing.Point(111, 297);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(166, 39);
            this.btnCauta.TabIndex = 45;
            this.btnCauta.Text = "Cauta!";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // lblCarte
            // 
            this.lblCarte.BackColor = System.Drawing.Color.Transparent;
            this.lblCarte.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarte.ForeColor = System.Drawing.Color.DimGray;
            this.lblCarte.Location = new System.Drawing.Point(64, 103);
            this.lblCarte.Name = "lblCarte";
            this.lblCarte.Size = new System.Drawing.Size(260, 48);
            this.lblCarte.TabIndex = 44;
            this.lblCarte.Text = "CAUTARE CARTE";
            this.lblCarte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCautaCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1261, 485);
            this.ControlBox = false;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.cmbFiltru);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.lblCarte);
            this.Controls.Add(this.grdCarti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCautaCarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCautareCarte";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCautaCarte_FormClosed);
            this.Load += new System.EventHandler(this.frmCautaCarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCarti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdCarti;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cmbFiltru;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label lblCarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisp;
    }
}