public interface IGuerreiro
{

    void setNome(string nome);
    string getNome();
    int Esferas();
    double getVida();
    string Itens();
    bool HaveAnel();
    double Defesa();
    double Ataque();
    void Atacar(IGuerreiro a);
    void Defender(double dano);
    void setVida(double d);
    void adicionarEsfera();
}