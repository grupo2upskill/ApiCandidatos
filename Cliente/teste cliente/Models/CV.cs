using System.ComponentModel.DataAnnotations;

namespace teste_cliente.Models
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
    }
}
