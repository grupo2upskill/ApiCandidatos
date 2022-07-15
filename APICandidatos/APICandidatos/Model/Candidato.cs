namespace APICandidatos.Model
{
    public class Candidato
    {
        [Key]
        public int IdCandidato { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int? Telefone { get; set; }
        public string? Morada { get; set; }
        public int? IdCV { get; set; }
        [ForeignKey("IdCV")]
        public CV CV { get; set; }
        public DateTime DataNasc { get; set; }
        public byte[]? Foto { get; set; }
        public string? LinkedIn { get; set; }
        public string? Facebook { get; set; }


    }
}
