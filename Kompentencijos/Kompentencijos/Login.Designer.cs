namespace Kompentencijos
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.btnlog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usr = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prisjungtiKaipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Name = "label1";
            // 
            // btnlog
            // 
            resources.ApplyResources(this.btnlog, "btnlog");
            this.btnlog.Name = "btnlog";
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Name = "label2";
            // 
            // txt_usr
            // 
            resources.ApplyResources(this.txt_usr, "txt_usr");
            this.txt_usr.Name = "txt_usr";
            // 
            // txt_pass
            // 
            resources.ApplyResources(this.txt_pass, "txt_pass");
            this.txt_pass.Name = "txt_pass";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prisjungtiKaipToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // prisjungtiKaipToolStripMenuItem
            // 
            this.prisjungtiKaipToolStripMenuItem.Name = "prisjungtiKaipToolStripMenuItem";
            resources.ApplyResources(this.prisjungtiKaipToolStripMenuItem, "prisjungtiKaipToolStripMenuItem");
            this.prisjungtiKaipToolStripMenuItem.Click += new System.EventHandler(this.prisjungtiKaipToolStripMenuItem_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kompentencijos.Resource1.cropped_DJI_0465_1536x922f;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_usr);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_usr;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prisjungtiKaipToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

