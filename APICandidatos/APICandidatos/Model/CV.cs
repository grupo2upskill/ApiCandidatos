using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICandidatos.Model
{
    public class CV
    {
        [Key]
        public int IdCV { get; set; }
        public string? Nome { get; set; }
        public string? Localizacao { get; set; }
        public string? Educacao { get; set; }
        public string? ExpProfissional { get; set; }
        public string? Competencias { get; set; }
        public string? Interesses { get; set; }
        [ForeignKey("FK_Candidato")]
        public int? IdCandidato { get; set; }
        
    }
}
