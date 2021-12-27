
namespace Kompentencijos
{
    partial class KurtiKlase
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
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pridėtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pašalintiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.texclass = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pridėtiToolStripMenuItem,
            this.pašalintiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pridėtiToolStripMenuItem
            // 
            this.pridėtiToolStripMenuItem.Name = "pridėtiToolStripMenuItem";
            this.pridėtiToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.pridėtiToolStripMenuItem.Text = "Pridėti";
            // 
            // pašalintiToolStripMenuItem
            // 
            this.pašalintiToolStripMenuItem.Name = "pašalintiToolStripMenuItem";
            this.pašalintiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.pašalintiToolStripMenuItem.Text = "Pašalinti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vardas, Pavardė";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Klasė";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dalykai:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(115, 54);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(168, 20);
            this.textName.TabIndex = 4;
            // 
            // texclass
            // 
            this.texclass.FormattingEnabled = true;
            this.texclass.Items.AddRange(new object[] {
            "5a",
            "5b",
            "6a",
            "6b",
            "7a",
            "7b",
            "8a",
            "8b",
            "Ia",
            "Ib",
            "IIa",
            "IIb",
            "IIIa",
            "IIIb",
            "IVa",
            "IVb"});
            this.texclass.Location = new System.Drawing.Point(115, 80);
            this.texclass.Name = "texclass";
            this.texclass.Size = new System.Drawing.Size(168, 21);
            this.texclass.TabIndex = 5;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Anglų kalba",
            "Anglų kalbos modulis",
            "Vokiečių kalba",
            "Lietuvių kalba",
            "Lietuvių kalbos modulis",
            "Technologijos",
            "Braižyba",
            "Dailė",
            "Buities darbai",
            "IT",
            "Programavimas",
            "Fizinis ugdymas",
            "Žmogaus sauga",
            "Ugdymas karjerai",
            "Teisė",
            "Psichologija",
            "Matematika",
            "Matematikos modulis",
            "Fizika",
            "Fizikos modulis",
            "Chemija",
            "Chemijos modulis",
            "Istorija",
            "Pilietiškumo pagrindai",
            "Muzika",
            "Tikyba",
            "Etika"});
            this.checkedListBox1.Location = new System.Drawing.Point(115, 107);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(168, 214);
            this.checkedListBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Išsaugoti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pridėti mokinį";
            // 
            // KurtiKlase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.texclass);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KurtiKlase";
            this.Text = "Pridėti/pašalinti mokinį";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pridėtiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pašalintiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ComboBox texclass;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}