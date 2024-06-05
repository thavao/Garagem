using Models;
using Services;

namespace Controllers
{
    public class ServicoController
    {
        private ServicoService _servicoService;
        public ServicoController()
        {
            _servicoService = new ServicoService();
        }
        public void Inserir(Servico servico)
        {
            _servicoService.Inserir(servico);
        }
        public Servico Get(int id)
        {
            return _servicoService.Get(id);
        }
    }
}
