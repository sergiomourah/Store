using Store.Domain.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store.Domain.Entidades
{
    public class Pedido : Entidade
    {
        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string Cep { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public string NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        public virtual ICollection<ItemPedido> ItemPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (!ItemPedidos.Any())
                AddMessage("Informe um item do pedido!");

            if (string.IsNullOrEmpty(Cep))
                AddMessage("Informe o CEP!");
        }
    }
}
