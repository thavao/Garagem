using Models;
using Repositories;
namespace Services
{
    public class ServicoService
    {
        private ServicoRepository _servicoRepository;

        public ServicoService()
        {
            _servicoRepository = new ServicoRepository();
        }
        public void Inserir(Servico servico)
        {
            _servicoRepository.Inserir(servico);
        }
        public Servico Get(int id)
        {
            return _servicoRepository.Get(id);
        }
    }
}
