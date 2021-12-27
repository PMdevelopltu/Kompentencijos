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
    public partial class KurtiKlase : Form
    {
        Class1 db = new Class1();
        
        public KurtiKlase()
        {

            InitializeComponent();
            db.Connect("userdata");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            string anglu="ne", anglumod="ne", vokieciu="ne", lietuviu="ne", lietuviumod="ne", tech, braiz, dail, btd, it, prog, fz, zm, uk, teis, ps, mat, matmo, fi, fizmo, che, chem, ist, pili, muz, tik, etk;
            string s;
            s = "Pasirinkti dalykai:\n";
            foreach(object item in checkedListBox1.CheckedItems){
                if(checkedListBox1.CheckedItems[0].ToString()=="Anglų kalba")
                {
                     anglu = "taip";
                }
                else
                {
                        anglu = "ne";
                }
                
            }
            MessageBox.Show(s);
            MessageBox.Show(anglu);
            db.Execute("INSERT INTO `klas_info` (`id`, `names`, `class`,  `anglu`) VALUES (NULL, '" + textName.Text + "', '" + texclass.Text + "', '" + anglu + "');");
            //MessageBox.Show("Mokinys sėkmingai pridėtas");
        }
    }
}
