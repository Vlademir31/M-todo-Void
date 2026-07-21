//Crie um método do tipo void chamado MostrarIdade
// deve receber o ano de nascimento (int), 
// calcular a idade baseada no ano atual e exibir no console.writeline

Console.WriteLine("Digite o seu ano de nascimento: ");
int anoDigitado = int.Parse(Console.ReadLine());

MostrarIdade(anoDigitado);

void MostrarIdade(int anoNascimento)
{
    int idade = 2026 - anoNascimento;

    Console.WriteLine($"Sua idade em 2026 será: {idade} anos. ");
}