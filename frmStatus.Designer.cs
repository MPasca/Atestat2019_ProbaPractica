namespace atestat
{
    partial class frmStatus
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
            this.lblDec = new System.Windows.Forms.Label();
            this.grdCarti = new System.Windows.Forms.DataGridView();
            this.colCodImp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodCarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCititor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDec
            // 
            this.lblDec.BackColor = System.Drawing.Color.Transparent;
            this.lblDec.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDec.ForeColor = System.Drawing.Color.DimGray;
            this.lblDec.Location = new System.Drawing.Point(380, 12);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(416, 48);
            this.lblDec.TabIndex = 46;
            this.lblDec.Text = "IMPRUMUTURI IN DESFASURARE";
            this.lblDec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.colData});
            this.grdCarti.GridColor = System.Drawing.Color.Black;
            this.grdCarti.Location = new System.Drawing.Point(10, 81);
            this.grdCarti.Name = "grdCarti";
            this.grdCarti.Size = new System.Drawing.Size(1157, 392);
            this.grdCarti.TabIndex = 47;
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
            this.colTitlu.MinimumWidth = 450;
            this.colTitlu.Name = "colTitlu";
            this.colTitlu.Width = 450;
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
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(1128, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 46);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "X";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1185, 485);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grdCarti);
            this.Controls.Add(this.lblDec);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStatus";
            ((System.ComponentModel.ISupportInitialize)(this.grdCarti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.DataGridView grdCarti;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodImp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodCarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCititor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.Button btnCancel;
    }
}