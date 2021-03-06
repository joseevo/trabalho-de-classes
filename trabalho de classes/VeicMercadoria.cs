using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace trabalho_de_classes
{
    public class VeicMercadoria:Veiculo
    {
        public const string TIPO="Veiculo Mercadorias";
        public VeicMercadoria(string marca, string modelo, bool disponivel)
                              : base(marca, modelo, disponivel)
        {
         
        }



        public override SqlCommand insereVeiculo()
        {
            string insert = "INSERT INTO VEICULO(marca, modelo, tipo, disponível)";
            insert += "VALUES(@marca, @modelo, @tipo, @disponível)";
            SqlCommand cmd = new SqlCommand(insert);

            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@modelo", modelo);
            cmd.Parameters.AddWithValue("@tipo", TIPO);
            cmd.Parameters.AddWithValue("@disponível", disponivel);

            return cmd;
        }
    }
}
