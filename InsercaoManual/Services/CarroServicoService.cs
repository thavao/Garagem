using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarroServicoService
    {
        private CarroServicoRepository _carroServicoRepository;

        public CarroServicoService()
        {
            _carroServicoRepository = new CarroServicoRepository();
        }
        public void Inserir(CarroServico carroServico)
        {
            _carroServicoRepository.Inserir(carroServico);
        }
    }
}
