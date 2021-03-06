// <auto-generated />
using System;
using APICandidatos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APICandidatos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220728162941_testeFoto")]
    partial class testeFoto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("APICandidatos.Model.AplicacaoTrabalho", b =>
                {
                    b.Property<int>("IdApl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdApl"), 1L, 1);

                    b.Property<DateTime>("DataAplicacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCandidato")
                        .HasColumnType("int");

                    b.Property<int>("IdOferta")
                        .HasColumnType("int");

                    b.Property<bool>("aplicacaoAceite")
                        .HasColumnType("bit");

                    b.HasKey("IdApl");

                    b.ToTable("AplicacaoTrabalho");
                });

            modelBuilder.Entity("APICandidatos.Model.Candidato", b =>
                {
                    b.Property<int>("IdCandidato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCandidato"), 1L, 1);

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("FileCV")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("LinkedIn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Morada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("IdCandidato");

                    b.ToTable("Candidato");
                });

            modelBuilder.Entity("APICandidatos.Model.CV", b =>
                {
                    b.Property<int>("IdCV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCV"), 1L, 1);

                    b.Property<string>("Competencias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Educacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpProfissional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdCandidatoCv")
                        .HasColumnType("int");

                    b.Property<string>("Interesses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localizacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCV");

                    b.HasIndex("IdCandidatoCv");

                    b.ToTable("CV");
                });

            modelBuilder.Entity("APICandidatos.Model.Empresa", b =>
                {
                    b.Property<int>("IdEmpresa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmpresa"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedIn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NoFuncionarios")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Telefone")
                        .HasColumnType("int");

                    b.Property<string>("ZonaAtuacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEmpresa");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("APICandidatos.Model.Foto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("FotoPerfil")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("IdCandidatoFoto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCandidatoFoto");

                    b.ToTable("Foto");
                });

            modelBuilder.Entity("APICandidatos.Model.OfertaEmprego", b =>
                {
                    b.Property<int>("IdOferta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdOferta"), 1L, 1);

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<string>("Jornada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localização")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegimeTrabalho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requisitos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Salario")
                        .HasColumnType("real");

                    b.Property<string>("TipoContrato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("VagaDisponivel")
                        .HasColumnType("bit");

                    b.HasKey("IdOferta");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("OfertaEmprego");
                });

            modelBuilder.Entity("APICandidatos.Model.CV", b =>
                {
                    b.HasOne("APICandidatos.Model.Candidato", "Candidato")
                        .WithMany()
                        .HasForeignKey("IdCandidatoCv");

                    b.Navigation("Candidato");
                });

            modelBuilder.Entity("APICandidatos.Model.Foto", b =>
                {
                    b.HasOne("APICandidatos.Model.Candidato", "Candidato")
                        .WithMany()
                        .HasForeignKey("IdCandidatoFoto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidato");
                });

            modelBuilder.Entity("APICandidatos.Model.OfertaEmprego", b =>
                {
                    b.HasOne("APICandidatos.Model.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("IdEmpresa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });
#pragma warning restore 612, 618
        }
    }
}
