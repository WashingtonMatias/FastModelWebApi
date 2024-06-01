namespace Fiap.Application.ViewModels
{
    public class EnderecoViewModel
    {
        public int Id_Endereco { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Id_Usuario { get; set; }
    }
}
