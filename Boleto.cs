using System;

namespace Aula08Abstração
{
    public class Boleto : Pagamento
    {
        public DateTime dataVencimento {  get; set; }

        public string bancoemissor {  get; set; }

        public string codDeBarras {  get; set; }


        public string Registrar(){
            return "Boleto registrado com sucesso!";
        }

        
    }
}