Console.WriteLine("2- Crie um programa em C# que sirva para pesquisar um array de valores inteiros. Para fazer isso, siga estas etapas a seguir");
Console.WriteLine("a-) Solicite via teclado o número de valores do array (deve ser um número inteiro)\n");

Console.Write("Informe o número de elementos inteiros no array: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nb-) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados");
Console.WriteLine("\nInforme os valores dos números no array\n");

int[] numeros = new int[x];

for (int i = 0; i < x; i++)
{
    Console.Write($"Números[{i}] = ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

string numero;
Console.WriteLine("\nc-) Solicite ao usuário um valor de um número inteiro a procurar no array");
Console.Write("\nInforme o número a localizar no array: ");
do
{
    numero = Console.ReadLine();

    if (numero != "fim")
    {
        int valor = Convert.ToInt32(numero);

        if (Array.BinarySearch(numeros, valor) >= 0)
        {
            Console.WriteLine($"\nO número {numero} Existe no array");
        }
        else
        {
            Console.WriteLine($"\nO número {numero} NÃO Existe no array");
        }
        Console.Write("\ne-) Repita até que o texto ‘fim’ seja inserido via teclado: ");
    }

}

while (numero != "fim");