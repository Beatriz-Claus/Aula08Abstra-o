using System;

namespace Aula08Abstração
{
    public class CartaoDebito : Cartao
    {
        
        public float saldo {  get; set; }

        public string Transferir(){
            return "Transferência efetuada!";
        }

        public string PagarTitulo(){
            return "Título pago!";
        }
    }
}