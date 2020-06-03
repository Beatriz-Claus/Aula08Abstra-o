using System;

namespace Aula08Abstração
{
    public class Cartao : Pagamento
    {
        protected string token = "yte4w5esdyu6679weu8uew099wurj34hf78sdbfhbsyduwbwjjfsisdnkfsi";

        public string titular {  get; set; }

        public int numero {  get; set; }

        public string cvv {  get; set; }

        public string bandeira {  get; set; }


        private bool ValidarToken(){
            if (token != null){
                return true;
            }
            return false;
        }
    }
}