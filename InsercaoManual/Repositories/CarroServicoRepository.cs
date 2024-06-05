using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Configuration;

namespace Repositories
{
    public class CarroServicoRepository
    {
        private string Conn { get; set; }

        public CarroServicoRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["BancoGaragem"].ConnectionString;
        }

        public void Inserir(CarroServico carroServico)
        {
            using(var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute("INSERT INTO CARRO_SERVICO (Carro, Servico, Status) VALUES (@Carro, @Servico, @Status)", new { @Carro = carroServico.Carro.Placa, @Servico = carroServico.Servico.Id, @Status = carroServico.Status });
                db.Close();
            }
        }
    }
}
