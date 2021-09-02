using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_de_classes
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void inserirClienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
          

                newForm.MdiParent = this;
                newForm.Show();


        }

        private void inserirVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();

            newForm.MdiParent = this;
            newForm.Show();
        }

        private void procurarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procurarCliente newForm = new procurarCliente();

            newForm.MdiParent = this;
            newForm.Show();
        }

        private void procurarVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procurarVeiculo newForm = new procurarVeiculo();

            newForm.MdiParent=this;
            newForm.Show();

        }
    }
}
