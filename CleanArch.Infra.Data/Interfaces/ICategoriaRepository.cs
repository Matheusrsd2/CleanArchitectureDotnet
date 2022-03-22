using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> ObterCategorias();
        Task<Categoria> ObterPorId(int id);
        Task<Categoria> Criar(Categoria categoria);
        Task<Categoria> Atualizar(Categoria categoria);
        Task Remover(Categoria categoria);


    }
}
