namespace CP_01.Entities;

public abstract class Pessoa
{
    protected string Nome;
    protected double Renda;

    public Pessoa(string nome, double renda)
    {
        Renda = renda;
        Nome = nome;
    }

    public abstract decimal CalcularImposto();
}