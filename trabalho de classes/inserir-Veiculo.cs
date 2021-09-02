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
    public partial class Form2 : Form
    {
        public IBDAluguer gp;
        public Form2()
        {
            InitializeComponent();
            gp = new BDAluguer("Database1.mdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool disponivel = true;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;

            if (!cBDisponivel.Checked)
            {
               disponivel = false;
            }

            Veiculo veiculo = null;
            if(rdbMercadorias.Checked)
            {
                veiculo = new VeicMercadoria(marca, modelo, disponivel);
                
            }
            else
            {
                veiculo = new VeicPassageiro(marca, modelo, disponivel);
            }

            bool insere = gp.inserirVeiculo(veiculo);
            if (insere)
            {
                MessageBox.Show("Veiculo inserido com sucesso.");
                cBDisponivel.Checked = true;
                rdbPassageiros.Checked=true;
                txtMarca.Clear();
                txtModelo.Clear();

            }
                
            else
                MessageBox.Show("Algo correu mal. Tente novamente");


        }
    }
}
