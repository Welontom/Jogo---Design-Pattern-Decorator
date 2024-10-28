public class EspadaFlamejante : GuerreiroDecorator{
  public EspadaFlamejante(IGuerreiro guerreiro) : base(guerreiro){}
  
  public override string Itens(){
    return base.Itens() + "espada flamejante ";
  }
  public override double Ataque(){
    return base.Ataque() + 20.0;
  }
}