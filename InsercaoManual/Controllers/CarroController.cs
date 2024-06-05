using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CarroController
    {
        private CarroService _carroService;

        public CarroController()
        {
            this._carroService = new CarroService();
        }

        public Carro Get(string placa)
        {
            return _carroService.Get(placa);
        }
    }
}
