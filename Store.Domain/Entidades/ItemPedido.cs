using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Entidades
{
    public class ItemPedido : Entidade
    {
        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

    }
}
