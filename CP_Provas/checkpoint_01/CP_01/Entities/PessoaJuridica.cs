namespace CP_01.Entities;

public class PessoaJuridica : Pessoa
{
    public PessoaJuridica(string nome, double renda) : base(nome, renda)
    {
    }

    public override decimal CalcularImposto()
    {
        if (Renda <= 10000)
        {
            return (decimal) Renda - (decimal) Renda * 0.84m;
        }
        return (decimal) Renda - (decimal) Renda * 0.78m;
    }
}