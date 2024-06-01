using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Fiap.Domain.Models
{
    [Table("PRODUTOS")]
    public class Produto
    {

        [Column("ID_PRODUTO")]
        [Display(Name = "Id_Produto")]
        public int Id_Produto { get; set; }

        [Column("NOME")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("PRECO")]
        [Display(Name = "Preco")]
        public decimal Preco { get; set; }

        [Column("RATING")]
        [Display(Name = "Rating")]
        public decimal Rating { get; set; }

        [Column("IMG_URL")]
        [Display(Name = "Img_URL")]
        public string Img_URL { get; set; }

        [Column("CONT_REVIEWS")]
        [Display(Name = "CONT_Reviews")]
        public int CONT_Reviews { get; set; }
    }
}
