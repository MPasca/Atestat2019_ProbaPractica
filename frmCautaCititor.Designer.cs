namespace atestat
{
    partial class frmCautaCititor
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
            this.grdCititori = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cmbFiltru = new System.Windows.Forms.ComboBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.lblCititor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCititori)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(1641, 15);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 46);
            this.btnCancel.TabIndex = 23;
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
            this.label1.Location = new System.Drawing.Point(393, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 50);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cititori gasiti:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grdCititori
            // 
            this.grdCititori.BackgroundColor = System.Drawing.Color.LightGray;
            this.grdCititori.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdCititori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCititori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNume,
            this.colPrenume,
            this.colClasa,
            this.colProf,
            this.colDisp});
            this.grdCititori.GridColor = System.Drawing.Color.Black;
            this.grdCititori.Location = new System.Drawing.Point(412, 82);
            this.grdCititori.Margin = new System.Windows.Forms.Padding(4);
            this.grdCititori.Name = "grdCititori";
            this.grdCititori.Size = new System.Drawing.Size(574, 365);
            this.grdCititori.TabIndex = 42;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 40;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 40;
            // 
            // colNume
            // 
            this.colNume.HeaderText = "Nume";
            this.colNume.MinimumWidth = 160;
            this.colNume.Name = "colNume";
            this.colNume.Width = 160;
            // 
            // colPrenume
            // 
            this.colPrenume.HeaderText = "Prenume";
            this.colPrenume.MinimumWidth = 150;
            this.colPrenume.Name = "colPrenume";
            this.colPrenume.Width = 150;
            // 
            // colClasa
            // 
            this.colClasa.HeaderText = "Clasa";
            this.colClasa.MinimumWidth = 80;
            this.colClasa.Name = "colClasa";
            this.colClasa.Width = 80;
            // 
            // colProf
            // 
            this.colProf.HeaderText = "Profesori";
            this.colProf.MinimumWidth = 100;
            this.colProf.Name = "colProf";
            // 
            // colDisp
            // 
            this.colDisp.HeaderText = "Disponibila";
            this.colDisp.Name = "colDisp";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(941, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 46);
            this.button1.TabIndex = 43;
            this.button1.Text = "X";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.Color.White;
            this.txtValue.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.ForeColor = System.Drawing.Color.DimGray;
            this.txtValue.Location = new System.Drawing.Point(84, 219);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(255, 30);
            this.txtValue.TabIndex = 51;
            // 
            // cmbFiltru
            // 
            this.cmbFiltru.BackColor = System.Drawing.Color.White;
            this.cmbFiltru.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltru.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFiltru.FormattingEnabled = true;
            this.cmbFiltru.Items.AddRange(new object[] {
            "id",
            "nume prenume",
            "clasa"});
            this.cmbFiltru.Location = new System.Drawing.Point(83, 171);
            this.cmbFiltru.Name = "cmbFiltru";
            this.cmbFiltru.Size = new System.Drawing.Size(256, 27);
            this.cmbFiltru.TabIndex = 50;
            this.cmbFiltru.Text = "Selecteaza filtrul de cautare";
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.ForeColor = System.Drawing.Color.DimGray;
            this.btnCauta.Location = new System.Drawing.Point(128, 276);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(166, 39);
            this.btnCauta.TabIndex = 49;
            this.btnCauta.Text = "Cauta!";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // lblCititor
            // 
            this.lblCititor.BackColor = System.Drawing.Color.Transparent;
            this.lblCititor.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCititor.ForeColor = System.Drawing.Color.DimGray;
            this.lblCititor.Location = new System.Drawing.Point(81, 82);
            this.lblCititor.Name = "lblCititor";
            this.lblCititor.Size = new System.Drawing.Size(260, 48);
            this.lblCititor.TabIndex = 48;
            this.lblCititor.Text = "CAUTARE CITITOR";
            this.lblCititor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCautaCititor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1002, 464);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.cmbFiltru);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.lblCititor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdCititori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCautaCititor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCautaCititor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCautaCititor_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.grdCititori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdCititori;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProf;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cmbFiltru;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label lblCititor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisp;
    }
}