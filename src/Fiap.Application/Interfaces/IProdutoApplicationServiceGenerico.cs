using Fiap.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Application.Interfaces
{
    public interface IProdutoApplicationServiceGenerico
    {
        ProdutoViewModel AdicionarCadastro(ProdutoViewModel viewModel);
        ProdutoViewModel AtualizarCadastro(ProdutoViewModel viewModel);
        string DeletarCadastro(int id);
        ProdutoViewModel ObterCadastro(int id);
        IEnumerable<ProdutoViewModel> ObterCadastros();
    }
}
