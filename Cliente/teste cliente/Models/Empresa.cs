using System.ComponentModel.DataAnnotations;

namespace teste_cliente.Model
{
    public class Empresa
    {
        
        //public int IdEmpresa { get; set; }
        [Required]
        public string Nome { get; set; }
        public string? Localidade { get; set; }
        public string Email { get; set; }
        public int? Telefone { get; set; }
        public int? NoFuncionarios { get; set; }
        public string? ZonaAtuacao { get; set; }
        public string? LinkedIn { get; set; }
        public string? Facebook { get; set; }


    }
}