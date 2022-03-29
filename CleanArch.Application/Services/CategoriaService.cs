using AutoMapper;
using CleanArch.Application.DTOs;
using CleanArch.Application.Interfaces;
using CleanArch.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;
        private readonly IMapper _mapper;    
        public CategoriaService(ICategoriaRepository repository, IMapper mapper)
        {
            _repository = repository;   
            _mapper = mapper;
        }

        public Task Adicionar(CategoriaDTO categoriaDTO)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(CategoriaDTO categoriaDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoriaDTO> ObterCategoriaPorId(int id)
        {
            var categoria = await _repository.ObterPorId(id);
            return _mapper.Map<CategoriaDTO>(categoria);    
        }

        public async Task<IEnumerable<CategoriaDTO>> ObterCategorias()
        {
            var CategoriaEntity = await _repository.ObterCategorias();
            return _mapper.Map<IEnumerable<CategoriaDTO>>(CategoriaEntity); 
        }

        public Task Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
