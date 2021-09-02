using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Diagnostics;

namespace trabalho_de_classes
{

    class BDAluguer : IBDAluguer
    {
        protected int idClienteAluguer;
        protected string nome;


        private string dbname;
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        public BDAluguer(string dbname)
        {
            this.dbname = dbname;

            cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" +
               Directory.GetParent(Environment.CurrentDirectory).Parent.FullName +
               "\\" + dbname + ";Integrated Security = true");
        }

        bool IBDAluguer.inserirCliente(ClienteAluguer clienteAluguer)
        {
            cn.Open();

            SqlCommand cmd = clienteAluguer.insereCliente();

            cmd.Connection = cn;

            int rows = 0;
            try
            {
                rows = cmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                cn.Close();
                return false;
            }

            cn.Close();

            return rows > 0;
        }
        bool IBDAluguer.inserirVeiculo(Veiculo veiculo)
        {
            cn.Open();

            SqlCommand cmd = veiculo.insereVeiculo();

            cmd.Connection = cn;

            int rows = 0;
            try
            {
                rows = cmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                cn.Close();
                return false;
            }

            cn.Close();

            return rows > 0;
        }
       Veiculo IBDAluguer.procurarVeiculo(int id)
        {
            return null;
          
        }
        public DataTable searchVeiculo(string nome)
        {
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * fROM VEICULO WHERE IdVeiculo = "+nome, cn);
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);

            return dtbl;
        }
        public ClienteAluguer procurarCliente(int id)
        {
            cn.Open();
            string consulta = "SELECT * from CLIENTEALUGUER WHERE IdClienteAluguer ="+id.ToString();
            SqlCommand cmd = new SqlCommand(consulta);
            cmd.Connection = cn;

            dr = cmd.ExecuteReader();

            //int idC = int.Parse(dr["IdClienteAluguer"].ToString());
            string nome = dr["nome"].ToString();

            ClienteAluguer cliente = new ClienteAluguer(nome);

            cn.Close();
            return cliente;

        }
       public void agendarAluguer(ClienteAluguer cliente, Veiculo veiculo, DateTime datal, DateTime dataf)
        {
            
        }

    }
}
