using Fiap.Data.Context;
using Fiap.Domain.Interfaces;
using Fiap.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Data.Repositories
{
    public class CadastroRepository : ICadastroRepository
    {
        private FiapContext _dbContext;

        public CadastroRepository(FiapContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Cadastro AdicionarCadastro(Cadastro cadastro)
        {
            var validar = _dbContext.Cadastro.FirstOrDefault(x => x.Id_Cadastro == cadastro.Id_Cadastro);

            if (validar != null) { cadastro.Id_Cadastro = new Guid(); };

            _dbContext.Cadastro.Add(cadastro);
            _dbContext.SaveChanges();
            return cadastro;
        }

        public Cadastro AtualizarCadastro(Cadastro cadastro)
        {
            _dbContext.Cadastro.Update(cadastro);
            _dbContext.SaveChanges();
            return cadastro;
        }

        public string DeletarCadastro(Guid id)
        {
            var cadastro = _dbContext.Cadastro.FirstOrDefault(u => u.Id_Cadastro == id);
            if (cadastro != null)
            {
                _dbContext.Cadastro.Remove(cadastro);
                _dbContext.SaveChanges();
                return "Cadastro excluido com sucesso!";
            }

            return "Id não localizado!";
        }

        public IEnumerable<Tbl_Estabelecimento> ObterEstabelecimento()
        {
            return _dbContext.Tbl_Estabelecimento.ToList();
        }

        public Cadastro ObterCadastro(Guid id)
        {
            return _dbContext.Cadastro.FirstOrDefault(u => u.Id_Cadastro == id);
        }

        public IEnumerable<Cadastro> ObterCadastros()
        {
            return _dbContext.Cadastro.ToList();
        }
    }
}
