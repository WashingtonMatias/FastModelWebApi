using Fiap.Domain.Interfaces;
using Fiap.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Domain.Services
{
    public class CadastroService : ICadastroService
    {
        private readonly ICadastroRepository _cadastroRepository;

        public CadastroService(ICadastroRepository cadastroRepository)
        {
            _cadastroRepository = cadastroRepository;
        }

        public Cadastro AdicionarCadastro(Cadastro cadastro)
        {
            return _cadastroRepository.AdicionarCadastro(cadastro);
        }

        public Cadastro AtualizarCadastro(Cadastro cadastro)
        {
            return _cadastroRepository.AtualizarCadastro(cadastro);
        }

        public string DeletarCadastro(Guid id)
        {
            return _cadastroRepository.DeletarCadastro(id);
        }

        public IEnumerable<Tbl_Estabelecimento> ObterEstabelecimento()
        {
            return _cadastroRepository.ObterEstabelecimento();
        }

        public Cadastro ObterCadastro(Guid id)
        {
           return _cadastroRepository.ObterCadastro(id);
        }

        public IEnumerable<Cadastro> ObterCadastros()
        {
            return _cadastroRepository.ObterCadastros();
        }
    }
}
