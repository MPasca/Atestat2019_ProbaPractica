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
            this.lblCodCarte = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.txtCodCarte = new System.Windows.Forms.TextBox();
            this.lblTitluCarte = new System.Windows.Forms.Label();
            this.txtTitluCarte = new System.Windows.Forms.TextBox();
            this.btnCodCarte = new System.Windows.Forms.Button();
            this.btnTitluCarte = new System.Windows.Forms.Button();
            this.listCarti = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodCarte
            // 
            this.lblCodCarte.BackColor = System.Drawing.Color.Transparent;
            this.lblCodCarte.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCarte.ForeColor = System.Drawing.Color.Black;
            this.lblCodCarte.Location = new System.Drawing.Point(13, 106);
            this.lblCodCarte.Name = "lblCodCarte";
            this.lblCodCarte.Size = new System.Drawing.Size(92, 44);
            this.lblCodCarte.TabIndex = 2;
            this.lblCodCarte.Text = "Dupa cod:";
            this.lblCodCarte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCodCarte.Click += new System.EventHandler(this.lblCod_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlu.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitlu.Location = new System.Drawing.Point(17, 20);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(253, 48);
            this.lblTitlu.TabIndex = 3;
            this.lblTitlu.Text = "CAUTARE CARTE";
            this.lblTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitlu.Click += new System.EventHandler(this.lblAdauga_Click);
            // 
            // txtCodCarte
            // 
            this.txtCodCarte.BackColor = System.Drawing.Color.LightGray;
            this.txtCodCarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodCarte.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCarte.ForeColor = System.Drawing.Color.Gray;
            this.txtCodCarte.Location = new System.Drawing.Point(103, 106);
            this.txtCodCarte.Multiline = true;
            this.txtCodCarte.Name = "txtCodCarte";
            this.txtCodCarte.Size = new System.Drawing.Size(167, 43);
            this.txtCodCarte.TabIndex = 7;
            this.txtCodCarte.TextChanged += new System.EventHandler(this.txtCodCarte_TextChanged);
            // 
            // lblTitluCarte
            // 
            this.lblTitluCarte.BackColor = System.Drawing.Color.Transparent;
            this.lblTitluCarte.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitluCarte.ForeColor = System.Drawing.Color.Black;
            this.lblTitluCarte.Location = new System.Drawing.Point(13, 226);
            this.lblTitluCarte.Name = "lblTitluCarte";
            this.lblTitluCarte.Size = new System.Drawing.Size(92, 44);
            this.lblTitluCarte.TabIndex = 8;
            this.lblTitluCarte.Text = "Dupa titlu:";
            this.lblTitluCarte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitluCarte.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTitluCarte
            // 
            this.txtTitluCarte.BackColor = System.Drawing.Color.LightGray;
            this.txtTitluCarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitluCarte.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitluCarte.ForeColor = System.Drawing.Color.Gray;
            this.txtTitluCarte.Location = new System.Drawing.Point(103, 226);
            this.txtTitluCarte.Multiline = true;
            this.txtTitluCarte.Name = "txtTitluCarte";
            this.txtTitluCarte.Size = new System.Drawing.Size(167, 43);
            this.txtTitluCarte.TabIndex = 9;
            this.txtTitluCarte.TextChanged += new System.EventHandler(this.txtTitluCarte_TextChanged);
            // 
            // btnCodCarte
            // 
            this.btnCodCarte.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodCarte.ForeColor = System.Drawing.Color.DimGray;
            this.btnCodCarte.Location = new System.Drawing.Point(103, 166);
            this.btnCodCarte.Name = "btnCodCarte";
            this.btnCodCarte.Size = new System.Drawing.Size(166, 39);
            this.btnCodCarte.TabIndex = 10;
            this.btnCodCarte.Text = "Cauta dupa cod";
            this.btnCodCarte.UseVisualStyleBackColor = true;
            this.btnCodCarte.Click += new System.EventHandler(this.btnCod_Click);
            // 
            // btnTitluCarte
            // 
            this.btnTitluCarte.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitluCarte.ForeColor = System.Drawing.Color.DimGray;
            this.btnTitluCarte.Location = new System.Drawing.Point(103, 289);
            this.btnTitluCarte.Name = "btnTitluCarte";
            this.btnTitluCarte.Size = new System.Drawing.Size(166, 39);
            this.btnTitluCarte.TabIndex = 11;
            this.btnTitluCarte.Text = "Cauta dupa titlu";
            this.btnTitluCarte.UseVisualStyleBackColor = true;
            this.btnTitluCarte.Click += new System.EventHandler(this.btnTitlu_Click);
            // 
            // listCarti
            // 
            this.listCarti.BackColor = System.Drawing.Color.LightGray;
            this.listCarti.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCarti.ForeColor = System.Drawing.Color.Black;
            this.listCarti.FormattingEnabled = true;
            this.listCarti.ItemHeight = 23;
            this.listCarti.Location = new System.Drawing.Point(358, 64);
            this.listCarti.Name = "listCarti";
            this.listCarti.Size = new System.Drawing.Size(381, 303);
            this.listCarti.Sorted = true;
            this.listCarti.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(716, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(37, 37);
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
            this.label1.Location = new System.Drawing.Point(353, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 41);
            this.label1.TabIndex = 23;
            this.label1.Text = "Carti gasite:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCautaCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(765, 388);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.listCarti);
            this.Controls.Add(this.btnTitluCarte);
            this.Controls.Add(this.btnCodCarte);
            this.Controls.Add(this.txtTitluCarte);
            this.Controls.Add(this.lblTitluCarte);
            this.Controls.Add(this.txtCodCarte);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblCodCarte);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCautaCarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCautareCarte";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCautaCarte_FormClosed);
            this.Load += new System.EventHandler(this.frmCautaCarte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodCarte;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.TextBox txtCodCarte;
        private System.Windows.Forms.Label lblTitluCarte;
        private System.Windows.Forms.TextBox txtTitluCarte;
        private System.Windows.Forms.Button btnCodCarte;
        private System.Windows.Forms.Button btnTitluCarte;
        private System.Windows.Forms.ListBox listCarti;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
    }
}