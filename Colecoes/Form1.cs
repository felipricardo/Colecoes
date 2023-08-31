using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            // Array
            string[] nomes = new string[3];
            nomes[0] = "Felipe";
            nomes[1] = "Gabriel";
            nomes[2] = "Toni";

            List<string> nomes2 = new List<string>();

            nomes2.Add("Leo");
            nomes2.Add("Julia");
            nomes2.AddRange(nomes);

            lista.Items.Add(nomes2[0]);
            lista.Items.Add(nomes2[1]);
            lista.Items.Add(nomes2[2]);
            lista.Items.Add(nomes2[3]);
            lista.Items.Add(nomes2[4]);

        }
    }
}
