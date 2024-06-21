//aula 124
Console.WriteLine("1- Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize as seguintes operações:" +
    " Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora\n");
Console.WriteLine("a- Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach\n");
string[] frutas = {
     "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora"
};
Console.WriteLine("Usando FOR");
for (int i = 0; i < frutas.Length; i++)
{
    Console.Write($"{frutas[i]} ");
}
Console.WriteLine("\n\nUsando FOREACH");
foreach (var item in frutas)
{
    Console.Write($"{item} ");
}

Console.WriteLine($"\n\nA coleção frutas possui: {frutas.Count()} frutas");

Console.WriteLine("\nb- Exiba os nomes da segunda e da penúltima fruta no console");

Console.WriteLine($"\nSegunda   =>  {frutas[1]}");
Console.WriteLine($"Penúltima =>  {frutas[8]}");

Console.WriteLine("\nc- Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas\n");

frutas[2] = "Kiwi";
frutas[9] = "Caqui";

foreach (var fruta in frutas)
{
    Console.Write($"{fruta} ");
}

Console.WriteLine("\n\nd- Ordene a coleção de frutas na ordem ascendente\n");
Array.Sort(frutas);
foreach (var fruta in frutas)
{
    Console.Write($"{fruta} ");
}

Console.WriteLine("\n\ne- Exiba no console a coleção de nomes de frutas na ordem inversa\n");
Array.Reverse(frutas);
foreach (var fruta in frutas)
{
    Console.Write($"{fruta} ");
}

Console.ReadKey();