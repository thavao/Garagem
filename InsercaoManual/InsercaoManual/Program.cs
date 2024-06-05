using Controllers;
using Models;
using System.Linq.Expressions;


Console.WriteLine("Escolha:");
Console.WriteLine("1 - Inserir servico");
Console.WriteLine("2 - Inserir servico para um carro");
int opc = int.Parse(Console.ReadLine());

switch (opc)
{
    case 1:
        InserirServico();
        break;
    case 2:
        InserirCarroServico();
        break;
    default:
        Console.WriteLine("Opção não encontrada...");
        break;
}

void InserirCarroServico()
{
    Console.Write("Digite Placa do carro: ");
    string placa = Console.ReadLine();


    Console.Write("Digite o codigo do servico: ");
    int id = int.Parse(Console.ReadLine());

    Console.WriteLine("O servico esta ativo?");
    Console.WriteLine("1 - sim || 0 - nao");
    int stat = int.Parse(Console.ReadLine());
    bool status;
    if (stat == 1)
        status = true;
    else
        status = false;

    Servico s = new ServicoController().Get(id);
    Carro c = new CarroController().Get(placa);

    CarroServico cr = new CarroServico()
    {
        Carro = c,
        Servico = s,
        Status = status
    };

    new CarroServicoController().Inserir(cr);

}

void InserirServico()
{
    Console.WriteLine("Digite a descricao do servico");
    string descricao = Console.ReadLine();

    Servico servico = new Servico
    {
        Descricao = descricao
    };

    new ServicoController().Inserir(servico);
}
