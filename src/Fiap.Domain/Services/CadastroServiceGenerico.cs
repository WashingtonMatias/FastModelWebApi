﻿using Fiap.Domain.Interfaces;

namespace Fiap.Domain.Services
{
    public class CadastroServiceGenerico<T> : ICadastroServiceGenerico<T> where T : class
    {
        private readonly ICadastroRepositoryGenerico<T> _cadastroRepository;

        public CadastroServiceGenerico(ICadastroRepositoryGenerico<T> cadastroRepository)
        {
            _cadastroRepository = cadastroRepository;
        }

        public T AdicionarCadastro(T entity)
        {
            return _cadastroRepository.AdicionarCadastro(entity);
        }

        public T AtualizarCadastro(T entity)
        {
            return _cadastroRepository.AtualizarCadastro(entity);
        }

        public string DeletarCadastro(int id)
        {
            return _cadastroRepository.DeletarCadastro(id);
        }

        public T ObterCadastro(int id)
        {
            return _cadastroRepository.ObterCadastro(id);
        }

        public IEnumerable<T> ObterCadastros()
        {
            return _cadastroRepository.ObterCadastros();
        }
    }
}
