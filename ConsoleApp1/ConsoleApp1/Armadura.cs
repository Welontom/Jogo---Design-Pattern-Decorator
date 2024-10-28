public class Armadura : GuerreiroDecorator{
  public Armadura(IGuerreiro guerreiro) : base(guerreiro){}
  
  
  public override string Itens(){
    return base.Itens() + "armadura ";
  }
  public override double Defesa(){
    return base.Defesa() + 10.0;
  }
}