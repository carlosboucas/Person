﻿using Microsoft.EntityFrameworkCore;
using Person.Models;

namespace Person.Data
{
    //DbContext é a representação do Banco de Dados
    public class PersonContext : DbContext
    {
        public DbSet<PersonModel> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString:"Data Source=person.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
    }
}