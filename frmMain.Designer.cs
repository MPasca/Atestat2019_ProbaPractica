namespace atestat
{
    partial class frmMain
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
            this.meniu = new System.Windows.Forms.MenuStrip();
            this.cititoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cautareFisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cautareCarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meniu.SuspendLayout();
            this.SuspendLayout();
            // 
            // meniu
            // 
            this.meniu.BackColor = System.Drawing.Color.Gainsboro;
            this.meniu.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meniu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cititoriToolStripMenuItem,
            this.cartiToolStripMenuItem});
            this.meniu.Location = new System.Drawing.Point(0, 0);
            this.meniu.Name = "meniu";
            this.meniu.Size = new System.Drawing.Size(679, 27);
            this.meniu.TabIndex = 1;
            this.meniu.Text = "menuStrip1";
            // 
            // cititoriToolStripMenuItem
            // 
            this.cititoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.modificareToolStripMenuItem,
            this.stergereToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cautareFisaToolStripMenuItem});
            this.cititoriToolStripMenuItem.Name = "cititoriToolStripMenuItem";
            this.cititoriToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.cititoriToolStripMenuItem.Text = "Cititori";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            this.adaugareToolStripMenuItem.Click += new System.EventHandler(this.adaugareToolStripMenuItem_Click);
            // 
            // modificareToolStripMenuItem
            // 
            this.modificareToolStripMenuItem.Name = "modificareToolStripMenuItem";
            this.modificareToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.modificareToolStripMenuItem.Text = "Modificare";
            this.modificareToolStripMenuItem.Click += new System.EventHandler(this.modificareToolStripMenuItem_Click);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.stergereToolStripMenuItem.Text = "Stergere";
            this.stergereToolStripMenuItem.Click += new System.EventHandler(this.stergereToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 6);
            // 
            // cautareFisaToolStripMenuItem
            // 
            this.cautareFisaToolStripMenuItem.Name = "cautareFisaToolStripMenuItem";
            this.cautareFisaToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.cautareFisaToolStripMenuItem.Text = "Cautare fisa";
            this.cautareFisaToolStripMenuItem.Click += new System.EventHandler(this.cautareFisaToolStripMenuItem_Click);
            // 
            // cartiToolStripMenuItem
            // 
            this.cartiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem1,
            this.modificareToolStripMenuItem1,
            this.stergereToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.cautareCarteToolStripMenuItem});
            this.cartiToolStripMenuItem.Name = "cartiToolStripMenuItem";
            this.cartiToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.cartiToolStripMenuItem.Text = "Carti";
            // 
            // adaugareToolStripMenuItem1
            // 
            this.adaugareToolStripMenuItem1.Name = "adaugareToolStripMenuItem1";
            this.adaugareToolStripMenuItem1.Size = new System.Drawing.Size(145, 24);
            this.adaugareToolStripMenuItem1.Text = "Adaugare";
            this.adaugareToolStripMenuItem1.Click += new System.EventHandler(this.adaugareToolStripMenuItem1_Click);
            // 
            // modificareToolStripMenuItem1
            // 
            this.modificareToolStripMenuItem1.Name = "modificareToolStripMenuItem1";
            this.modificareToolStripMenuItem1.Size = new System.Drawing.Size(145, 24);
            this.modificareToolStripMenuItem1.Text = "Modificare";
            this.modificareToolStripMenuItem1.Click += new System.EventHandler(this.modificareToolStripMenuItem1_Click);
            // 
            // stergereToolStripMenuItem1
            // 
            this.stergereToolStripMenuItem1.Name = "stergereToolStripMenuItem1";
            this.stergereToolStripMenuItem1.Size = new System.Drawing.Size(145, 24);
            this.stergereToolStripMenuItem1.Text = "Stergere";
            this.stergereToolStripMenuItem1.Click += new System.EventHandler(this.stergereToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(142, 6);
            // 
            // cautareCarteToolStripMenuItem
            // 
            this.cautareCarteToolStripMenuItem.Name = "cautareCarteToolStripMenuItem";
            this.cautareCarteToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.cautareCarteToolStripMenuItem.Text = "Cautare carte";
            this.cautareCarteToolStripMenuItem.Click += new System.EventHandler(this.cautareCarteToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 362);
            this.Controls.Add(this.meniu);
            this.ForeColor = System.Drawing.Color.Silver;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.meniu;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.meniu.ResumeLayout(false);
            this.meniu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip meniu;
        private System.Windows.Forms.ToolStripMenuItem cititoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cautareFisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cautareCarteToolStripMenuItem;
    }
}

