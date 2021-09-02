using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_de_classes
{
    public partial class Form1 : Form
    {
        public IBDAluguer gp;
        public Form1()
        {
            InitializeComponent();
            gp = new BDAluguer("Database1.mdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
         
            ClienteAluguer clienteAluguer = new ClienteAluguer(nome);


            bool insere = gp.inserirCliente(clienteAluguer);

            if (insere)
            {
                MessageBox.Show("Cliente inserido com sucesso.");
                txtNome.Clear();
            }
                
            else
                MessageBox.Show("Algo correu mal. Tente novamente");

        }
    }
}
