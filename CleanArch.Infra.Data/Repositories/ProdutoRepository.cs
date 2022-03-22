using CleanArch.Domain.Entities;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext context)
        {
            _context = context; 
        }
        public async Task<Produto> Atualizar(Produto produto)
        {
            _context.Update(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task<Produto> Criar(Produto produto)
        {
            _context.Add(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task<IEnumerable<Produto>> ObterProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> ObterPorId(int id)
        {
            return await _context.Produtos.FindAsync(id);
        }

        public async Task Remover(Produto produto)
        {
            Produto remove = _context.Produtos.FirstOrDefault(x => x.Id == produto.Id);
            _context.Remove(remove);
            await _context.SaveChangesAsync();
        }
    }
}
