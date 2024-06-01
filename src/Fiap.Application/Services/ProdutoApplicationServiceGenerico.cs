using AutoMapper;
using Fiap.Application.Interfaces;
using Fiap.Application.ViewModels;
using Fiap.Domain.Interfaces;
using Fiap.Domain.Models;
using System;
using System.Collections.Generic;

namespace Fiap.Application.Services
{
    public class ProdutoApplicationServiceGenerico : IProdutoApplicationServiceGenerico
    {
        private readonly ICadastroServiceGenerico<Produto> _cadastroService;
        private readonly IMapper _mapper;

        public ProdutoApplicationServiceGenerico(ICadastroServiceGenerico<Produto> cadastroService, IMapper mapper)
        {
            _cadastroService = cadastroService;
            _mapper = mapper;
        }

        public ProdutoViewModel AdicionarCadastro(ProdutoViewModel viewModel)
        {
            var entity = _mapper.Map<Produto>(viewModel);
            var entities = ObterCadastros().OrderBy(x => x.Id_Produto).LastOrDefault();
            entity.Id_Produto = entities.Id_Produto + 1;
            var addedEntity = _cadastroService.AdicionarCadastro(entity);
            return _mapper.Map<ProdutoViewModel>(addedEntity);
        }

        public ProdutoViewModel AtualizarCadastro(ProdutoViewModel viewModel)
        {
            var entity = _mapper.Map<Produto>(viewModel);
            var updatedEntity = _cadastroService.AtualizarCadastro(entity);
            return _mapper.Map<ProdutoViewModel>(updatedEntity);
        }

        public string DeletarCadastro(int id)
        {
            return _cadastroService.DeletarCadastro(id);
        }

        public ProdutoViewModel ObterCadastro(int id)
        {
            var entity = _cadastroService.ObterCadastro(id);
            return _mapper.Map<ProdutoViewModel>(entity);
        }

        public IEnumerable<ProdutoViewModel> ObterCadastros()
        {
            var entities = _cadastroService.ObterCadastros();
            var viewModels = new List<ProdutoViewModel>();

            foreach (var entity in entities)
            {
                viewModels.Add(_mapper.Map<ProdutoViewModel>(entity));
            }

            return viewModels;
        }
    }
}
