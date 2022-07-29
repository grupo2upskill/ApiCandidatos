using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace teste_cliente.Models
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
        public string Morada { get; set; }
        public DateTime DataNasc { get; set; }
        public string LinkedIn { get; set; }
        public string Facebook { get; set; }
        public byte[]? FileCV { get; set; }

        [InverseProperty("IdCandidatoNavigation")]
        public virtual ICollection<AplicacaoTrabalho> AplicacaoTrabalhos { get; set; }
        [InverseProperty("IdCandidatoCvNavigation")]
        public virtual ICollection<CV> CVs { get; set; }
    }
}
