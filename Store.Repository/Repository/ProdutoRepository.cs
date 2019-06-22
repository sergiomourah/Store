using Store.Domain.Entidades;
using Store.Domain.Interfaces;
using Store.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Repository.Repository
{
    public class ProdutoRepository : BaseRespository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(StoreContext storeContext) : base(storeContext)
        {

        }
    }
}
