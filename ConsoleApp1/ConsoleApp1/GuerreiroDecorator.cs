public abstract class GuerreiroDecorator : IGuerreiro
{

    protected IGuerreiro _guerreiro;

    public GuerreiroDecorator(IGuerreiro guerreiro)
    {
        _guerreiro = guerreiro;
    }
    public virtual string getNome()
    {
        return _guerreiro.getNome();
    }
    public virtual void setNome(string nome)
    {
        _guerreiro.setNome(nome);
    }
    public virtual void setVida(double d)
    {
        _guerreiro.setVida(d);
    }
    public virtual string Itens()
    {
        return _guerreiro.Itens();
    }
    public virtual double Defesa()
    {
        return _guerreiro.Defesa();
    }
    public virtual double Ataque()
    {
        return _guerreiro.Ataque();
    }
    public virtual double getVida()
    {
        return _guerreiro.getVida();
    }
    public virtual bool HaveAnel()
    {
        return _guerreiro.HaveAnel();
    }
    public virtual int Esferas()
    {
        return _guerreiro.Esferas();
    }
    public virtual void adicionarEsfera()
    {
        Console.WriteLine("Não tem o anel");
    }

    public virtual void Atacar(IGuerreiro a)
    {
        Console.WriteLine(getNome() + " atacou " + a.getNome());
        a.Defender(Ataque());
        if (a.HaveAnel())
        {
            Console.WriteLine(a.getNome() + " revidou " + (a.Esferas()*10) + "% do dano");
            setVida(getVida() - (Ataque()-a.Defesa()) * 0.1 * a.Esferas());
        }
    }
    public virtual void Defender(double dano)
    {
        if (dano > Defesa())
        {
            setVida(getVida() - (dano - Defesa()));

            if (getVida() <= 0)
            {
                setVida(0);
                Console.WriteLine(getNome() + " morreu");
            }
        }
        else
        {
            Console.WriteLine(getNome() + " defendeu o ataque");
        }
    }
}