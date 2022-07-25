using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICandidatos.Model
{
    public class AplicacaoTrabalho
    {
        [Key]
        public int IdApl { get; set; }

        [Required]
        public int IdOferta { get; set; }
        [ForeignKey("IdOferta")]
        public OfertaEmprego OfertaEmprego { get; set; }

        [Required]
        public int IdCandidato { get; set; }
        [ForeignKey("IdCandidato")]
        public Candidato Candidato { get; set; }

        public DateTime DataAplicacao { get; set; } = DateTime.Now;

        public bool aplicacaoAceite { get; set; } = false;
    }
}
