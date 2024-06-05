using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarroService
    {
        CarroRepository _carroRepository;
        public CarroService()
        {
            this._carroRepository = new CarroRepository();
        }

        public Carro Get(string placa)
        {
            return _carroRepository.Get(placa);
        }
    }
}
