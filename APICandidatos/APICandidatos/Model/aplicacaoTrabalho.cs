using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICandidatos.Model
{
    public class AplicacaoTrabalho
    {
        [Key]
        public int IdApl { get; set; }

<<<<<<< Updated upstream
<<<<<<< Updated upstream
        [Required]
        public int IdOferta { get; set; }
        [ForeignKey("IdOferta")]
        public OfertaEmprego OfertaEmprego { get; set; }

        [Required]
        public int IdCandidato { get; set; }
        [ForeignKey("IdCandidato")]
        public Candidato Candidato { get; set; }
=======
        public int IdOferta { get; set; }
       //[ForeignKey("IdOferta")]
       // public virtual OfertaEmprego OfertaEmprego { get; set; }

        public int IdCandidato { get; set; }
       // [ForeignKey("IdCandidato")]
       // public virtual Candidato Candidato { get; set; }
>>>>>>> Stashed changes
=======
        public int IdOferta { get; set; }
       //[ForeignKey("IdOferta")]
       // public virtual OfertaEmprego OfertaEmprego { get; set; }

        public int IdCandidato { get; set; }
       // [ForeignKey("IdCandidato")]
       // public virtual Candidato Candidato { get; set; }
>>>>>>> Stashed changes

        public DateTime DataAplicacao { get; set; } = DateTime.Now;

        public bool aplicacaoAceite { get; set; } = false;
    }
}
