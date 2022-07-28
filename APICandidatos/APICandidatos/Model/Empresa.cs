using System.ComponentModel.DataAnnotations;

namespace APICandidatos.Model
{
    public class Empresa
    {
        [Key]
        public int IdEmpresa { get; set; }
        [Required]
        public string Nome { get; set; }
        public string? Localidade { get; set; }
        public string Email { get; set; }
        public int? Telefone { get; set; }
        public int? NoFuncionarios { get; set; }
        public string? ZonaAtuacao { get; set; }
        public string? LinkedIn { get; set; }
        public string? Facebook { get; set; }
        
        public List<OfertaEmprego> OfertaEmpregos { get; set; }

    }
}