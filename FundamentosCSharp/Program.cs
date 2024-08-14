// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Text.RegularExpressions;



var opcao = "0";

do  {
    Console.WriteLine("Selecione o app a ser utilizado:\n");

    Console.WriteLine("1 - Imprimir saudação");
    Console.WriteLine("2 - Concatenar nomes");
    Console.WriteLine("3 - Calculadora");
    Console.WriteLine("4 - Contar palavra");
    Console.WriteLine("5 - Verificar placa");
    Console.WriteLine("6 - Mostrar data atual");
    Console.WriteLine("0 - Sair");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            ImprimirSaudacao();
            break;
        case "2":
            ConcatenarNomes();
            break;
        case "3":
            CalcularNumeros();
            break;
        case "4":
            ContarPalavra();
            break;
        case "5":
            VerificarPlaca();
            break;
        case "6":
            ImprimirDataAtual();
            break;
        case "0":
            Console.WriteLine("Finalizado...");
            break;
        default:
            Console.WriteLine("opção inválida!");
            break;

    }
} while (opcao != "0");

Console.ReadLine();

void ImprimirSaudacao()
{
    Console.WriteLine("Digite o seu nome:");
    var nome = Console.ReadLine();

    Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!\n");
}

void ConcatenarNomes() {
    Console.WriteLine("Informe o nome:");
    var nome = Console.ReadLine();

    Console.WriteLine("Informe o sobrenome:");
    var sobrenome = Console.ReadLine();

    Console.WriteLine($"{nome} {sobrenome}");
    Console.Read();
}

void CalcularNumeros()
{
    Console.WriteLine("Informe primeiro número:");
    double numero1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe segundo número:");
    double numero2 = double.Parse(Console.ReadLine());
    double soma = numero1 + numero2;
    double subtracao = numero1 + numero2;
    double multiplicacao = numero1 * numero2;
    double media = (numero1 + numero2) / 2;

    Console.WriteLine($"Soma: {soma}");
    Console.WriteLine($"Subtração: {subtracao}");
    Console.WriteLine($"Multiplicação: {multiplicacao}");
    Console.WriteLine($"Média: {media}");

    if (numero2 == 0)
        Console.WriteLine("Divisão: Não é permitido dividir por zero!");
    else
    {
        double divisao = numero1 / numero2;
        Console.WriteLine($"Divisão: {divisao}");
    }

    Console.Read();
}

void ContarPalavra()
{
    Console.WriteLine("Informe uma palavra:");
    string palavra = Console.ReadLine();


    Console.WriteLine($"A palavra tem {palavra.Count()} letra(s)");
}

void VerificarPlaca()
{
    Console.WriteLine("Informe a placa:");
    string placa = Console.ReadLine();

    string pattern = @"^[A-Za-z]{3}\d{4}$";

    bool isMatch = Regex.IsMatch(placa, pattern);

    if (isMatch)
    {
        Console.WriteLine("A placa está correta.");
    }
    else
    {
        Console.WriteLine("A placa é inválida.");
    }
}

void ImprimirDataAtual()
{
    DateTime dataAtual = DateTime.Now;
    Console.WriteLine("Escolha um formato de exibição da data atual:");
    Console.WriteLine("1. Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
    Console.WriteLine("2. Apenas a data no formato \"01/03/2024\"");
    Console.WriteLine("3. Apenas a hora no formato de 24 horas");
    Console.WriteLine("4. A data com o mês por extenso");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Formato completo: " + dataAtual.ToString("F", new CultureInfo("pt-BR")));
            break;
        case "2":
            Console.WriteLine("Data: " + dataAtual.ToString("dd/MM/yyyy"));
            break;
        case "3":
            Console.WriteLine("Hora: " + dataAtual.ToString("HH:mm"));
            break;
        case "4":
            Console.WriteLine("Data com mês por extenso: " + dataAtual.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}