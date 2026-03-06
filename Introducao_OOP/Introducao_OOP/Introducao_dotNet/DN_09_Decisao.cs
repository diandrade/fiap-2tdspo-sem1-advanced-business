namespace Introducao_OOP.Introducao_dotNet;

public class DN_09_Decisao
{
    public DN_09_Decisao()
    {   
        //IF ELSE
        //SWITCH
        //TERNÁRIO

        int codigo = 2;
        if(codigo == 2)
            Console.WriteLine($"Condicao Verdadeiro: {codigo}");
        else
        {
            Console.WriteLine($"Condicao Falsa: {codigo}");
        }
        Console.WriteLine($"Condicao = 2 {(codigo == 2 ? "sim" : "não")}");
    }
}