using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Configuration;

namespace Repositories
{
    public class ServicoRepository
    {
        private string Conn { get; set; }

        public ServicoRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["BancoGaragem"].ConnectionString;
        }
        public void Inserir(Servico servico)
        {
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute("INSERT INTO SERVICO (Descricao) VALUES (@Descricao)", servico);
                db.Close();
            }
        }
        public Servico Get(int id)
        {
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                var servico = db.QueryFirstOrDefault<Servico>("SELECT Id, Descricao FROM SERVICO WHERE Id = @id",
                            new { Id = id });
                db.Close();
                return servico;
            }
            return null;
        }
    }
}
