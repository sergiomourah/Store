using Store.Domain.Entidades;
using Store.Domain.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Pagamento
{
    public class FormaPagamento : Entidade
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool IsBoleto
        {
            get { return Id == (int)TipoFormaPagamento.Boleto; }
        }

        public bool IsCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamento.CartaoCredito; }
        }

        public bool IsDeposito
        {
            get { return Id == (int)TipoFormaPagamento.Deposito; }
        }

        public bool IsNotDefinido
        {
            get { return Id == (int)TipoFormaPagamento.NaoDefinido; }
        }
    }
}
