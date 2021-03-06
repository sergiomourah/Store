﻿using Store.Domain.Entidades;
using Store.Domain.Interfaces;
using Store.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Repository.Repository
{
    public class PedidoRepository : BaseRespository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(StoreContext storeContext) : base(storeContext)
        {
        }
    }
}
