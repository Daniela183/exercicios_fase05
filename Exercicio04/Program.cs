using System.Collections;
using Exercicio04;

Console.WriteLine("4- Crie um programa C# que usa uma ArrayList para armazenar uma lista de objetos pessoas");
Console.WriteLine("a-) Primeiro crie uma classe chamada Pessoa.cs com duas propriedades (nome e idade) e um método Exibir() " +
    "para imprimir o nome e a idade;\n");


Console.WriteLine("b-) A seguir crie uma ArrayList e solicite a informação dos nomes e idades de 3 pessoas via teclado " +
    "armazenando as informações na ArrayList\n");
Console.WriteLine("c-) A seguir exiba no console a lista das pessoas com nome e idade\n");

Console.WriteLine("d-) Inclua mais dois objetos Pessoa na lista e exiba a nova lista de pessoas\n");
Console.WriteLine("e-) Remova o último elemento da coleção e exiba a lista completa\n");



ArrayList lista = new ArrayList();

Console.WriteLine("Informe o nome e idade de 3 pessoas\n Dados iniciais: Ana, 22 - Diná, 21 - Maria, 19");
int total = 3;
for (int i = 0; i < total; i++)
{
Console.Write("\nNome: ");
string nome = Console.ReadLine();
Console.Write("Idade: ");
int idade = int.Parse(Console.ReadLine());

lista.Add(new Pessoa()
{
Nome = nome,
Idade = idade
});
}

ListaPessoas(lista);

Console.WriteLine("\nIncluindo duas pessoas na lista\n Incluir os objetos pessoa use os dados: Jaime, 20 - Tânia, 18");

Pessoa jaime = new Pessoa() { Nome = "Jaime", Idade = 20 };
Pessoa tania = new Pessoa() { Nome = "Tânia", Idade = 18 };

lista.Add(jaime);
lista.Add(tania);

ListaPessoas(lista);

Console.WriteLine("\nRemovendo o último elemento");
lista.RemoveAt(lista.Count - 1);
ListaPessoas(lista);

Console.ReadLine();

static void ListaPessoas(ArrayList lista)
{
Console.WriteLine("\nLista de pessoas atual\n");
foreach (Pessoa pessoa in lista)
{
Console.WriteLine(pessoa.Exibir());
}
}
