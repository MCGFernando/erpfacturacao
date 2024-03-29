﻿using ERPFacturacao.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPFacturacao.Data
{
    public partial class EFContext : DbContext
    {
        public EFContext() { }

        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
            //Database.SetInitializer(new BDInitializer());
        }
        public DbSet<Utilizador> Utilizador { get; set; } = default!;
        public DbSet<Sector> Sector { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Municipio> Municipio { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Contacto> Contacto { get; set; }
        public DbSet<Moeda> Moeda { get; set; }
        public DbSet<Banco> Banco { get; set; }
        public DbSet<ContaBancaria> ContaBancaria { get; set; }
        public DbSet<RamoActividade> RamoActividade { get; set; }
        public DbSet<TipoContacto> TipoContacto { get; set; }
        public DbSet<TipoEndereco> TipoEndereco { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<CategoriaArtigo> CategoriaArtigo { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<TipoIVA> TipoIVA { get; set; }
        public DbSet<TipoArtigo> TipoArtigo { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        public DbSet<Unidade> Unidade { get; set; }
        public DbSet<Artigo> Artigo { get; set; }
        public DbSet<Serie> Serie { get; set; }
        public DbSet<ClasseContabil> ClasseContabil { get; set; }
        public DbSet<ContaContabilAgregadora> ContaContabilAgregadora { get; set; }
        public DbSet<ContaContabil> ContaContabil { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        =>
            //optionsBuilder.UseSqlServer("Server=AOMFERNANDO01;Database=erpfacturacao;User Id=SA; Password=n@#TEPOSSODIZER07;Trusted_Connection=True; TrustServerCertificate=True");
            optionsBuilder.UseSqlServer("Server=MFERNANDO;Database=erpfacturacao;User Id=SA; Password=marodcgf07;Trusted_Connection=True; TrustServerCertificate=True");
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
