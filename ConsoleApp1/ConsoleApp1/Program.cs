public class Program
{
    public static void Main(string[] args)
    {
        IGuerreiro guerreiroa = new Guerreiro(50);
        IGuerreiro guerreirob = new Guerreiro(50);
        IGuerreiro armaduraa = new Armadura(guerreiroa);
        IGuerreiro armadurab = new Armadura(guerreirob);
        IGuerreiro Arthur = new EspadaFlamejante(armaduraa);
        IGuerreiro machado = new Machado(armadurab);
        IGuerreiro Eduardo = new Anel(machado);
        Eduardo.setNome("Eduardo");
        Arthur.setNome("Arthur");

        int opc = 0;

        do
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine(Arthur.getNome());
            Console.WriteLine(Arthur.Itens());
            Console.WriteLine("Vida: " + Arthur.getVida());
            Console.WriteLine("Ataque: " + Arthur.Ataque());
            Console.WriteLine("Defesa: " + Arthur.Defesa());
            Console.WriteLine("------------------------------");
            Console.WriteLine(Eduardo.getNome());
            Console.WriteLine(Eduardo.Itens());
            Console.WriteLine("Esferas: " + Eduardo.Esferas());
            Console.WriteLine("Vida: " + Eduardo.getVida());
            Console.WriteLine("Ataque: " + Eduardo.Ataque());
            Console.WriteLine("Defesa: " + Eduardo.Defesa());
            Console.WriteLine("------------------------------");

            Console.WriteLine("1 - Eduardo ataca");
            Console.WriteLine("2 - Arthur ataca");
            Console.WriteLine("3 - Adicionar 1 esfera ao anel de Eduardo");
            Console.WriteLine("0 - Sair");
            opc = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");
            switch (opc)
            {
                case 1:
                    Eduardo.Atacar(Arthur);
                    break;
                case 2:
                    Arthur.Atacar(Eduardo);
                    break;
                case 3:
                    Eduardo.adicionarEsfera();
                    break;
                default:
                    break;
            }

        } while (Arthur.getVida() != 0 && Eduardo.getVida() != 0 && opc != 0);
    }
}