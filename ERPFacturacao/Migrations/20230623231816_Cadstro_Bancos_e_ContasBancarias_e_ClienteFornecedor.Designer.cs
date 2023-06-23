﻿// <auto-generated />
using System;
using ERPFacturacao.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ERPFacturacao.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20230623231816_Cadstro_Bancos_e_ContasBancarias_e_ClienteFornecedor")]
    partial class Cadstro_Bancos_e_ContasBancarias_e_ClienteFornecedor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ERPFacturacao.Model.Banco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataActualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_actualizacao");

                    b.Property<DateTime>("DataAnulacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_anulacao");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_registo");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Banco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("banco");

                    b.HasKey("Id");

                    b.ToTable("bancos");
                });

            modelBuilder.Entity("ERPFacturacao.Model.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataActualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_actualizacao");

                    b.Property<DateTime>("DataAnulacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_anulacao");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_registo");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UtilizadorId")
                        .HasColumnType("int")
                        .HasColumnName("utilizadores_cargos_id");

                    b.Property<string>("_Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cargo");

                    b.HasKey("Id");

                    b.ToTable("cargos");
                });

            modelBuilder.Entity("ERPFacturacao.Model.ClienteFonecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Cliente")
                        .HasColumnType("bit");

                    b.Property<string>("CodigoClienteFornecedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContribuinteOrigem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataActualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_actualizacao");

                    b.Property<DateTime>("DataAnulacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_anulacao");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_registo");

                    b.Property<bool?>("Desconto")
                        .HasColumnType("bit");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int?>("EstadoCivil")
                        .HasColumnType("int");

                    b.Property<bool?>("Fornecedor")
                        .HasColumnType("bit");

                    b.Property<int?>("Genero")
                        .HasColumnType("int");

                    b.Property<double?>("LimiteCredito")
                        .HasColumnType("float");

                    b.Property<string>("Nacionalidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naturalidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nif")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFiscal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PaisId")
                        .HasColumnType("int");

                    b.Property<int?>("PrazoEntrega")
                        .HasColumnType("int");

                    b.Property<int?>("RamoActividadeId")
                        .HasColumnType("int");

                    b.Property<int>("TipoContribuinte")
                        .HasColumnType("int");

                    b.Property<int>("TipoPessoa")
                        .HasColumnType("int");

                    b.Property<double?>("ValorDesconto")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.HasIndex("RamoActividadeId");

                    b.ToTable("clientes_fornecedores");
                });

            modelBuilder.Entity("ERPFacturacao.Model.ContaBancaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Agencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BancoId")
                        .HasColumnType("int");

                    b.Property<int>("ClienteFonecedorId")
                        .HasColumnType("int");

                    b.Property<int>("ClienteFornecedorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataActualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_actualizacao");

                    b.Property<DateTime>("DataAnulacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_anulacao");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_registo");

                    b.Property<string>("EmailAlternativoGestorConta")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email_alternativo_gestor_conta");

                    b.Property<string>("EmailGestorConta")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email_gestor_conta");

                    b.Property<string>("GestorConta")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("gestor_conta");

                    b.Property<string>("IBAN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroConta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("numero_conta");

                    b.Property<string>("TelefoneAlternativoGestorConta")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("telefone_alternativo_gestor_conta");

                    b.Property<string>("TelefoneGestorConta")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("telefone_gestor_conta");

                    b.HasKey("Id");

                    b.HasIndex("BancoId");

                    b.HasIndex("ClienteFonecedorId");

                    b.ToTable("contas_bancarias");
                });

            modelBuilder.Entity("ERPFacturacao.Model.Contacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteFonecedorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataActualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_actualizacao");

                    b.Property<DateTime>("DataAnulacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_anulacao");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_registo");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telemovel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoContactoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteFonecedorId");

                    b.HasIndex("TipoContactoId");

                    b.ToTable("Contacto");
                });

            modelBuilder.Entity("ERPFacturacao.Model.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClienteFonecedorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataActualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_actualizacao");

                    b.Property<DateTime>("DataAnulacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_anulacao");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_registo");

                    b.Property<int?>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Referencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoEnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("_Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("endereco");

                    b.HasKey("Id");

                    b.HasIndex("ClienteFonecedorId");

                    b.HasIndex("MunicipioId");

                    b.HasIndex("TipoEnderecoId");

                    b.ToTable("enderecos");
                });

            modelBuilder.Entity("ERPFacturacao.Model.Moeda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataActualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_actualizacao");

                    b.Property<DateTime>("DataAnulacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_anulacao");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_registo");

                    b.Property<int>("PaisId")
                        .HasColumnType("int");

                    b.Property<string>("Simbolo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Moeda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.ToTable("moedas");
                });

            modelBuilder.Entity("ERPFacturacao.Model.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CodigoMunicipio")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("codigo_municipio");

                    b.Property<DateTime?>("DataActualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_actualizacao");

                    b.Property<DateTime?>("DataAnulacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_anulacao");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_registo");

                    b.Property<int>("ProvinciaId")
                        .HasColumnType("int")
                        .HasColumnName("provincia_id");

                    b.Property<string>("_Municipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("municipio");

                    b.HasKey("Id");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("municipios");
                });

            modelBuilder.Entity("ERPFacturacao.Model.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CodigoMoeda")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("codigo_moeda");

                    b.Property<string>("CodigoPais")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("codigo_pais");

                    b.Property<string>("CodigoTelefonia")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("codigo_telefonia");

                    b.Property<DateTime?>("DataActualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_actualizacao");

                    b.Property<DateTime?>("DataAnulacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_anulacao");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_registo");

                    b.Property<string>("DominioTopo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("dominio_topo");

                    b.Property<string>("Moeda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("pais");

                    b.HasKey("Id");

                    b.ToTable("paises");
                });

            modelBuilder.Entity("ERPFacturacao.Model.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CodigoProvincia")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("codigo_provincia");

                    b.Property<DateTime?>("DataActualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_actualizacao");

                    b.Property<DateTime?>("DataAnulacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_anulacao");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_registo");

                    b.Property<int>("PaisId")
                        .HasColumnType("int")
                        .HasColumnName("paises_is");

                    b.Property<string>("_Provincia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("provincia");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.ToTable("provincias");
                });

            modelBuilder.Entity("ERPFacturacao.Model.RamoActividade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataActualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_actualizacao");

                    b.Property<DateTime?>("DataAnulacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_anulacao");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_registo");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ramo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ramo_actividades");
                });

            modelBuilder.Entity("ERPFacturacao.Model.Sector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataActualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_actualizacao");

                    b.Property<DateTime>("DataAnulacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_anulacao");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_registo");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UtilizadorId")
                        .HasColumnType("int")
                        .HasColumnName("utilizadores_sectores_id");

                    b.Property<string>("_Sector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("sector");

                    b.HasKey("Id");

                    b.ToTable("sectores");
                });

            modelBuilder.Entity("ERPFacturacao.Model.TipoContacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataActualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_actualizacao");

                    b.Property<DateTime?>("DataAnulacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_anulacao");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_registo");

                    b.Property<string>("_TipoContacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tipo_contacto");

                    b.HasKey("Id");

                    b.ToTable("tipos_contactos");
                });

            modelBuilder.Entity("ERPFacturacao.Model.TipoEndereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataActualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_actualizacao");

                    b.Property<DateTime?>("DataAnulacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_anulacao");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_registo");

                    b.Property<string>("_TipoEndereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tipo_endereco");

                    b.HasKey("Id");

                    b.ToTable("tipos_enderecos");
                });

            modelBuilder.Entity("ERPFacturacao.Model.Utilizador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSu")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Utilizador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("utilizador");

                    b.HasKey("Id");

                    b.ToTable("utilizadores");
                });

            modelBuilder.Entity("ERPFacturacao.Model.ClienteFonecedor", b =>
                {
                    b.HasOne("ERPFacturacao.Model.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisId");

                    b.HasOne("ERPFacturacao.Model.RamoActividade", "RamoActividade")
                        .WithMany()
                        .HasForeignKey("RamoActividadeId");

                    b.Navigation("Pais");

                    b.Navigation("RamoActividade");
                });

            modelBuilder.Entity("ERPFacturacao.Model.ContaBancaria", b =>
                {
                    b.HasOne("ERPFacturacao.Model.Banco", "Banco")
                        .WithMany()
                        .HasForeignKey("BancoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERPFacturacao.Model.ClienteFonecedor", "ClienteFonecedor")
                        .WithMany("ContasBancarias")
                        .HasForeignKey("ClienteFonecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Banco");

                    b.Navigation("ClienteFonecedor");
                });

            modelBuilder.Entity("ERPFacturacao.Model.Contacto", b =>
                {
                    b.HasOne("ERPFacturacao.Model.ClienteFonecedor", "ClienteFonecedor")
                        .WithMany("Contactos")
                        .HasForeignKey("ClienteFonecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERPFacturacao.Model.TipoContacto", "TipoContacto")
                        .WithMany()
                        .HasForeignKey("TipoContactoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClienteFonecedor");

                    b.Navigation("TipoContacto");
                });

            modelBuilder.Entity("ERPFacturacao.Model.Endereco", b =>
                {
                    b.HasOne("ERPFacturacao.Model.ClienteFonecedor", "ClienteFonecedor")
                        .WithMany("Enderecos")
                        .HasForeignKey("ClienteFonecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERPFacturacao.Model.Municipio", "Municipio")
                        .WithMany()
                        .HasForeignKey("MunicipioId");

                    b.HasOne("ERPFacturacao.Model.TipoEndereco", "TipoEndereco")
                        .WithMany()
                        .HasForeignKey("TipoEnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClienteFonecedor");

                    b.Navigation("Municipio");

                    b.Navigation("TipoEndereco");
                });

            modelBuilder.Entity("ERPFacturacao.Model.Moeda", b =>
                {
                    b.HasOne("ERPFacturacao.Model.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("ERPFacturacao.Model.Municipio", b =>
                {
                    b.HasOne("ERPFacturacao.Model.Provincia", "Provincia")
                        .WithMany()
                        .HasForeignKey("ProvinciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provincia");
                });

            modelBuilder.Entity("ERPFacturacao.Model.Provincia", b =>
                {
                    b.HasOne("ERPFacturacao.Model.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("ERPFacturacao.Model.ClienteFonecedor", b =>
                {
                    b.Navigation("Contactos");

                    b.Navigation("ContasBancarias");

                    b.Navigation("Enderecos");
                });
#pragma warning restore 612, 618
        }
    }
}
