using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;


namespace trabalho_de_classes
{
   public class ClienteAluguer 
    {
   
        protected string nome;
        protected int idClienteAluguer;

        public ClienteAluguer(string nome)
        {
            this.nome = nome;
        }

        public int IdClienteAluguer
        {
            get { return idClienteAluguer; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public virtual SqlCommand insereCliente()
        {
            string insert = "INSERT INTO CLIENTEALUGUER(nome)"; 
            insert+="VALUES (@nome)";
            SqlCommand cmd = new SqlCommand(insert);

            cmd.Parameters.AddWithValue("@nome", nome);

            return cmd;
        }
   
    }
}
