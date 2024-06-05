using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CarroServicoController
    {
        private CarroServicoService _carroServicoRepository;

        public CarroServicoController()
        {
            _carroServicoRepository = new CarroServicoService();
        }
        public void Inserir(CarroServico carroServico)
        {
            _carroServicoRepository.Inserir(carroServico);
        }
    }
}
