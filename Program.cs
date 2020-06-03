using System;

namespace Aula08Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cartão 1


            CartaoCredito visa = new CartaoCredito();
            visa.limite = 3000f;

           Console.WriteLine("Deseja aumentar o limite? Quanto de acréscimo?");
           float acres = float.Parse( Console.ReadLine() );


           visa.AumentarLimite(acres);
           Console.WriteLine("Novo limite: R$ "+visa.limite);

           //Cartão 2

           CartaoCredito elo = new CartaoCredito();
            elo.limite = 3000f;

           elo.limite = 1500f;
           
           Console.WriteLine("Quanto acrescentar no limite?");
           float soma = float.Parse( Console.ReadLine() );


           visa.AumentarLimite(acres);
           Console.WriteLine("Novo limite: R$ "+elo.limite);

        }
    }
}
