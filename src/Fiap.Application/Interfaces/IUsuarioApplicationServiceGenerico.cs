using Fiap.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Application.Interfaces
{
    public interface IUsuarioApplicationServiceGenerico
    {
        UsuarioViewModel AdicionarCadastro(UsuarioViewModel viewModel);
        UsuarioViewModel AtualizarCadastro(UsuarioViewModel viewModel);
        string DeletarCadastro(int id);
        UsuarioViewModel ObterCadastro(int id);
        IEnumerable<UsuarioViewModel> ObterCadastros();
    }
}
