using Exercicio05;

Console.WriteLine("5- Dada uma classe Produto contendo duas propriedades: Nome (string) e Preco (decimal). Crie uma lista de objetos do tipo Produto usando" +
    " os seguinte dados:\n Clips, R$ 3,95 - Caneta, R$ 5,99 - - Lápis, R$ 4,15 - Estojo, R$ 6,99 e Caderno, R$ 7,55\n");
Console.WriteLine("1- Crie um método para exibir a relação de produtos , a soma total dos preços dos produtos, a média do preço dos produtos e a quantidade" +
    " de produtos na lista\n");

List<Produto> Produtos = FonteDados.GetProdutos();

ExibirProdutos(Produtos);

Console.WriteLine("\n2- Inclua na lista o seguinte produto: Mochila, R$ 22,44 e exiba novamente a lista de produtos\n");
Produto mochila = new Produto() { Nome = "Mochila", Preco = 22.44m };
Produtos.Add(mochila);
ExibirProdutos(Produtos);


Console.WriteLine("\n3- Ordene a lista pelo nome do produto e exiba a lista ordenada");
//Produtos.Sort();
var listaOrdenada = Produtos.OrderBy(n => n.Nome).ToList();
ExibirProdutos(listaOrdenada);

Console.WriteLine("\n4- Obtenha e exiba no console os produtos com preço inferior a R$ 5,00");
var ProdutosMenorCinco = Produtos.FindAll(n => n.Preco <= 5.00m);
Console.Write("\nProdutos com preço menor que R$ 5.00\n");
foreach (var item in ProdutosMenorCinco)
{
    Console.WriteLine($"{item.Nome}\t{item.Preco}");
}
Console.WriteLine("\n5- Localize na lista o produto com nome Estojo");
var produto1 = Produtos.Find(n => n.Nome.Equals("Estojo"));
Console.WriteLine($"\nProduto: {produto1.Nome} - {produto1.Preco}");

Console.ReadKey();

static void ExibirProdutos(List<Produto> Produtos)
{
    
    Console.WriteLine("Relação de Produtos");
    Console.WriteLine("Nome\tPreço");

    var somaPreco = 0.0m;
    foreach (var item in Produtos)
    {
        Console.WriteLine($"{item.Nome}\t{item.Preco}");
        somaPreco += item.Preco;
    }

    var mediaPreco = somaPreco / Produtos.Count();
    Console.WriteLine($"\nMédia dos preços: {Math.Round(mediaPreco, 2)}");
    Console.WriteLine($"\nTotal de Produtos: {Produtos.Count()}");
}