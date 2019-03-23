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
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnClasaCititor = new System.Windows.Forms.Button();
            this.btnNumeCititor = new System.Windows.Forms.Button();
            this.txtClasaCititor = new System.Windows.Forms.TextBox();
            this.lblClasaCititor = new System.Windows.Forms.Label();
            this.txtNumeCititor = new System.Windows.Forms.TextBox();
            this.lblNumeCititor = new System.Windows.Forms.Label();
            this.listCititori = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlu.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitlu.Location = new System.Drawing.Point(17, 20);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(260, 48);
            this.lblTitlu.TabIndex = 4;
            this.lblTitlu.Text = "CAUTARE CITITOR";
            this.lblTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClasaCititor
            // 
            this.btnClasaCititor.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasaCititor.ForeColor = System.Drawing.Color.DimGray;
            this.btnClasaCititor.Location = new System.Drawing.Point(103, 289);
            this.btnClasaCititor.Name = "btnClasaCititor";
            this.btnClasaCititor.Size = new System.Drawing.Size(166, 39);
            this.btnClasaCititor.TabIndex = 17;
            this.btnClasaCititor.Text = "Cauta dupa clasa";
            this.btnClasaCititor.UseVisualStyleBackColor = true;
            this.btnClasaCititor.Click += new System.EventHandler(this.btnClasaCititor_Click);
            // 
            // btnNumeCititor
            // 
            this.btnNumeCititor.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumeCititor.ForeColor = System.Drawing.Color.DimGray;
            this.btnNumeCititor.Location = new System.Drawing.Point(103, 166);
            this.btnNumeCititor.Name = "btnNumeCititor";
            this.btnNumeCititor.Size = new System.Drawing.Size(166, 39);
            this.btnNumeCititor.TabIndex = 16;
            this.btnNumeCititor.Text = "Cauta dupa nume";
            this.btnNumeCititor.UseVisualStyleBackColor = true;
            this.btnNumeCititor.Click += new System.EventHandler(this.btnNumeCititor_Click);
            // 
            // txtClasaCititor
            // 
            this.txtClasaCititor.BackColor = System.Drawing.Color.LightGray;
            this.txtClasaCititor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClasaCititor.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClasaCititor.ForeColor = System.Drawing.Color.Gray;
            this.txtClasaCititor.Location = new System.Drawing.Point(103, 226);
            this.txtClasaCititor.Multiline = true;
            this.txtClasaCititor.Name = "txtClasaCititor";
            this.txtClasaCititor.Size = new System.Drawing.Size(166, 43);
            this.txtClasaCititor.TabIndex = 15;
            // 
            // lblClasaCititor
            // 
            this.lblClasaCititor.BackColor = System.Drawing.Color.Transparent;
            this.lblClasaCititor.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasaCititor.ForeColor = System.Drawing.Color.Black;
            this.lblClasaCititor.Location = new System.Drawing.Point(17, 226);
            this.lblClasaCititor.Name = "lblClasaCititor";
            this.lblClasaCititor.Size = new System.Drawing.Size(92, 44);
            this.lblClasaCititor.TabIndex = 14;
            this.lblClasaCititor.Text = "Dupa clasa:";
            this.lblClasaCititor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumeCititor
            // 
            this.txtNumeCititor.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeCititor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeCititor.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeCititor.ForeColor = System.Drawing.Color.Gray;
            this.txtNumeCititor.Location = new System.Drawing.Point(103, 106);
            this.txtNumeCititor.Multiline = true;
            this.txtNumeCititor.Name = "txtNumeCititor";
            this.txtNumeCititor.Size = new System.Drawing.Size(166, 43);
            this.txtNumeCititor.TabIndex = 13;
            // 
            // lblNumeCititor
            // 
            this.lblNumeCititor.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeCititor.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeCititor.ForeColor = System.Drawing.Color.Black;
            this.lblNumeCititor.Location = new System.Drawing.Point(17, 106);
            this.lblNumeCititor.Name = "lblNumeCititor";
            this.lblNumeCititor.Size = new System.Drawing.Size(92, 44);
            this.lblNumeCititor.TabIndex = 12;
            this.lblNumeCititor.Text = "Dupa nume:";
            this.lblNumeCititor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listCititori
            // 
            this.listCititori.BackColor = System.Drawing.Color.LightGray;
            this.listCititori.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCititori.ForeColor = System.Drawing.Color.Black;
            this.listCititori.FormattingEnabled = true;
            this.listCititori.ItemHeight = 23;
            this.listCititori.Location = new System.Drawing.Point(358, 64);
            this.listCititori.Name = "listCititori";
            this.listCititori.Size = new System.Drawing.Size(381, 303);
            this.listCititori.Sorted = true;
            this.listCititori.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(716, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(37, 37);
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
            this.label1.Location = new System.Drawing.Point(353, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 41);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cititori gasiti:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCautaCititor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(765, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.listCititori);
            this.Controls.Add(this.btnClasaCititor);
            this.Controls.Add(this.btnNumeCititor);
            this.Controls.Add(this.txtClasaCititor);
            this.Controls.Add(this.lblClasaCititor);
            this.Controls.Add(this.txtNumeCititor);
            this.Controls.Add(this.lblNumeCititor);
            this.Controls.Add(this.lblTitlu);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCautaCititor";
            this.Text = "frmCautaCititor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCautaCititor_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnClasaCititor;
        private System.Windows.Forms.Button btnNumeCititor;
        private System.Windows.Forms.TextBox txtClasaCititor;
        private System.Windows.Forms.Label lblClasaCititor;
        private System.Windows.Forms.TextBox txtNumeCititor;
        private System.Windows.Forms.Label lblNumeCititor;
        private System.Windows.Forms.ListBox listCititori;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
    }
}