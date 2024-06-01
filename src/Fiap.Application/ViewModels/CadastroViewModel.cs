using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Application.ViewModels
{
    public class CadastroViewModel
    {
        public CadastroViewModel(Guid id_Cadastro, DateTime dataCadastro, string nome, string sobreNome, DateTime dataNascimento, string cpf, string email)
        {
            Id_Cadastro = id_Cadastro;
            DataCadastro = dataCadastro;
            Nome = nome;
            SobreNome = sobreNome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Email = email;
        }

        public Guid Id_Cadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
