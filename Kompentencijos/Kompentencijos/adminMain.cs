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
    public partial class adminMain : Form
    {
        public adminMain()
        {
            InitializeComponent();
        }

        private void klasęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KurtiKlase ne = new KurtiKlase();
            ne.Show();
        }
    }
}
