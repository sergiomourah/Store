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
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }

        public bool IsCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }

        public bool IsDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }

        public bool IsNotDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Nome))
                AddMessage("Informe uma forma de pagamento!");
        }
    }
}
