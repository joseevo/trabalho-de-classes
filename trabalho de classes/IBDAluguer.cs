using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
namespace trabalho_de_classes
{
   public interface IBDAluguer
    {

        bool inserirCliente(ClienteAluguer clienteAluguer);
        bool inserirVeiculo(Veiculo veiculo);
        Veiculo procurarVeiculo(int id);
        DataTable searchVeiculo(string nome);
        ClienteAluguer procurarCliente(int id);
        void agendarAluguer(ClienteAluguer cliente, Veiculo veiculo, DateTime dataI, DateTime dataF);

    

    }
}
