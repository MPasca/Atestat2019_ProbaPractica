namespace atestat
{
    partial class frmCautaFisa
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
            this.lblCititor = new System.Windows.Forms.Label();
            this.cmbFiltru = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.grdCarti = new System.Windows.Forms.DataGridView();
            this.colCodImp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodCarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCititor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDecor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCititor
            // 
            this.lblCititor.BackColor = System.Drawing.Color.Transparent;
            this.lblCititor.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCititor.ForeColor = System.Drawing.Color.DimGray;
            this.lblCititor.Location = new System.Drawing.Point(31, 82);
            this.lblCititor.Name = "lblCititor";
            this.lblCititor.Size = new System.Drawing.Size(260, 48);
            this.lblCititor.TabIndex = 49;
            this.lblCititor.Text = "CAUTARE IMPRUMUTURI";
            this.lblCititor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbFiltru
            // 
            this.cmbFiltru.BackColor = System.Drawing.Color.White;
            this.cmbFiltru.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltru.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFiltru.FormattingEnabled = true;
            this.cmbFiltru.Items.AddRange(new object[] {
            "codCarte",
            "codCititor"});
            this.cmbFiltru.Location = new System.Drawing.Point(33, 171);
            this.cmbFiltru.Name = "cmbFiltru";
            this.cmbFiltru.Size = new System.Drawing.Size(256, 27);
            this.cmbFiltru.TabIndex = 51;
            this.cmbFiltru.Text = "Selecteaza filtrul de cautare";
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.Color.White;
            this.txtValue.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.ForeColor = System.Drawing.Color.DimGray;
            this.txtValue.Location = new System.Drawing.Point(34, 219);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(255, 30);
            this.txtValue.TabIndex = 52;
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.ForeColor = System.Drawing.Color.DimGray;
            this.btnCauta.Location = new System.Drawing.Point(78, 276);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(166, 39);
            this.btnCauta.TabIndex = 53;
            this.btnCauta.Text = "Cauta!";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // grdCarti
            // 
            this.grdCarti.BackgroundColor = System.Drawing.Color.LightGray;
            this.grdCarti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdCarti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCarti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodImp,
            this.colCodCarte,
            this.colTitlu,
            this.colAutor,
            this.colCititor,
            this.colNume,
            this.colPrenume,
            this.colData,
            this.colReturn});
            this.grdCarti.GridColor = System.Drawing.Color.Black;
            this.grdCarti.Location = new System.Drawing.Point(322, 82);
            this.grdCarti.Name = "grdCarti";
            this.grdCarti.Size = new System.Drawing.Size(1040, 365);
            this.grdCarti.TabIndex = 54;
            // 
            // colCodImp
            // 
            this.colCodImp.HeaderText = "Cod Imprumut";
            this.colCodImp.MinimumWidth = 90;
            this.colCodImp.Name = "colCodImp";
            this.colCodImp.ReadOnly = true;
            this.colCodImp.Width = 90;
            // 
            // colCodCarte
            // 
            this.colCodCarte.HeaderText = "Cod Carte";
            this.colCodCarte.MinimumWidth = 70;
            this.colCodCarte.Name = "colCodCarte";
            this.colCodCarte.ReadOnly = true;
            this.colCodCarte.Width = 70;
            // 
            // colTitlu
            // 
            this.colTitlu.HeaderText = "Titlu";
            this.colTitlu.MinimumWidth = 300;
            this.colTitlu.Name = "colTitlu";
            this.colTitlu.Width = 300;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.MinimumWidth = 150;
            this.colAutor.Name = "colAutor";
            this.colAutor.Width = 150;
            // 
            // colCititor
            // 
            this.colCititor.HeaderText = "ID Cititor";
            this.colCititor.MinimumWidth = 70;
            this.colCititor.Name = "colCititor";
            this.colCititor.Width = 70;
            // 
            // colNume
            // 
            this.colNume.HeaderText = "Nume Cititor";
            this.colNume.MinimumWidth = 100;
            this.colNume.Name = "colNume";
            // 
            // colPrenume
            // 
            this.colPrenume.HeaderText = "Prenume Cititor";
            this.colPrenume.MinimumWidth = 100;
            this.colPrenume.Name = "colPrenume";
            // 
            // colData
            // 
            this.colData.HeaderText = "Data";
            this.colData.MinimumWidth = 100;
            this.colData.Name = "colData";
            // 
            // colReturn
            // 
            this.colReturn.HeaderText = "Returnare";
            this.colReturn.MinimumWidth = 100;
            this.colReturn.Name = "colReturn";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(1317, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 46);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "X";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDecor
            // 
            this.lblDecor.BackColor = System.Drawing.Color.Transparent;
            this.lblDecor.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecor.ForeColor = System.Drawing.Color.DimGray;
            this.lblDecor.Location = new System.Drawing.Point(317, 29);
            this.lblDecor.Name = "lblDecor";
            this.lblDecor.Size = new System.Drawing.Size(346, 50);
            this.lblDecor.TabIndex = 56;
            this.lblDecor.Text = "Imprumuturi gasite:";
            this.lblDecor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCautaFisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1370, 464);
            this.Controls.Add(this.lblDecor);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grdCarti);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.cmbFiltru);
            this.Controls.Add(this.lblCititor);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCautaFisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCautaFisa";
            this.Load += new System.EventHandler(this.frmCautaFisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCarti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCititor;
        private System.Windows.Forms.ComboBox cmbFiltru;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.DataGridView grdCarti;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDecor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodImp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodCarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCititor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturn;
    }
}