
namespace Kompentencijos
{
    partial class Administrator_lgn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator_lgn));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.adminpass = new System.Windows.Forms.TextBox();
            this.adminusr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(129, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vartotojo vardas";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(129, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Slaptažodis";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(297, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Prisijungti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminpass
            // 
            this.adminpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminpass.Location = new System.Drawing.Point(219, 121);
            this.adminpass.Name = "adminpass";
            this.adminpass.PasswordChar = '*';
            this.adminpass.Size = new System.Drawing.Size(155, 20);
            this.adminpass.TabIndex = 16;
            // 
            // adminusr
            // 
            this.adminusr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminusr.Location = new System.Drawing.Point(219, 95);
            this.adminusr.Name = "adminusr";
            this.adminusr.Size = new System.Drawing.Size(155, 20);
            this.adminusr.TabIndex = 17;
            // 
            // Administrator_lgn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kompentencijos.Resource1.cropped_DJI_0465_1536x922f;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adminpass);
            this.Controls.Add(this.adminusr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(517, 321);
            this.MinimumSize = new System.Drawing.Size(517, 321);
            this.Name = "Administrator_lgn";
            this.Text = "Prisjungti kaip administratoriui...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox adminpass;
        private System.Windows.Forms.TextBox adminusr;
    }
}