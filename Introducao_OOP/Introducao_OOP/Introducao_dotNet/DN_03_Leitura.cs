namespace Introducao_OOP.Introducao_dotNet;

public class DN_03_Leitura
{
    public DN_03_Leitura()
    {
        Console.WriteLine("Qual é sua idade?: ");
        string? idade = Console.ReadLine();
        
        Console.WriteLine("Sua idade é: " + idade);
    }
}