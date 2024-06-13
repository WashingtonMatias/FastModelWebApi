using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Fiap.Domain.Models
{
    [Table("ENDERECO")]
    public class Endereco
    {

        [Column("ID_ENDERECO")]
        [Display(Name = "Id_Endereco")]
        public int Id_Endereco { get; set; }

        [Column("CEP")]
        [Display(Name = "CEP")]
        public string? CEP { get; set; }

        [Column("RUA")]
        [Display(Name = "Rua")]
        public string? Rua { get; set; }

        [Column("NUMERO")]
        [Display(Name = "Numero")]
        public string? Numero { get; set; }

        [Column("BAIRRO")]
        [Display(Name = "Bairro")]
        public string? Bairro { get; set; }

        [Column("CIDADE")]
        [Display(Name = "Cidade")]
        public string? Cidade { get; set; }

        [Column("ID_USUARIO")]
        [Display(Name = "Id_Usuario")]
        public int? Id_Usuario { get; set; }

        [ForeignKey("Id_Usuario")]
        public Usuario Usuario { get; set; }
    }
}
