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
            lista.Items.Clear();
            // Array
            string[] nomes = new string[3];
            nomes[0] = "Felipe";
            nomes[1] = "Gabriel";
            nomes[2] = "Toni";

            // Lista gerenerica
            List<string> nomes2 = new List<string>();

            nomes2.Add("Leo");
            nomes2.Add("Julia");
            nomes2.AddRange(nomes);

            //if (nomes2.Remove("Toni"))
            //{
            //    MessageBox.Show("Toni removido");
            //}
            //else
            //{
            //    MessageBox.Show("Não foi possivel remover!");
            //}

            //if (nomes2.Contains("Julia"))
            //{
            //    MessageBox.Show("Contém");
            //}
            //else
            //{
            //    MessageBox.Show("Não contém");
            //}

            //MessageBox.Show("Número de elementos: " + nomes2.Count);
            //nomes2.Sort();

            //MessageBox.Show("Toni está no indice: " + nomes2.IndexOf("Max"));

            //nomes2.Insert(2, "Max");

            //nomes2.RemoveAt(1);

            //nomes2.Clear(); // limpa toda a lista

            //nomes2.Add("Arthur");
            //nomes2.Add("Sam");

            foreach (string nome in nomes2)
            {
                lista.Items.Add(nome);
            }

        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            HashSet<string> veiculos = new HashSet<string>()
            {
                "Carro", "Moto", "Avião", "Bike", "Barco"
            };

            if (veiculos.Add("Jetski"))
            {
                MessageBox.Show("Novo veiculo adicionado");
            }
            else
            {
                MessageBox.Show("Não deu boa.");
            }

            foreach (string item in veiculos)
            {
                lista.Items.Add(item);
            }
        }
    }
}
