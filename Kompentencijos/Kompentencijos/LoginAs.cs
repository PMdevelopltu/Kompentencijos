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
    public partial class LoginAs : Form
    {
        public LoginAs()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Administratorius")
            {
                Administrator_lgn ne = new Administrator_lgn();
                this.Close();
                ne.Show();
            }
            else if (comboBox1.Text == "Mokytojas")
            {

            }
            else if (comboBox1.Text == "Mokytojas")
            {

            }
        }
    }
}
