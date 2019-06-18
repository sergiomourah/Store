﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Entidades
{
    public class Pedido : Entidade
    {
        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string Cep { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public string NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }

        public ICollection<ItemPedido> ItemPedidos { get; set; }
    }
}
