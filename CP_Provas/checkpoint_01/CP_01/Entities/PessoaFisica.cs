namespace CP_01.Entities;

public class PessoaFisica : Pessoa
{
    public PessoaFisica(string nome, double renda) : base(nome, renda)
    {
    }

    public override decimal CalcularImposto()
    {
        if (Renda <= 2000)
        {
            return (decimal) Renda - (decimal) Renda;
        }

        if (Renda <= 5000)
        {
            return (decimal) Renda - (decimal) Renda * 0.85m;
        }

        return (decimal) Renda - (decimal) Renda * 0.73m;
    }
}