Console.WriteLine("Escolha o exercício:");
Console.WriteLine("1 - Descobrir quantos números pares na lista");
Console.WriteLine("2 - Descobrir o maior valor de uma lista");

var opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        Exercicio01.Executar();
        break;
    case "2":
        Exercicio02.Executar();
        break;

    default:
        Console.WriteLine("Opção inválida");
        break;
}

