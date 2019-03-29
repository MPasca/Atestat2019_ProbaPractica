namespace atestat
{
    partial class frmAddImprumut
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
            this.lblAdauga = new System.Windows.Forms.Label();
            this.lblCodCarte = new System.Windows.Forms.Label();
            this.lblCodCititor = new System.Windows.Forms.Label();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.txtCodCititor = new System.Windows.Forms.TextBox();
            this.txtCodCarte = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdauga
            // 
            this.lblAdauga.BackColor = System.Drawing.Color.Transparent;
            this.lblAdauga.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdauga.ForeColor = System.Drawing.Color.DimGray;
            this.lblAdauga.Location = new System.Drawing.Point(145, 25);
            this.lblAdauga.Name = "lblAdauga";
            this.lblAdauga.Size = new System.Drawing.Size(257, 44);
            this.lblAdauga.TabIndex = 1;
            this.lblAdauga.Text = "IMPRUMUT NOU";
            this.lblAdauga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodCarte
            // 
            this.lblCodCarte.BackColor = System.Drawing.Color.Transparent;
            this.lblCodCarte.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCarte.ForeColor = System.Drawing.Color.Black;
            this.lblCodCarte.Location = new System.Drawing.Point(13, 105);
            this.lblCodCarte.Name = "lblCodCarte";
            this.lblCodCarte.Size = new System.Drawing.Size(118, 43);
            this.lblCodCarte.TabIndex = 3;
            this.lblCodCarte.Text = "Cod Carte:";
            this.lblCodCarte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodCititor
            // 
            this.lblCodCititor.BackColor = System.Drawing.Color.Transparent;
            this.lblCodCititor.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCititor.ForeColor = System.Drawing.Color.Black;
            this.lblCodCititor.Location = new System.Drawing.Point(13, 155);
            this.lblCodCititor.Name = "lblCodCititor";
            this.lblCodCititor.Size = new System.Drawing.Size(118, 43);
            this.lblCodCititor.TabIndex = 4;
            this.lblCodCititor.Text = "Cod Cititor:";
            this.lblCodCititor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel2
            // 
            this.btnCancel2.BackColor = System.Drawing.Color.Silver;
            this.btnCancel2.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.ForeColor = System.Drawing.Color.Black;
            this.btnCancel2.Location = new System.Drawing.Point(495, 12);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(37, 37);
            this.btnCancel2.TabIndex = 15;
            this.btnCancel2.Text = "X";
            this.btnCancel2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCancel2.UseVisualStyleBackColor = false;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCodCititor
            // 
            this.txtCodCititor.BackColor = System.Drawing.Color.LightGray;
            this.txtCodCititor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodCititor.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCititor.ForeColor = System.Drawing.Color.Gray;
            this.txtCodCititor.Location = new System.Drawing.Point(137, 155);
            this.txtCodCititor.Multiline = true;
            this.txtCodCititor.Name = "txtCodCititor";
            this.txtCodCititor.Size = new System.Drawing.Size(343, 43);
            this.txtCodCititor.TabIndex = 17;
            // 
            // txtCodCarte
            // 
            this.txtCodCarte.BackColor = System.Drawing.Color.LightGray;
            this.txtCodCarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodCarte.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCarte.ForeColor = System.Drawing.Color.Gray;
            this.txtCodCarte.Location = new System.Drawing.Point(137, 105);
            this.txtCodCarte.Multiline = true;
            this.txtCodCarte.Name = "txtCodCarte";
            this.txtCodCarte.Size = new System.Drawing.Size(343, 43);
            this.txtCodCarte.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdd.Location = new System.Drawing.Point(170, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(204, 64);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "IMPRUMUT NOU";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_2);
            // 
            // frmAddImprumut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(544, 315);
            this.ControlBox = false;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCodCarte);
            this.Controls.Add(this.txtCodCititor);
            this.Controls.Add(this.btnCancel2);
            this.Controls.Add(this.lblCodCititor);
            this.Controls.Add(this.lblCodCarte);
            this.Controls.Add(this.lblAdauga);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmAddImprumut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdaugaImprumut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdauga;
        private System.Windows.Forms.Label lblCodCarte;
        private System.Windows.Forms.Label lblCodCititor;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.TextBox txtCodCititor;
        private System.Windows.Forms.TextBox txtCodCarte;
        private System.Windows.Forms.Button btnAdd;
    }
}