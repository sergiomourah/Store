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

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Nome))
                AddMessage("Informe o nome para o Produto!");

            if (Preco > decimal.Zero)
                AddMessage("Informe o preço para o Produto!");
        }
    }
}
