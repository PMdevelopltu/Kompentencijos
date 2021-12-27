namespace Kompentencijos
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kurtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atsijungtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kurtiToolStripMenuItem,
            this.atsijungtiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kurtiToolStripMenuItem
            // 
            this.kurtiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grupęToolStripMenuItem});
            this.kurtiToolStripMenuItem.Name = "kurtiToolStripMenuItem";
            this.kurtiToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.kurtiToolStripMenuItem.Text = "Kurti...";
            // 
            // atsijungtiToolStripMenuItem
            // 
            this.atsijungtiToolStripMenuItem.Name = "atsijungtiToolStripMenuItem";
            this.atsijungtiToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.atsijungtiToolStripMenuItem.Text = "Atsijungti";
            this.atsijungtiToolStripMenuItem.Click += new System.EventHandler(this.atsijungtiToolStripMenuItem_Click);
            // 
            // grupęToolStripMenuItem
            // 
            this.grupęToolStripMenuItem.Name = "grupęToolStripMenuItem";
            this.grupęToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grupęToolStripMenuItem.Text = "Grupę";
            this.grupęToolStripMenuItem.Click += new System.EventHandler(this.grupęToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagrindinis langas";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kurtiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atsijungtiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupęToolStripMenuItem;
    }
}