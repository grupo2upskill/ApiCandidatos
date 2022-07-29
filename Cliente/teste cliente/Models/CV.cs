using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace teste_cliente.Models
{

    [Table("CV")]
    [Index("IdCandidatoCv", Name = "IX_CV_IdCandidato")]
    public partial class CV
    {
        [Key]
        public int IdCV { get; set; }
        public string Nome { get; set; }
        public string Localizacao { get; set; }
        public string Educacao { get; set; }
        public string ExpProfissional { get; set; }
        public string Competencias { get; set; }
        public string Interesses { get; set; }
        public int? IdCandidatoCv { get; set; }

        [ForeignKey("IdCandidatoCv")]
        [InverseProperty("CVs")]
        public virtual Candidato IdCandidatoCvNavigation { get; set; }

    }
}
