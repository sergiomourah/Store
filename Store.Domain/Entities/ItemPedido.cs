using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Entidades
{
    public class ItemPedido : Entidade
    {
        public int ProdutoId { get; set; }

        public virtual Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (ProdutoId == 0)
                AddMessage("Informe um produto!");

            if (Quantidade == 0)
                AddMessage("Informe a quantidade do produto!");
        }
    }
}
