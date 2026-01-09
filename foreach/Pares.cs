public class Exercicio01
{
    public static void Executar() // Esse método não pertence a uma instância, mas à classe em si.
    {
        int totalSum = 0;
        List<int> numeros = new List<int>();
        // int[] numeros = {} listas definidas dessa forma tem tamanho fixo
        // para fazer essa estrutura de forma correta tenho de usar o do/while porque ele entra no loop mesmo se a condição for falsa desde o início
        Console.WriteLine("Bem vindo ao jogo:");
        string continuar = "";
        
        do // do é um escopo, tudo iniciado dentro dele morre aqui dentro mesmo.
        {
            int valor = int.Parse(Console.ReadLine());
            numeros.Add(valor);
            Console.WriteLine("Deseja continuar? (S/N)");
            continuar = Console.ReadLine();
        } while (continuar == "S");

        foreach (int par in numeros)
        {
            if (par % 2 == 0)
            {
                totalSum += 1;
            }
        }

        Console.WriteLine($"A quantidade de números pares presentes aqui é {totalSum}");
    }
}


// O while é uma estrutura de repetição que irá repetir o bloco de código enquanto uma determinada condição for verdadeira, 
// geralmente o while é utilizando quando não sabemos quantas vezes o trecho de código em questão deve ser repetido.

//Além da estrutura for no C# também temos a estrutura foreach, 
//basicamente a estrutura foreach serve para que possamos percorrer os elementos de uma estrutura de dados de forma mais simples e menos verbosa.

// O foreach foi adicionado pois na maioria das vezes que precisamos percorrer os elementos de uma coleção não nos interessa o índice daquela coleção 
//e sim o seu valor e antes da existência do foreach era necessário utilizar o for e percorrer os elementos de uma coleção utilizando os índices da mesma.
