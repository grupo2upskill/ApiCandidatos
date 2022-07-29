using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICandidatos.Model
{
    public class OfertaEmprego
    {
        [Key]
<<<<<<< Updated upstream
        public int IdOferta { get; set; }
        [Required]
        public int IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }
=======
        public int IdOferta { get; set; }        

        public int IdEmpresa { get; set; }
        //[ForeignKey("IdEmpresa")]
        //public Empresa Empresa { get; set; }

>>>>>>> Stashed changes
        public string Titulo { get; set; }
        public float? Salario { get; set; }
        public string? Jornada { get; set; }
        public string? Localização { get; set; }
        public string? RegimeTrabalho { get; set; }
        public string? TipoContrato { get; set; }
        public string? Requisitos { get; set; }
<<<<<<< Updated upstream
=======
        public bool? VagaDisponivel { get; set; }
        //public List<AplicacaoTrabalho> AplicacaoTrabalhos { get; set; }

>>>>>>> Stashed changes
    }
}