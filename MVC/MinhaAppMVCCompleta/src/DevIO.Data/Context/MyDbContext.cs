using Microsoft.EntityFrameworkCore;
using MVCBasica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Data.Context
{
    class MyDbContext :  DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public MyDbContext(DbContextOptions options)
            :base(options)
        {

        }
    }
}
