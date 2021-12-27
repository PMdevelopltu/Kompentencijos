
namespace Kompentencijos
{
    partial class adminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.failasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klasęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atsijungtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failasToolStripMenuItem,
            this.kurtiToolStripMenuItem,
            this.statistikaToolStripMenuItem,
            this.atsijungtiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // failasToolStripMenuItem
            // 
            this.failasToolStripMenuItem.Name = "failasToolStripMenuItem";
            this.failasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.failasToolStripMenuItem.Text = "Failas";
            // 
            // kurtiToolStripMenuItem
            // 
            this.kurtiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klasęToolStripMenuItem});
            this.kurtiToolStripMenuItem.Name = "kurtiToolStripMenuItem";
            this.kurtiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.kurtiToolStripMenuItem.Text = "Kurti";
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            // 
            // klasęToolStripMenuItem
            // 
            this.klasęToolStripMenuItem.Name = "klasęToolStripMenuItem";
            this.klasęToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.klasęToolStripMenuItem.Text = "Pridėti/pašalinti mokinį";
            this.klasęToolStripMenuItem.Click += new System.EventHandler(this.klasęToolStripMenuItem_Click);
            // 
            // atsijungtiToolStripMenuItem
            // 
            this.atsijungtiToolStripMenuItem.Name = "atsijungtiToolStripMenuItem";
            this.atsijungtiToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.atsijungtiToolStripMenuItem.Text = "Atsijungti";
            // 
            // adminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "adminMain";
            this.Text = "Administratorius - Pagrindinis";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem failasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurtiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klasęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atsijungtiToolStripMenuItem;
    }
}