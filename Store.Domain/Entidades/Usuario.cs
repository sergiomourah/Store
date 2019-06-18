using System.Collections.Generic;

namespace Store.Domain.Entidades
{
    public class Usuario : Entidade
    {
        public string Email { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
