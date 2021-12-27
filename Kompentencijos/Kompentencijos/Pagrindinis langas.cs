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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void atsijungtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sėkmingai atsijungėte");
            Application.Exit();
            Login ns = new Login();
            ns.Show();
        }

        private void grupęToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
