using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace trabalho_de_classes
{
   
    public partial class procurarVeiculo : Form
    {
        
        public IBDAluguer gp;

        public procurarVeiculo()
        {
            
            InitializeComponent();
            gp = new BDAluguer("Database1.mdf");

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            dataVeic.Enabled = false;
            string nome = txtIdVeic.Text.ToString();
            dataVeic.DataSource=gp.searchVeiculo(nome);


        }

        


        
        
    }
}
