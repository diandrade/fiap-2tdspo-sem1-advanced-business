namespace Introducao_OOP.Introducao_dotNet;

public class DN_06_IncrementoDecremento
{
    public DN_06_IncrementoDecremento()
    {
        int contador = 1;
        contador += 1;
        
        Console.WriteLine("Contador: {0}", ++contador);
    }
}