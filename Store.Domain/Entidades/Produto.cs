using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Entidades
{
    public class Produto : Entidade
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

    }
}
