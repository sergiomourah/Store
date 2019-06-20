using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Store.Domain.Entidades;
using Store.Domain.Pagamento;
using Store.Repository.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Repository.Context
{
    public class StoreContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<ItemPedido> ItensPedidos { get; set; }

        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento()
                { Id = 1, Nome = "Boleto", Descricao = "Forma de Pagamento Boleto" },
                new FormaPagamento()
                { Id = 2, Nome = "CartaoCredito", Descricao = "Forma de Pagamento Cartão de Crédito" },
                new FormaPagamento()
                { Id = 3, Nome = "Deposito", Descricao = "Forma de Pagamento Deposito" });


            base.OnModelCreating(modelBuilder);
        }
    }
}
