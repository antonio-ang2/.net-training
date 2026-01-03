Console.WriteLine("Digite sua nota em geografia:");
int nota = int.Parse(Console.ReadLine()!);
Console.WriteLine("Digite sua nota em matematica:");
int nota2 = int.Parse(Console.ReadLine()!);

int Media(int geo, int mat)
{
    int media = (geo + mat)/2;
    Escala(media);
    return media;
}

string Escala(int nota)
{
    string escala = "";
    if (nota >= 90)
    {   
        escala = "A";
    }
    else if (nota > 80 && nota < 90)
    {
        escala = "B";
    }
    else
    {
        escala = "C";
    }
    Console.WriteLine($"Sua nota do bimestre É {escala}");
    return escala;
}

Media(nota, nota2);