using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escolha uma das opções abaixo para mostrar a data atual: ");

        Console.WriteLine("1. Formato completo(dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
        Console.WriteLine("2. Apenas a data no formato \"dd/MM/aaaa\"");
        Console.WriteLine("3. Apenas a hora no formato de 24 horas.");
        Console.WriteLine("4. A data com o mês por extenso.");

        Console.WriteLine("\n\n\n");

        var opcao = Console.ReadLine();

        Console.WriteLine("\n\n\n");

        switch (opcao)
        {
            case "1":
                Console.WriteLine(DateTime.Now.ToString("F", new CultureInfo("pt-BR")));
                break;
            case "2":
                Console.WriteLine(DateTime.Now.ToString("d", new CultureInfo("pt-BR")));
                break;
            case "3":
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.ffff", new CultureInfo("pt-BR")));
                break;
            case "4":
                Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy", new CultureInfo("pt-BR")));
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}