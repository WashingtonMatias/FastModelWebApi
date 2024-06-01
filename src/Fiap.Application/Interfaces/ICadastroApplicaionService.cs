using Fiap.Application.ViewModels;
using Fiap.Domain.Models;

namespace Fiap.Application.Interfaces
{
    public interface ICadastroApplicaionService
    {
        CadastroViewModel AdicionarCadastro(CadastroViewModel cadastroViewModel);
        CadastroViewModel AtualizarCadastro(CadastroViewModel cadastroViewModel);
        string DeletarCadastro(Guid id);
        CadastroViewModel ObterCadastro(Guid id);
        IEnumerable<CadastroViewModel> ObterCadastros();

        IEnumerable<Tbl_EstabelecimentoViewModel> ObterEstabeleciemento();
    }
}
