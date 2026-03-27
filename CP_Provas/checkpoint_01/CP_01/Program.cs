using CP_01.Entities;

while (true)
{
    Console.WriteLine(new string('-', 25));
    Console.WriteLine("CALCULADORA DE IMPOSTOS");
    Console.WriteLine(new string('-', 25));
    Console.WriteLine("Selecione a opção desejada:");
    Console.WriteLine("1 → Pessoa Física");
    Console.WriteLine("2 → Pessoa Jurídica");
    Console.WriteLine("0 → Sair");
    Console.WriteLine(new string('-', 25));
    
    int opcao = int.Parse(Console.ReadLine());
    Console.WriteLine(new string('-', 25));

    switch (opcao)
    {
        case 1:
            Console.Write("Nome: ");
            string nomeF = Console.ReadLine();
            Console.Write("Renda Anual: ");
            double rendaF = double.Parse(Console.ReadLine());
        
            PessoaFisica pessoafisica = new PessoaFisica(nomeF, rendaF);
            Console.WriteLine($"Imposto a pagar (Pessoa Física): {pessoafisica.CalcularImposto():C}");
            break;

        case 2:
            Console.Write("Nome da Empresa: ");
            string nomeJ = Console.ReadLine();
            Console.Write("Renda Anual: ");
            double rendaJ = double.Parse(Console.ReadLine());
        
            PessoaJuridica pessoaJuridica = new PessoaJuridica(nomeJ, rendaJ);
            Console.WriteLine($"Imposto a pagar (Pessoa Jurídica): {pessoaJuridica.CalcularImposto():C}");
            break;

        case 0:
            Console.WriteLine("Encerrando o programa...");
            return;

        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }
}