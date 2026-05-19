/*
Um professor deseja criar um programa para ajudar alunos do ensino fundamental a 
estudar tabuada. O sistema deve permitir que o usuário escolha um número e exibir 
a tabuada de 1 até 10.
*/


static int LerNumero(string mensagem)
{
    Console.WriteLine(mensagem);
    int numero = int.Parse(Console.ReadLine()!);
    return numero;
}

static void ExibirTabuada(int numero)
{
    Console.WriteLine($"Tabuada do {numero}");
    int tabuada = 0;

    while (tabuada <= 10)
    {
        Console.WriteLine($"{numero} x {tabuada} = {numero * tabuada}");
        tabuada += 1;
    }
}

static void ExecutarSistema()
{
    int numero = LerNumero("Digite o número para ver a sua tabuada: ");
    ExibirTabuada(numero);
}

ExecutarSistema();
