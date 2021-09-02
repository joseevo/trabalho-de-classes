using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using Microsoft.SqlServer.Server;

namespace trabalho_de_classes
{

    public class Veiculo 
    {
        protected int idVeiculo;
        protected string marca;
        protected string modelo;
        protected bool disponivel;
        //protected string tipo;

        public Veiculo(string marca, string modelo, bool disponivel)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.disponivel = disponivel;
        }

        public int IdVeiculo
        {
            get { return idVeiculo; }

            set { idVeiculo = value; }

        }

        public string Marca 
        {
            get { return marca; }
            set { marca = value; }
        
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public bool Disponivel
        {
            get { return disponivel; }
            set { disponivel = value; }
        }

        //public string Tipo
        //{
        //    get { return tipo; }
        //    set { tipo = value; }
        //}

        public virtual SqlCommand insereVeiculo()
        {
            string insert = "INSERT INTO VEICULO(IdVeiculo, marca, modelo, tipo, disponível)";
            insert += "VALUES(@IdVeiculo, @marca, @modelo,@tipo,@disponivel)";
            SqlCommand cmd = new SqlCommand(insert);

            cmd.Parameters.AddWithValue("@IdVeiculo", idVeiculo);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@modelo", modelo);
            cmd.Parameters.AddWithValue("@tipo", " ");
            cmd.Parameters.AddWithValue("@disponivel", disponivel);

            return cmd;
        }

       
    }
}
