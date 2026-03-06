namespace Introducao_OOP.Introducao_dotNet;

public class DN_08_Strings
{
    public DN_08_Strings()
    {
        char valor1 = 'A';
        string nome = "Humberto!";
        string sobrenome = "Almeida";
        
        Console.WriteLine(nome + sobrenome);
        Console.WriteLine($"Nome: {nome} {sobrenome}");
        Console.WriteLine(@"O texto é longo
com quebra de linha.");
        
        Console.WriteLine($"Número de carácteres: {sobrenome.Length}");
        Console.WriteLine($"Maiúsculo: {sobrenome.ToUpper()}");
        Console.WriteLine($"Minúsculo: {sobrenome.ToLower()}");
    }
}