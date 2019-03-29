namespace atestat
{
    partial class frmIstoric
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
            this.grdCarti = new System.Windows.Forms.DataGridView();
            this.lblIstoric = new System.Windows.Forms.Label();
            this.colCodImp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodCarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCititor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(1329, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 46);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "X";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.grdCarti.Location = new System.Drawing.Point(12, 81);
            this.grdCarti.Name = "grdCarti";
            this.grdCarti.Size = new System.Drawing.Size(1363, 392);
            this.grdCarti.TabIndex = 44;
            // 
            // lblIstoric
            // 
            this.lblIstoric.BackColor = System.Drawing.Color.Transparent;
            this.lblIstoric.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIstoric.ForeColor = System.Drawing.Color.DimGray;
            this.lblIstoric.Location = new System.Drawing.Point(464, 12);
            this.lblIstoric.Name = "lblIstoric";
            this.lblIstoric.Size = new System.Drawing.Size(458, 48);
            this.lblIstoric.TabIndex = 45;
            this.lblIstoric.Text = "ISTORIC IMPRUMUTURI";
            this.lblIstoric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.colTitlu.MinimumWidth = 440;
            this.colTitlu.Name = "colTitlu";
            this.colTitlu.Width = 440;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.MinimumWidth = 250;
            this.colAutor.Name = "colAutor";
            this.colAutor.Width = 250;
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
            // frmIstoric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1386, 485);
            this.ControlBox = false;
            this.Controls.Add(this.lblIstoric);
            this.Controls.Add(this.grdCarti);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmIstoric";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIstoric";
            ((System.ComponentModel.ISupportInitialize)(this.grdCarti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView grdCarti;
        private System.Windows.Forms.Label lblIstoric;
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