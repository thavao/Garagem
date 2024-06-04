using Services;
using Models;
namespace Controllers
{
    public class CarroController
    {
        private CarroService _carroService;

        public CarroController()
        {
            this._carroService = new CarroService();
        }
        public bool Inserir(Carro carro)
        {
            return _carroService.Inserir(carro);
        }
    }
}
