using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICandidatos.Model
{
    public class aplicacaoTrabalho
    {
        [Key]
        public int IdApl { get; set; }
        
        public int IdOferta { get; set; }
        [ForeignKey("IdOferta")]
        public OfertaEmprego OfertaEmprego { get; set; }

        public int IdCandidato { get; set; }
        [ForeignKey("IdCandidato")]
        public Candidato Candidato { get; set; }

        public DateTime DataAplicacao { get; set; }

        public bool aplicacaoAceite { get; set; }
    }
}
