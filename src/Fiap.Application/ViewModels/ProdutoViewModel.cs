namespace Fiap.Application.ViewModels
{
    public class ProdutoViewModel
    {
        public int Id_Produto { get; set; }
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public double? Rating { get; set; }
        public string? ImgUrl { get; set; }
        public int? Cont_Reviews { get; set; }
    }
}
