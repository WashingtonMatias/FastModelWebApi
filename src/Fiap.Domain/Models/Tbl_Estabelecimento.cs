using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Domain.Models
{
    [Table("TBL_ESTABELECIMENTO")]
    public class Tbl_Estabelecimento
    {
        [Column("ID_ESTABELECIMENTO")]
        [Display(Name = "Id_Estabelecimento")]
        public int ID_ESTABELECIMENTO { get; set; }
        [Column("DH_CRIACAO")]
        [Display(Name = "Dh_Criacao")]
        public DateTime DH_CRIACAO { get; set; }
        [Column("NOME_ESTABELECIMENTO")]
        [Display(Name = "Nome_Estabelecimento")]
        public string NOME_ESTABELECIMENTO { get; set; }
    }
}
