using Models;
using Controllers;

Carro carro = new Carro
{
    Placa = "1234abc",
    Nome = "joao",
    AnoModelo = 2015,
    AnoFabricacao = 2017,
    Cor = "Ultra-Violeta"
};

new CarroController().Inserir(carro);

Console.WriteLine("Fim");