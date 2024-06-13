using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Domain.Models
{
    [Table("USUARIO")]
    public class Usuario
    {

        [Column("ID_USUARIO")]
        [Display(Name = "Id_Usuario")]
        public int Id_Usuario { get; set; }

        [Column("NOME")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Column("SOBRENOME")]
        [Display(Name = "SobreNome")]
        public string? SobreNome { get; set; }

        [Column("EMAIL")]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Column("DATA_NASCIMENTO")]
        [Display(Name = "DataNascimento")]
        public DateTime? Data_Nascimento { get; set; }

        [Column("SENHA")]
        [Display(Name = "Senha")]
        public string? Senha { get; set; }

    }
}
