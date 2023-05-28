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
        }
        public DbSet<Utilizador> Utilizador { get; set; } = default!;
        public DbSet<Sector> Sector { get; set; }
        public DbSet<Cargo> Cargo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=AOMFERNANDO;Database=erpfacturacao;User Id=SA; Password=n@#TEPOSSODIZER07;Trusted_Connection=True; TrustServerCertificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}