using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kompentencijos
{
    public partial class Login : Form
    {
        Config db = new Config();
        public Login()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM `user_info` where username='" + txt_usr.Text + "' and password ='" + txt_pass.Text + "'");

            if (db.Count() > 1)
            {
                MessageBox.Show("Prisijungėte kaip " + db.Results(0, "names"));
                this.Hide();
                Form2 mn = new Form2();
                mn.Show();
            }
            else
            {
                MessageBox.Show("Neteisingai įvestas vartotojo vardas arba slaptažodis");
            }
        }

        private void prisjungtiKaipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginAs ns = new LoginAs();
            ns.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register ne = new Register();
            ne.Show();
            this.Hide();
        }
    }
}
