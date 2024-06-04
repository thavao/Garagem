// See https://aka.ms/new-console-template for more information
using Models;
using Newtonsoft;
using Newtonsoft.Json;

void GerarJson(List<Carro> lista)
{
    try
    {
        string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
        StreamWriter streamWriter = new StreamWriter(caminho + arquivo);
        streamWriter.Write(json);
        streamWriter.Close();
    }
    catch (Exception)
    {
        Console.WriteLine("Ocorreu um erro ao gerar o arquivo...");
    }
}

string GerarCor()
{
    string[] cores = {
            "Preto",
            "Branco",
            "Cinza",
            "Prata",
            "Vermelho",
            "Azul",
            "Verde",
            "Amarelo",
            "Roxo",
            "Marrom"
    };
    return cores[new Random().Next(0, cores.Length)];
}

string GerarNome()
{
    string[] nomes = new string[]
    {
            "Ford Mustang",
            "Chevrolet Camaro",
            "Dodge Charger",
            "Toyota Corolla",
            "Honda Civic",
            "BMW 3 Series",
            "Audi A4",
            "Mercedes-Benz C-Class",
            "Volkswagen Golf",
            "Nissan Altima",
            "Hyundai Elantra",
            "Kia Optima",
            "Subaru Impreza",
            "Mazda 3",
            "Tesla Model 3",
            "Lexus IS",
            "Jaguar XE",
            "Infiniti Q50",
            "Acura TLX",
            "Cadillac ATS",
            "Alfa Romeo Giulia",
            "Volvo S60",
            "Mitsubishi Lancer",
            "Mini Cooper",
            "Porsche 911",
            "Ferrari 488",
            "Lamborghini Huracan",
            "McLaren 720S",
            "Aston Martin Vantage",
            "Rolls-Royce Phantom"
    };

    return nomes[new Random().Next(0, nomes.Length)];
}

string GerarPlaca()
{
    string placa = "";
    string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    placa += letras[new Random().Next(0, letras.Length)];
    placa += letras[new Random().Next(0, letras.Length)];
    placa += letras[new Random().Next(0, letras.Length)];
    placa += new Random().Next(0, 10).ToString();
    placa += letras[new Random().Next(0, letras.Length)];
    placa += new Random().Next(0, 10).ToString();
    placa += new Random().Next(0, 10).ToString();
    
    return placa;
}

Carro GerarCarro(){
    int anoModelo = new Random().Next(1990, DateTime.Now.Year + 2);
    int anoFabricacao = new Random().Next(anoModelo - 1, DateTime.Now.Year);

    Carro carro = new Carro
    {
        Placa = GerarPlaca(),
        Nome = GerarNome(),
        AnoModelo = anoModelo,
        AnoFabricacao = anoFabricacao,
        Cor = GerarCor(),
    };
    return carro;
}



List<Carro> carros = new List<Carro>();

for (int i = 0; i < 30; i++)
{
    carros.Add(GerarCarro());
}

string caminho = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..", @"..", @"..", @"..", @".."));
string arquivo = @"\Carros.json";

GerarJson(carros);