using Fiap.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Domain.Interfaces
{
    public interface ICadastroServiceGenerico<T> where T : class
    {
        T AdicionarCadastro(T entity);
        T AtualizarCadastro(T entity);
        string DeletarCadastro(int id);
        T ObterCadastro(int id);
        IEnumerable<T> ObterCadastros();
        Usuario ObterLogin(string email, string senha);
    }
}
