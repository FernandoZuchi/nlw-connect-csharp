﻿using Microsoft.EntityFrameworkCore;
using TechLibrary.Api.Domain.Entities;

namespace TechLibrary.Api.Infraestructure.DataAccess;

public class TechLibraryDbContext : DbContext
{
    // Referência pra tabela USERS
    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Checkout> Checkouts { get; set; }

    // Conexão com banco
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\Fernando Zuchi\\Desktop\\develop\\www\\nlw-connect\\C#\\nlw-connect-csharp\\Database\\TechLibraryDb.db");
    }
}
