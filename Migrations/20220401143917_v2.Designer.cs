﻿// <auto-generated />
using System;
using AndreAirlinesAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AndreAirlinesAPI.Migrations
{
    [DbContext(typeof(AndreAirlinesAPIContext))]
    [Migration("20220401143917_v2")]
    partial class v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AndreAirlinesAPI.Model.Aeronave", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Capacidade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codigo");

                    b.ToTable("Aeronave");
                });

            modelBuilder.Entity("AndreAirlinesAPI.Model.Aeroporto", b =>
                {
                    b.Property<string>("Sigla")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("EnderecoID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sigla");

                    b.HasIndex("EnderecoID");

                    b.ToTable("Aeroporto");
                });

            modelBuilder.Entity("AndreAirlinesAPI.Model.Endereco", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("AndreAirlinesAPI.Model.Passageiro", b =>
                {
                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EnderecoID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CPF");

                    b.HasIndex("EnderecoID");

                    b.ToTable("Passageiro");
                });

            modelBuilder.Entity("AndreAirlinesAPI.Model.Voo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CodigoAeronaveCodigo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("EnderecoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("HorarioDesembarque")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioEmbarque")
                        .HasColumnType("datetime2");

                    b.Property<string>("SiglaDestinoSigla")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SiglaOrigemSigla")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("CPF1");

                    b.HasIndex("CodigoAeronaveCodigo");

                    b.HasIndex("EnderecoID");

                    b.HasIndex("SiglaDestinoSigla");

                    b.HasIndex("SiglaOrigemSigla");

                    b.ToTable("Voo");
                });

            modelBuilder.Entity("AndreAirlinesAPI.Model.Aeroporto", b =>
                {
                    b.HasOne("AndreAirlinesAPI.Model.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoID");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("AndreAirlinesAPI.Model.Passageiro", b =>
                {
                    b.HasOne("AndreAirlinesAPI.Model.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoID");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("AndreAirlinesAPI.Model.Voo", b =>
                {
                    b.HasOne("AndreAirlinesAPI.Model.Passageiro", "CPF")
                        .WithMany()
                        .HasForeignKey("CPF1");

                    b.HasOne("AndreAirlinesAPI.Model.Aeronave", "CodigoAeronave")
                        .WithMany()
                        .HasForeignKey("CodigoAeronaveCodigo");

                    b.HasOne("AndreAirlinesAPI.Model.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoID");

                    b.HasOne("AndreAirlinesAPI.Model.Aeroporto", "SiglaDestino")
                        .WithMany()
                        .HasForeignKey("SiglaDestinoSigla");

                    b.HasOne("AndreAirlinesAPI.Model.Aeroporto", "SiglaOrigem")
                        .WithMany()
                        .HasForeignKey("SiglaOrigemSigla");

                    b.Navigation("CodigoAeronave");

                    b.Navigation("CPF");

                    b.Navigation("Endereco");

                    b.Navigation("SiglaDestino");

                    b.Navigation("SiglaOrigem");
                });
#pragma warning restore 612, 618
        }
    }
}
