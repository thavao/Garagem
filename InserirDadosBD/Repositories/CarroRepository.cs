using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using Models;
using System.Configuration;

namespace Repositories
{
    public class CarroRepository
    {
        private string Conn { get; set; }

        public CarroRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["BancoGaragem"].ConnectionString;
        }
        public bool Inserir(Carro carro)
        {
            bool status = false;
            using(var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute("INSERT INTO CARRO (Placa, Nome, AnoModelo, AnoFabricacao, Cor)" +
                    " VALUES (@Placa, @Nome, @AnoModelo, @AnoFabricacao, @Cor)");
                status = true;
                db.Close();
            }
            return status;
        }
    }
}
