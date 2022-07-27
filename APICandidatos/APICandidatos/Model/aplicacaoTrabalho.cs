using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICandidatos.Model
{
    public class AplicacaoTrabalho
    {
        [Key]
        public int IdApl { get; set; }

        [ForeignKey("FK_Oferta")]
        public int IdOferta { get; set; }


        [ForeignKey("FK_Candidato")]
        public int IdCandidato { get; set; }


        public DateTime DataAplicacao { get; set; } = DateTime.Now;

        public bool aplicacaoAceite { get; set; } = false;
    }
}
