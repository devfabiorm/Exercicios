public class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Por favor, digite seu nome: ");
        var nome = Console.ReadLine();
        Console.WriteLine($"\n\nOlá, {nome}! Seja muito bem-vindo!");

        Console.WriteLine("\n\nDigite qualquer tecla para sair...");
        Console.ReadKey(true);
    }
}