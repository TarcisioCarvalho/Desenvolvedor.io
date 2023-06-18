using Microsoft.EntityFrameworkCore;
using MVCBasica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevIO.Data.Context
{
    public class MyDbContext :  DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public MyDbContext(DbContextOptions options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string)))
                )
            {
                property.Relational().ColumnType = "varchar(100)";
            }
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyDbContext).Assembly);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
