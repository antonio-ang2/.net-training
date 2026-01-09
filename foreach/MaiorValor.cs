public class Exercicio02
// Percorra uma List<int> e encontre o maior número.

// Estrutura do foreach não permite uso de indice, para isso existe o for...
{
    public static void Executar() // Esse método não pertence a uma instância, mas à classe em si.
    {
        int[] numeros = {10, 2, 17, 29, 23};
        int maiorNum = numeros[0];
        
        foreach (int num in numeros)
        {
            if (num > maiorNum)
            {
                maiorNum = num;
            }
        }
        Console.WriteLine($"O maior número da lista é {maiorNum}");

    }
}