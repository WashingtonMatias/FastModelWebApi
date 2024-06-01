using Fiap.Application.Interfaces;
using Fiap.Application.ViewModels;
using Fiap.Data.Context;
using Fiap.Domain.Interfaces;
using Fiap.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Application.Services
{
    public class CadastroApplicationService : ICadastroApplicaionService
    {
        private readonly ICadastroService _cadastroService;

        public CadastroApplicationService(ICadastroService CadastrosService)
        {
            _cadastroService = CadastrosService;
        }

        public CadastroViewModel AdicionarCadastro(CadastroViewModel CadastrosViewModel)
        {
            Cadastro Cadastros = MontarObjetoCadastros(CadastrosViewModel);

            return MontarObjetoCadastroViewModel(_cadastroService.AdicionarCadastro(Cadastros));
        }

        private static Cadastro MontarObjetoCadastros(CadastroViewModel CadastrosViewModel)
        {
            return new Cadastro(CadastrosViewModel.Id_Cadastro,
                                                  CadastrosViewModel.DataCadastro,
                                                  CadastrosViewModel.Nome,
                                                  CadastrosViewModel.SobreNome,
                                                  CadastrosViewModel.DataNascimento,
                                                  CadastrosViewModel.Cpf,
                                                  CadastrosViewModel.Email);
        }

        private static CadastroViewModel MontarObjetoCadastroViewModel(Cadastro Cadastro)
        {
            return new CadastroViewModel(Cadastro.Id_Cadastro,
                                                  Cadastro.DataCadastro,
                                                  Cadastro.Nome,
                                                  Cadastro.SobreNome,
                                                  Cadastro.DataNascimento,
                                                  Cadastro.Cpf,
                                                  Cadastro.Email);
        }

        public CadastroViewModel AtualizarCadastro(CadastroViewModel CadastrosViewModel)
        {
            Cadastro Cadastros = MontarObjetoCadastros(CadastrosViewModel);

            return MontarObjetoCadastroViewModel(_cadastroService.AtualizarCadastro(Cadastros));
        }

        public string DeletarCadastro(Guid id)
        {
            return _cadastroService.DeletarCadastro(id);
        }

        public CadastroViewModel ObterCadastro(Guid id)
        {
            return mapperCadastro(_cadastroService.ObterCadastro(id));
        }

        public IEnumerable<CadastroViewModel> ObterCadastros()
        {
            var cadastros = _cadastroService.ObterCadastros();
            var cadastroViewModel = new List<CadastroViewModel>();
            foreach (var cadastro in cadastros)
            {
                cadastroViewModel.Add(mapperCadastro(cadastro));
            }
            return cadastroViewModel;
        }

        private static CadastroViewModel mapperCadastro(Cadastro cadastro)
        {
            return new CadastroViewModel
            (
                cadastro.Id_Cadastro,
                cadastro.DataCadastro,
                cadastro.Nome,
                cadastro.SobreNome,
                cadastro.DataNascimento,
                cadastro.Cpf,
                cadastro.Email
            );
        }

        public IEnumerable<Tbl_EstabelecimentoViewModel> ObterEstabeleciemento()
        {
            var estabelecimentos = _cadastroService.ObterEstabelecimento();
            var estabelecimentoViewModel = new List<Tbl_EstabelecimentoViewModel>();
            foreach (var estabelecimento in estabelecimentos)
            {
                estabelecimentoViewModel.Add(new Tbl_EstabelecimentoViewModel
                {
                    ID_ESTABELECIMENTO = estabelecimento.ID_ESTABELECIMENTO,
                    DH_CRIACAO = estabelecimento.DH_CRIACAO,
                    NOME_ESTABELECIMENTO = estabelecimento.NOME_ESTABELECIMENTO
                });
            }

            return estabelecimentoViewModel;
        }
    }
}
