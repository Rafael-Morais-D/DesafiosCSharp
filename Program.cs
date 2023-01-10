/* EXERCÍCIO USANDO O != */

/* Console.WriteLine("Digite sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());

if(idade >= 60)
{
    Console.WriteLine("Você já chegou à terceira idade");
}
else if(idade >= 18)
{
    Console.WriteLine("Você é um adulto");
    int anosParaIdoso = 60 - idade;
    Console.WriteLine($"Faltam {anosParaIdoso} para você ser chegar a terceira idade");
}
else
{
    Console.WriteLine("Você ainda é menor de idade");
    int anosParaAdulto = 18 - idade;
    Console.WriteLine($"Faltam {anosParaAdulto} para você ser um adulto");
} */

/* DESAFIO */

string nomeJogador;
bool validacaoJogador;

Console.WriteLine("Bem-vindo ao torneio de Poker!");
Console.WriteLine("Qual o nome do jogador?");

nomeJogador = Console.ReadLine().ToString();

switch (nomeJogador)
{
    case "Rafael":
    case "Rodrigo":
    case "Renata":
    case "Miriam":
    case "Newton":
    case "Aida":
    case "Fabiana":
    case "Leandro":
        Console.WriteLine("Jogador autorizado");
        validacaoJogador = true;
        break;
    default:
        Console.WriteLine("Jogador não autorizado");
        validacaoJogador = false;
        break;
}

if (validacaoJogador)
{
    Console.WriteLine("Quantas vitórias você conquistou?");
    int vitorias = Convert.ToInt32(Console.ReadLine());
    int pontuacao = VerificarPontuacao(vitorias);
    Console.WriteLine($"Com {vitorias} você ficou com {pontuacao} pontos no torneio");
}




int VerificarPontuacao (int vitorias)
{
    const int fatorVitoria = 3;
    int pontuacao =  vitorias * fatorVitoria;

    return pontuacao;
}