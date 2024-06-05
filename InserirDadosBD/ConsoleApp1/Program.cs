using Models;
using Controllers;
using Newtonsoft.Json;

string caminho = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..", @"..", @"..", @"..", @".."));
string arquivo = @"\Carros.json";


StreamReader streamReader= new StreamReader(caminho + arquivo);
string jsonString = streamReader.ReadToEnd();

List<Carro>? carros = JsonConvert.DeserializeObject<List<Carro>>(jsonString);
streamReader.Close();

foreach (var item in carros)
{
    new CarroController().Inserir(item);
}
