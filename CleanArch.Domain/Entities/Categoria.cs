using CleanArch.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public sealed class Categoria
    {
        //public Categoria(string nome)
        //{
        //    ValidarDominio(nome);
        //}

        public Categoria(int id, string nome)
        {
            ValidarDominio(id, nome);
        }
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public ICollection<Produto> Produtos { get; set; }

        private void ValidarDominio(int id, string nome)
        {
            DomainExceptionValidation.When(id < 0,
                "Id é menor que 0");

            DomainExceptionValidation.When(string.IsNullOrEmpty(nome),
                "Nome Inválido. O nome é obnrigatório");

            DomainExceptionValidation.When(string.IsNullOrEmpty(nome),
                "Nome Inválido. Necessário ao menos 3 caracteres");

            Nome = nome;
        }
    }
}
