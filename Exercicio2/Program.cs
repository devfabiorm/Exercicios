public class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Por favor, digite seu primeiro nome: ");
        var nome = Console.ReadLine();

        Console.Write("Agora, por favor, digite seu sobrenome: ");
        var sobrenome = Console.ReadLine();

        Console.WriteLine($"\n\nSeu nome completo é: {nome} {sobrenome}");

        Console.WriteLine("\n\nDigite qualquer tecla para sair...");
        Console.ReadKey(true);
    }
}