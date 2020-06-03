using System;

namespace Aula08Abstração
{
    public class CartaoCredito : Cartao 
    {

        public float limite {  get; set; }

        public void AumentarLimite( float acrescimo ){

            token = "ejfhyuugrfhsb";

            limite = limite + acrescimo;
        }
    }
}