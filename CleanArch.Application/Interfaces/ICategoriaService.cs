using CleanArch.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaDTO>> ObterCategorias();
        Task<CategoriaDTO> ObterCategoriaPorId(int id);
        Task Adicionar(CategoriaDTO categoriaDTO);  
        Task Atualizar(CategoriaDTO categoriaDTO);  
        Task Remover(int id);    
    }
}
