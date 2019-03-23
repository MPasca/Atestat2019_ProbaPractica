namespace atestat
{
    partial class frmModCititor
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
            this.btnMod = new System.Windows.Forms.Button();
            this.txtClasa = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblClasa = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblModCititor = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.Color.DimGray;
            this.btnMod.Location = new System.Drawing.Point(164, 270);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(204, 52);
            this.btnMod.TabIndex = 30;
            this.btnMod.Text = "MODIFICA";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // txtClasa
            // 
            this.txtClasa.BackColor = System.Drawing.Color.LightGray;
            this.txtClasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClasa.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClasa.ForeColor = System.Drawing.Color.Gray;
            this.txtClasa.Location = new System.Drawing.Point(137, 100);
            this.txtClasa.Multiline = true;
            this.txtClasa.Name = "txtClasa";
            this.txtClasa.Size = new System.Drawing.Size(343, 43);
            this.txtClasa.TabIndex = 29;
            // 
            // txtNume
            // 
            this.txtNume.BackColor = System.Drawing.Color.LightGray;
            this.txtNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNume.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.ForeColor = System.Drawing.Color.Gray;
            this.txtNume.Location = new System.Drawing.Point(137, 200);
            this.txtNume.Multiline = true;
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(343, 43);
            this.txtNume.TabIndex = 28;
            // 
            // lblClasa
            // 
            this.lblClasa.BackColor = System.Drawing.Color.Transparent;
            this.lblClasa.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasa.ForeColor = System.Drawing.Color.Black;
            this.lblClasa.Location = new System.Drawing.Point(13, 100);
            this.lblClasa.Name = "lblClasa";
            this.lblClasa.Size = new System.Drawing.Size(118, 43);
            this.lblClasa.TabIndex = 25;
            this.lblClasa.Text = "Clasa:";
            this.lblClasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNume
            // 
            this.lblNume.BackColor = System.Drawing.Color.Transparent;
            this.lblNume.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.ForeColor = System.Drawing.Color.Black;
            this.lblNume.Location = new System.Drawing.Point(13, 200);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(118, 43);
            this.lblNume.TabIndex = 24;
            this.lblNume.Text = "Nume:";
            this.lblNume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrenume
            // 
            this.lblPrenume.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenume.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenume.ForeColor = System.Drawing.Color.Black;
            this.lblPrenume.Location = new System.Drawing.Point(13, 150);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(118, 43);
            this.lblPrenume.TabIndex = 23;
            this.lblPrenume.Text = "Prenume:";
            this.lblPrenume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModCititor
            // 
            this.lblModCititor.BackColor = System.Drawing.Color.Transparent;
            this.lblModCititor.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModCititor.ForeColor = System.Drawing.Color.DimGray;
            this.lblModCititor.Location = new System.Drawing.Point(145, 25);
            this.lblModCititor.Name = "lblModCititor";
            this.lblModCititor.Size = new System.Drawing.Size(257, 44);
            this.lblModCititor.TabIndex = 21;
            this.lblModCititor.Text = "MODIFICA UN CITITOR";
            this.lblModCititor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrenume
            // 
            this.txtPrenume.BackColor = System.Drawing.Color.LightGray;
            this.txtPrenume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenume.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenume.ForeColor = System.Drawing.Color.Gray;
            this.txtPrenume.Location = new System.Drawing.Point(137, 150);
            this.txtPrenume.Multiline = true;
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(343, 43);
            this.txtPrenume.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(495, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(37, 37);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "X";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmModCititor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(544, 400);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.txtClasa);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.lblClasa);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblModCititor);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModCititor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModCititor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmModCititor_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.TextBox txtClasa;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblClasa;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblModCititor;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Button btnCancel;
    }
}