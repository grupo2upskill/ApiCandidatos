using APICandidatos.Model;
using Microsoft.EntityFrameworkCore;

namespace APICandidatos.Data
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
<<<<<<< Updated upstream
        public DbSet<AplicacaoTrabalho> AplicacaoTrabalho { get; set; }
        public DbSet<Candidato> Candidato { get; set; }
        public DbSet<CV> CV { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<OfertaEmprego> OfertaEmprego { get; set; }
=======
        public virtual DbSet<AplicacaoTrabalho> AplicacaoTrabalho { get; set; }
        public virtual DbSet<Candidato> Candidato { get; set; }
        public virtual DbSet<CV> CV { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<OfertaEmprego> OfertaEmprego { get; set; }
        public virtual DbSet<Foto> Foto { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    var cascadeFKs = modelBuilder.Model.GetEntityTypes()
        //    .SelectMany(t => t.GetForeignKeys());
        //    foreach (var fk in cascadeFKs)
        //        fk.DeleteBehavior = DeleteBehavior.NoAction;
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Formador>().HasOne(i => i.Pessoa).WithOne().HasForeignKey<Formador>(rl => rl.PessoaId).OnDelete(DeleteBehavior.NoAction);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CV>(entity =>
            {
                entity.HasOne(d => d.IdCandidatoCvNavigation)
                    .WithMany(p => p.CVs)
                    .HasForeignKey(d => d.IdCandidatoCv)
                    .HasConstraintName("FK_CV_Candidato_IdCandidato");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
>>>>>>> Stashed changes
    }
}
