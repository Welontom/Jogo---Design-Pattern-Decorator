public class Guerreiro : IGuerreiro
{

    public double Vida;
    public string Nome;

    public Guerreiro(double vida)
    {
        Vida = vida;
    }
    public void setNome(string nome)
    {
        Nome = nome;
    }
    public string getNome()
    {
        return Nome;
    }
    public double getVida()
    {
        return Vida;
    }
    public bool HaveAnel()
    {
        return false;
    }
    public void setVida(double d)
    {
        Vida = d;
    }
    public string Itens()
    {
        return "Itens: ";
    }
    public double Defesa()
    {
        return 10;
    }
    public double Ataque()
    {
        return 15;
    }
    public int Esferas()
    {
        return 0;
    }
    public virtual void adicionarEsfera() { }

    public void Atacar(IGuerreiro a)
    {
        a.Defender(Ataque());
    }
    public void Defender(double dano)
    {
        if (dano > Defesa())
        {
            Vida -= (dano - Defesa());
            if (Vida <= 0)
            {
                Vida = 0;
            }
        }
        else
        {
            Console.WriteLine(getNome() + " Defendeu o ataque");
        }
    }
}