using Fiap.Data.Context;
using Fiap.Domain.Interfaces;
using Fiap.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Data.Repositories
{
    public class CadastroRepositoryGenerico<T> : ICadastroRepositoryGenerico<T> where T : class
    {
        private readonly FiapContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public CadastroRepositoryGenerico(FiapContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public T AdicionarCadastro(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public T AtualizarCadastro(T entity)
        {
            _dbSet.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public string DeletarCadastro(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _dbContext.SaveChanges();
                return "Cadastro excluído com sucesso!";
            }

            return "Id não localizado!";
        }

        public T ObterCadastro(int id)
        {
            return _dbSet.Find(id);
        }

        public Usuario ObterLogin(string email, string senha)
        {
            return _dbContext.Usuario.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public IEnumerable<T> ObterCadastros()
        {
            return _dbSet.ToList();
        }
    }
}
