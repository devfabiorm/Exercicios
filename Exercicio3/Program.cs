internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite um número, por favor: ");
        var primeiroNumero = Console.ReadLine();
        Console.WriteLine("Digite outro número, por favor: ");
        var segundoNumero = Console.ReadLine();

        (double valor1, double valor2) = Conversor(primeiroNumero, segundoNumero);

        Console.WriteLine($"A soma entre os números {valor1} e {valor2} é: {Adicao(valor1, valor2)}");
        Console.WriteLine($"A subtração entre os números {valor1} e {valor2} é: {Subtracao(valor1, valor2)}");

        Console.WriteLine($"A multiplicação entre os números {valor1} e {valor2} é: {Multiplicacao(valor1, valor2)}");

        var (resultado, mensagemErro) = Divisao(valor1, valor2);

        if (mensagemErro is null)
            Console.WriteLine($"A divisão entre os números {valor1} e {valor2} é: {resultado}");
        else
            Console.WriteLine(mensagemErro);

        
        Console.WriteLine($"A média entre os números {valor1} e {valor2} é: {Media(valor1, valor2)}");
    }
    
    static (double valor1, double valor2) Conversor(string valor1, string valor2) 
    {
        if (string.IsNullOrEmpty(valor1) || string.IsNullOrEmpty(valor2))
            throw new ArgumentException("Nenhum dos valores pode ser nulo ou vázio.");

        if(!double.TryParse(valor1, out double valor1EmDecimal))
            throw new ArgumentException("O valor não pôde ser convertido em um decimal", nameof(valor1));

        if (!double.TryParse(valor2, out double valor2EmDecimal))
            throw new ArgumentException("O valor não pôde ser convertido em um decimal", nameof(valor2));

        return (valor1EmDecimal, valor2EmDecimal);
    }
    static double Adicao(double valor1, double valor2) => valor1 + valor2;
    static double Subtracao(double valor1, double valor2) => valor1 - valor2;
    static double Multiplicacao(double valor1, double valor2) => valor1 * valor2;

    static (double valor, string? mensagemErro) Divisao(double valor1, double valor2)
    {
        if (valor2 == 0)
            return (double.MinValue, "Não existe divisão por zero");

        return (valor1 / valor2, null);
    }

    static double Media(double valor1, double valor2) => (valor1 + valor2) / 2;
}