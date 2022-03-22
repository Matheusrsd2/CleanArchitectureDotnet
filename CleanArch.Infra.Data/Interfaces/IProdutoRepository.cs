using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Interfaces
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> ObterProdutos();
        Task<Produto> ObterPorId(int id);
        Task<Produto> Criar(Produto produto);
        Task<Produto> Atualizar(Produto produto);
        Task Remover(Produto produto);
    }
}
