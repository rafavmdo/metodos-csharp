/*
DEsenvolva a solução aqui em Program.cs, quando terminar cole o conteúdo 
no respectivo arquivo
*/

static string LerNomeAluno()
{
    Console.Write("Digite o nome do aluno: ");
    string nome = Console.ReadLine()!;
    return nome;
}

static double LerNota(string mensagem)
{
    Console.Write(mensagem);
    double nota = double.Parse(Console.ReadLine()!);
    return nota;
}

static double CalcularMedia(double nota1, double nota2, double nota3)
{
    return (nota1 + nota2 + nota3) / 3;
}

static string VerificarSituacao(double media)
{
    if (media >= 7)
    {
        return "Aprovado";
    }
    else if (media >= 5 && media < 7)
    {
        return "Em recuperação";
    }
    else
    {
        return "Reprovado";
    }
}

static void ExibirResultado(string nome, double media, string VerificarSituacao)
{
    Console.WriteLine($"Nome do aluno: {nome}");
    Console.WriteLine($"Media do aluno: {media:F2}");
    Console.WriteLine($"Situação do aluno: {VerificarSituacao}");
}

static void ExecutarSistema()
{
    string nome = LerNomeAluno();

    double nota1 = LerNota("Nota 1: ");
    double nota2 = LerNota("Nota 2: ");
    double nota3 = LerNota("Nota 3: ");

    double media = CalcularMedia(nota1, nota2, nota3);
    string situacao = VerificarSituacao(media);

    ExibirResultado(nome, media, situacao);
}

ExecutarSistema();