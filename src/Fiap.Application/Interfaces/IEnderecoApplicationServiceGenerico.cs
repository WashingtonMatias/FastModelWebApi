using Fiap.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Application.Interfaces
{
    public interface IEnderecoApplicationServiceGenerico
    {
        EnderecoViewModel AdicionarCadastro(EnderecoViewModel viewModel);
        EnderecoViewModel AtualizarCadastro(EnderecoViewModel viewModel);
        string DeletarCadastro(int id);
        EnderecoViewModel ObterCadastro(int id);
        IEnumerable<EnderecoViewModel> ObterCadastros();
    }
}
