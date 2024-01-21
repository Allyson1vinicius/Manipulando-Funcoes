using System;

Console.WriteLine("Ola, seja bem vindo.");
// Solicita o nome do usuário, quilômetros percorridos por dia, 
// Horas de uso de eletrônicos por dia e o número de refeições com carne:
Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();
Console.WriteLine("Digite os quilometros por dia:");
double quilometrosPorDia = double.Parse(Console.ReadLine());
Console.WriteLine("Digite as horas de eletronicos:");
int horasDeEletronicos = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de refeições com carne:");
int refeicoesComCarne = int.Parse(Console.ReadLine());

// Chama o método para calcular a pegada de carbono
double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);

// TODO: Exiba o resultado para o usuário:
Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

// Aguarda a entrada do usuário antes de encerrar o programa:
Console.ReadLine();

// TODO: Crie um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos:
double CalcularPegadaDeCarbono(double kmPorDia, int horasDeEletronicos, int quantRefeicoes)
{
    return ((kmPorDia * 365 * 0.2) + (horasDeEletronicos * 0.1) + (quantRefeicoes * 0.5));
}
