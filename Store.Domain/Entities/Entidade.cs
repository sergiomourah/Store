using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store.Domain.Entidades
{
    public abstract class Entidade
    {
        public int Id { get; set; }

        private List<string> _mensagensValidacao { get; set; }

        private List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AddMessage(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();

        protected bool IsValid
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
