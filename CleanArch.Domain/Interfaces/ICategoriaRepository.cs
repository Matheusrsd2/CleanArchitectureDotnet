using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> ObterCategorias();
        Task<Categoria> ObterPorId(string id);
        Task Criar(Categoria categoria);
        Task Atualizar(Categoria categoria);
        Task Remover(Categoria categoria);


    }
}
