using System;

namespace Fiap.Application.ViewModels
{
    public class UsuarioViewModel
    {
        public int Id_Usuario { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string Senha { get; set; }
    }
}
