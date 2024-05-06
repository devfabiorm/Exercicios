internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite algum texto: ");
        var texto = Console.ReadLine();

        int contador = 0;

        for (int i = 0; i < texto?.Length; i++)
        {
            if (texto[i] == ' ')
                continue;

            contador++;
        }

        Console.WriteLine($"A quantidade de caracteres válidos (não espaços) digitados é: {contador}");
    }
}