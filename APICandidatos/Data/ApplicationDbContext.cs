using APICandidatos.Model;
using Microsoft.EntityFrameworkCore;

namespace APICandidatos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<AplicacaoTrabalho> AplicacaoTrabalho { get; set; }
        public DbSet<Candidato> Candidato { get; set; }
        public DbSet<CV> CV { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<OfertaEmprego> OfertaEmprego { get; set; }
    }
}
