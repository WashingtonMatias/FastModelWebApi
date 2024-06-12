using AutoMapper;
using Fiap.Application.Interfaces;
using Fiap.Application.ViewModels;
using Fiap.Domain.Interfaces;
using Fiap.Domain.Models;
using System;
using System.Collections.Generic;

namespace Fiap.Application.Services
{
    public class UsuarioApplicationServiceGenerico : IUsuarioApplicationServiceGenerico
    {
        private readonly ICadastroServiceGenerico<Usuario> _cadastroService;
        private readonly IMapper _mapper;

        public UsuarioApplicationServiceGenerico(ICadastroServiceGenerico<Usuario> cadastroService, IMapper mapper)
        {
            _cadastroService = cadastroService;
            _mapper = mapper;
        }

        public UsuarioViewModel AdicionarCadastro(UsuarioViewModel viewModel)
        {
            var entity = _mapper.Map<Usuario>(viewModel);
            var entities = ObterCadastros().OrderBy(x => x.Id_Usuario).LastOrDefault();
            if (entities != null)
                entity.Id_Usuario = entities.Id_Usuario + 1;
            else
                entity.Id_Usuario = 1;
            var addedEntity = _cadastroService.AdicionarCadastro(entity);
            return _mapper.Map<UsuarioViewModel>(addedEntity);
        }

        public UsuarioViewModel AtualizarCadastro(UsuarioViewModel viewModel)
        {
            var entity = _mapper.Map<Usuario>(viewModel);
            var updatedEntity = _cadastroService.AtualizarCadastro(entity);
            return _mapper.Map<UsuarioViewModel>(updatedEntity);
        }

        public string DeletarCadastro(int id)
        {
            return _cadastroService.DeletarCadastro(id);
        }

        public UsuarioViewModel ObterCadastro(int id)
        {
            var entity = _cadastroService.ObterCadastro(id);
            return _mapper.Map<UsuarioViewModel>(entity);
        }

        public bool ObterLogin(string email, string senha)
        {
            var login = _cadastroService.ObterLogin(email, senha);

            if (login != null)
            {
                return true;
            }
            return false;
        }

        public IEnumerable<UsuarioViewModel> ObterCadastros()
        {
            var entities = _cadastroService.ObterCadastros();
            var viewModels = new List<UsuarioViewModel>();

            foreach (var entity in entities)
            {
                viewModels.Add(_mapper.Map<UsuarioViewModel>(entity));
            }

            return viewModels;
        }
    }
}
