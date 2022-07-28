﻿// <auto-generated />
using System;
using APICandidatos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APICandidatos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("CandidatoIdCandidato")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAplicacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCandidato")
                        .HasColumnType("int");

                    b.Property<int>("IdOferta")
                        .HasColumnType("int");

                    b.Property<int?>("OfertaEmpregoIdOferta")
                        .HasColumnType("int");

                    b.Property<bool>("aplicacaoAceite")
                        .HasColumnType("bit");

                    b.HasKey("IdApl");

                    b.HasIndex("CandidatoIdCandidato");

                    b.HasIndex("OfertaEmpregoIdOferta");

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

                    b.Property<byte[]>("Foto")
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

                    b.Property<int?>("IdCandidato")
                        .HasColumnType("int");

                    b.Property<string>("Interesses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localizacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCV");

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

                    b.ToTable("OfertaEmprego");
                });

            modelBuilder.Entity("APICandidatos.Model.AplicacaoTrabalho", b =>
                {
                    b.HasOne("APICandidatos.Model.Candidato", null)
                        .WithMany("AplicacaoTrabalhos")
                        .HasForeignKey("CandidatoIdCandidato");

                    b.HasOne("APICandidatos.Model.OfertaEmprego", null)
                        .WithMany("AplicacaoTrabalhos")
                        .HasForeignKey("OfertaEmpregoIdOferta");
                });

            modelBuilder.Entity("APICandidatos.Model.Candidato", b =>
                {
                    b.Navigation("AplicacaoTrabalhos");
                });

            modelBuilder.Entity("APICandidatos.Model.OfertaEmprego", b =>
                {
                    b.Navigation("AplicacaoTrabalhos");
                });
#pragma warning restore 612, 618
        }
    }
}
