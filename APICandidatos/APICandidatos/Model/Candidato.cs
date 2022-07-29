using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICandidatos.Model
{
    [Table("Candidato")]
    public partial class Candidato
    {
        public Candidato()
        {
            AplicacaoTrabalhos = new HashSet<AplicacaoTrabalho>();
            CVs = new HashSet<CV>();
        }

        [Key]
        public int IdCandidato { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        public int? Telefone { get; set; }
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        public string? Morada { get; set; }
        [Required]
        public int IdCV { get; set; }
        [ForeignKey("IdCV")]
        public CV CV { get; set; }
        [Required]
        public DateTime DataNasc { get; set; }
        public byte[]? Foto { get; set; }
        public string? LinkedIn { get; set; }
        public string? Facebook { get; set; }


=======
        public string Morada { get; set; }
        public DateTime DataNasc { get; set; }
=======
        public string Morada { get; set; }
        public DateTime DataNasc { get; set; }
>>>>>>> Stashed changes
        public string LinkedIn { get; set; }
        public string Facebook { get; set; }
        public byte[]? FileCV { get; set; }

        [InverseProperty("IdCandidatoNavigation")]
        public virtual ICollection<AplicacaoTrabalho> AplicacaoTrabalhos { get; set; }
        [InverseProperty("IdCandidatoCvNavigation")]
        public virtual ICollection<CV> CVs { get; set; }
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }
}
