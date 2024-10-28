public class Anel : GuerreiroDecorator
{
    public Anel(IGuerreiro guerreiro) : base(guerreiro) { }

    public int esferas = 1;

    public override void adicionarEsfera()
    {
        if (esferas < 10)
        {
            Console.WriteLine(getNome() + " recebeu uma esfera");
            esferas++;
        }
        else {
            Console.WriteLine(getNome() + " possui todas as esferas");
        }

    }

    public override int Esferas()
    {
        return esferas;
    }
    public override string Itens()
    {
        return base.Itens() + "anel ";
    }

    public override bool HaveAnel()
    {
        return true;
    }
}
