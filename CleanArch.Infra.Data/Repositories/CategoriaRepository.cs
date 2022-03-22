using CleanArch.Domain.Entities;
using CleanArch.Infra.Data.Interfaces;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context; 
        }        
        public async Task<Categoria> Atualizar(Categoria categoria)
        {
            _context.Update(categoria);
            await _context.SaveChangesAsync();
            return categoria;
        }

        public async Task<Categoria> Criar(Categoria categoria)
        {
            _context.Add(categoria);
            await _context.SaveChangesAsync();
            return categoria;
        }

        public async Task<IEnumerable<Categoria>> ObterCategorias()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task<Categoria> ObterPorId(int id)
        {
            return await _context.Categorias.FindAsync(id);             
        }

        public async Task Remover(Categoria categoria)
        {
            Categoria remove = _context.Categorias.FirstOrDefault(x => x.Id == categoria.Id);
            _context.Remove(remove);
            await _context.SaveChangesAsync();  
        }
    }
}
