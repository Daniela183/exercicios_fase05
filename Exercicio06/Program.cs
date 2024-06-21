Console.WriteLine("6- Crie um programa C# e defina um método chamado ProcessaObjetos() que possa receber um número " +
    "variáveis de argumentos e que possa exibir os seus valores e também o tipo do objeto (Use o método GetType() herdado de Object) no console." +
    "Passe os seguintes argumentos ao invocar o método: ProcessaObjetos(1, \"Maria\", 3.45m, new Teste(), null)\n");

ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null);

Console.ReadKey();
static void ProcessaObjetos(params object[] vetor)
{
Console.WriteLine("\nExibindo o conteúdo do array de objetos\n");

if (vetor != null)
{
foreach (var objeto in vetor)
{

Console.WriteLine($"objeto: {objeto} \t tipo: {objeto?.GetType()}");
}
}
}

class Teste
{ }
