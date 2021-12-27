using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kompentencijos
{
    public partial class Register : Form
    {
        Config db = new Config();
        public Register()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            if (comboBox1.Text == "Administratorius")
            {
                db.Execute("INSERT INTO `admin_info` (`id`, `names`, `username`, `password`) VALUES (NULL, '" + id.Text + "', '" + username.Text + "', '" + pass.Text + "');");
                MessageBox.Show("Sėkmingai prisiregistravote");
            }
        }
    }
}
