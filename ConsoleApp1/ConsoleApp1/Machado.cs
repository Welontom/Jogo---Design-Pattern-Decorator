public class Machado : GuerreiroDecorator{
  public Machado(IGuerreiro guerreiro) : base(guerreiro){}
  
  public override string Itens(){
    return base.Itens() + "machado ";
  }
  public override double Ataque(){
    return base.Ataque() + 12.0;
  }
}