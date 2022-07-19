using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICandidatos.Model
{
    public class Candidato
    {
        [Key]
        public int IdCandidato { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        public int? Telefone { get; set; }
        public string? Morada { get; set; }
        [Required]
        public DateTime DataNasc { get; set; }
        public byte[]? Foto { get; set; }
        public string? LinkedIn { get; set; }
        public string? Facebook { get; set; }


    }
}
