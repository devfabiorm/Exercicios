using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite a placa do carro: ");
        var placa = Console.ReadLine();

        Console.WriteLine(ValidadorDePlaca(placa) ? "Verdadeiro" : "Falso");
    }

    static bool ValidadorDePlaca(string placa)
    {
        if (placa == null)
        {
            return false;
        }

        return Regex.IsMatch(placa, "[a-zA-Z]{3}-?[0-9]{4}");
    }
}