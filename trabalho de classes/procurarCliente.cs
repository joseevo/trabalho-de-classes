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
    public partial class procurarCliente : Form
    {
        public IBDAluguer gp;
        public procurarCliente()
        {
            InitializeComponent();
            gp = new BDAluguer("Database1.mdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item=null;
            if (gp.procurarCliente(int.Parse(tB.Text))!= null)
            {
                item = new ListViewItem(tB.Text);
                item.SubItems.Add(gp.procurarCliente(int.Parse(tB.Text)).Nome);
            }

            listView1.Items.Add(item);
        }
    }
}
