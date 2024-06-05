using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CarroRepository
    {
        private string Conn { get; set; }

        public CarroRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["BancoGaragem"].ConnectionString;
        }

        public Carro Get(string placa)
        {
            using(var db = new SqlConnection(Conn))
            {
                db.Open();
                var carro = db.QueryFirstOrDefault<Carro>("SELECT Placa, Nome, AnoModelo, AnoFabricacao ,Cor FROM CARRO WHERE Placa = @Placa",
                        new { Placa = placa });
                db.Close();
                return carro;
            }
            return null;
        }
    }
}
