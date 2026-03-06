namespace Introducao_OOP.Introducao_dotNet;

public class DN_07_Comparacao
{
    public DN_07_Comparacao()
    {
        int numero1 = 10;
        int numero2 = 20;
        
        bool resultado1 = numero1 > numero2;
        Console.WriteLine("Resultado1: {0}", resultado1);
        
        bool resultado2 = numero1 < numero2;
        Console.WriteLine("Resultado2: {0}", resultado2);
        
        bool resultado3 = numero1 == numero2;
        Console.WriteLine("Resultado3: {0}", resultado3);
        
        bool resultado4 = numero1 != numero2;
        Console.WriteLine("Resultado4: {0}", resultado4);
        
        bool resultado5 = numero1 <= numero2;
        Console.WriteLine("Resultado5: {0}", resultado5);
        
        bool resultado6 = numero1 >= numero2;
        Console.WriteLine("Resultado6: {0}", resultado6);
    }
}