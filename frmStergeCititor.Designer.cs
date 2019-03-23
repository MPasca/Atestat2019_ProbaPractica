namespace atestat
{
    partial class frmStergeCititor
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
            this.lblInfoCititor = new System.Windows.Forms.Label();
            this.btnCod = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblStergeCititor = new System.Windows.Forms.Label();
            this.lblCNP = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfoCititor
            // 
            this.lblInfoCititor.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoCititor.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCititor.ForeColor = System.Drawing.Color.Black;
            this.lblInfoCititor.Location = new System.Drawing.Point(38, 235);
            this.lblInfoCititor.Name = "lblInfoCititor";
            this.lblInfoCititor.Size = new System.Drawing.Size(439, 61);
            this.lblInfoCititor.TabIndex = 23;
            this.lblInfoCititor.Text = "Aici e label";
            this.lblInfoCititor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCod
            // 
            this.btnCod.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCod.ForeColor = System.Drawing.Color.DimGray;
            this.btnCod.Location = new System.Drawing.Point(189, 159);
            this.btnCod.Name = "btnCod";
            this.btnCod.Size = new System.Drawing.Size(166, 39);
            this.btnCod.TabIndex = 22;
            this.btnCod.Text = "Sterge";
            this.btnCod.UseVisualStyleBackColor = true;
            this.btnCod.Click += new System.EventHandler(this.btnCNP_Click);
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.Color.LightGray;
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCod.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.ForeColor = System.Drawing.Color.Gray;
            this.txtCod.Location = new System.Drawing.Point(121, 100);
            this.txtCod.Multiline = true;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(343, 43);
            this.txtCod.TabIndex = 21;
            // 
            // lblStergeCititor
            // 
            this.lblStergeCititor.BackColor = System.Drawing.Color.Transparent;
            this.lblStergeCititor.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStergeCititor.ForeColor = System.Drawing.Color.DimGray;
            this.lblStergeCititor.Location = new System.Drawing.Point(144, 18);
            this.lblStergeCititor.Name = "lblStergeCititor";
            this.lblStergeCititor.Size = new System.Drawing.Size(257, 44);
            this.lblStergeCititor.TabIndex = 20;
            this.lblStergeCititor.Text = "STERGERE CITITOR";
            this.lblStergeCititor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCNP
            // 
            this.lblCNP.BackColor = System.Drawing.Color.Transparent;
            this.lblCNP.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNP.ForeColor = System.Drawing.Color.Black;
            this.lblCNP.Location = new System.Drawing.Point(32, 99);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(92, 44);
            this.lblCNP.TabIndex = 19;
            this.lblCNP.Text = "Cod:";
            this.lblCNP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(476, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(37, 37);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "X";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmStergeCititor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(525, 316);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblInfoCititor);
            this.Controls.Add(this.btnCod);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblStergeCititor);
            this.Controls.Add(this.lblCNP);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStergeCititor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStergeCititor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStergeCititor_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoCititor;
        private System.Windows.Forms.Button btnCod;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblStergeCititor;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Button btnCancel;
    }
}