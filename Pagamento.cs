using System;

namespace Aula08Abstração
{
    public class Pagamento
    {
        public DateTime data {  get; set; }

        public float valor  {  get; set; }

        public string Pagar(float valorPago){
            return "Valor pago $"+valorPago;
        }

        public string Cancelar(){
            return "Pagamento cancelado";
        }


    }
}