using Models;
using Repositories;

namespace Services
{
    public class CarroService
    {
        CarroRepository _carroRepository;
        public CarroService()
        {
            this._carroRepository = new CarroRepository();
        }
        public bool Inserir(Carro carro)
        {
            return _carroRepository.Inserir(carro);
        }
    }
}
