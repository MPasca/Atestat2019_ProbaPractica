namespace atestat
{
    partial class frmStergeCarte
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
            this.btnCodCarte = new System.Windows.Forms.Button();
            this.txtCodCarte = new System.Windows.Forms.TextBox();
            this.lblStergeCititor = new System.Windows.Forms.Label();
            this.lblCodCarte = new System.Windows.Forms.Label();
            this.lblInfoCarte = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCodCarte
            // 
            this.btnCodCarte.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodCarte.ForeColor = System.Drawing.Color.DimGray;
            this.btnCodCarte.Location = new System.Drawing.Point(189, 159);
            this.btnCodCarte.Name = "btnCodCarte";
            this.btnCodCarte.Size = new System.Drawing.Size(166, 39);
            this.btnCodCarte.TabIndex = 17;
            this.btnCodCarte.Text = "Sterge";
            this.btnCodCarte.UseVisualStyleBackColor = true;
            this.btnCodCarte.Click += new System.EventHandler(this.btnCodCarte_Click);
            // 
            // txtCodCarte
            // 
            this.txtCodCarte.BackColor = System.Drawing.Color.LightGray;
            this.txtCodCarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodCarte.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCarte.ForeColor = System.Drawing.Color.Gray;
            this.txtCodCarte.Location = new System.Drawing.Point(121, 100);
            this.txtCodCarte.Multiline = true;
            this.txtCodCarte.Name = "txtCodCarte";
            this.txtCodCarte.Size = new System.Drawing.Size(343, 43);
            this.txtCodCarte.TabIndex = 14;
            // 
            // lblStergeCititor
            // 
            this.lblStergeCititor.BackColor = System.Drawing.Color.Transparent;
            this.lblStergeCititor.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStergeCititor.ForeColor = System.Drawing.Color.DimGray;
            this.lblStergeCititor.Location = new System.Drawing.Point(144, 18);
            this.lblStergeCititor.Name = "lblStergeCititor";
            this.lblStergeCititor.Size = new System.Drawing.Size(257, 44);
            this.lblStergeCititor.TabIndex = 13;
            this.lblStergeCititor.Text = "STERGERE CARTE";
            this.lblStergeCititor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodCarte
            // 
            this.lblCodCarte.BackColor = System.Drawing.Color.Transparent;
            this.lblCodCarte.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCarte.ForeColor = System.Drawing.Color.Black;
            this.lblCodCarte.Location = new System.Drawing.Point(32, 99);
            this.lblCodCarte.Name = "lblCodCarte";
            this.lblCodCarte.Size = new System.Drawing.Size(92, 44);
            this.lblCodCarte.TabIndex = 12;
            this.lblCodCarte.Text = "Cod:";
            this.lblCodCarte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoCarte
            // 
            this.lblInfoCarte.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoCarte.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCarte.ForeColor = System.Drawing.Color.Black;
            this.lblInfoCarte.Location = new System.Drawing.Point(38, 235);
            this.lblInfoCarte.Name = "lblInfoCarte";
            this.lblInfoCarte.Size = new System.Drawing.Size(439, 61);
            this.lblInfoCarte.TabIndex = 18;
            this.lblInfoCarte.Text = "Aici e label";
            this.lblInfoCarte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(476, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(37, 37);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "X";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmStergeCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(525, 316);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblInfoCarte);
            this.Controls.Add(this.btnCodCarte);
            this.Controls.Add(this.txtCodCarte);
            this.Controls.Add(this.lblStergeCititor);
            this.Controls.Add(this.lblCodCarte);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStergeCarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStergeCarte";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStergeCarte_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCodCarte;
        private System.Windows.Forms.TextBox txtCodCarte;
        private System.Windows.Forms.Label lblStergeCititor;
        private System.Windows.Forms.Label lblCodCarte;
        private System.Windows.Forms.Label lblInfoCarte;
        private System.Windows.Forms.Button btnCancel;
    }
}