using AutoMapper;
using Fiap.Application.Interfaces;
using Fiap.Application.ViewModels;
using Fiap.Domain.Interfaces;
using Fiap.Domain.Models;
using System;
using System.Collections.Generic;

namespace Fiap.Application.Services
{
    public class EnderecoApplicationServiceGenerico : IEnderecoApplicationServiceGenerico
    {
        private readonly ICadastroServiceGenerico<Endereco> _cadastroService;
        private readonly IMapper _mapper;

        public EnderecoApplicationServiceGenerico(ICadastroServiceGenerico<Endereco> cadastroService, IMapper mapper)
        {
            _cadastroService = cadastroService;
            _mapper = mapper;
        }

        public EnderecoViewModel AdicionarCadastro(EnderecoViewModel viewModel)
        {
            var entity = _mapper.Map<Endereco>(viewModel);
            var entities = ObterCadastros().OrderBy(x => x.Id_Endereco).LastOrDefault();
            entity.Id_Endereco = entities.Id_Endereco + 1;
            var addedEntity = _cadastroService.AdicionarCadastro(entity);
            return _mapper.Map<EnderecoViewModel>(addedEntity);
        }

        public EnderecoViewModel AtualizarCadastro(EnderecoViewModel viewModel)
        {
            var entity = _mapper.Map<Endereco>(viewModel);
            var updatedEntity = _cadastroService.AtualizarCadastro(entity);
            return _mapper.Map<EnderecoViewModel>(updatedEntity);
        }

        public string DeletarCadastro(int id)
        {
            return _cadastroService.DeletarCadastro(id);
        }

        public EnderecoViewModel ObterCadastro(int id)
        {
            var entity = _cadastroService.ObterCadastro(id);
            return _mapper.Map<EnderecoViewModel>(entity);
        }

        public IEnumerable<EnderecoViewModel> ObterCadastros()
        {
            var entities = _cadastroService.ObterCadastros();
            var viewModels = new List<EnderecoViewModel>();

            foreach (var entity in entities)
            {
                viewModels.Add(_mapper.Map<EnderecoViewModel>(entity));
            }

            return viewModels;
        }
    }
}
