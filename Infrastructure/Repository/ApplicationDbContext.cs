﻿using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repository
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string _connectionString;

        public ApplicationDbContext()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

            _connectionString = configuration.GetConnectionString("ConnectionString");
        }

        public ApplicationDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<UsuarioJogo> UsuarioJogo { get; set; }
        public DbSet<LogEntity> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
                optionsBuilder.UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Criar os modelos sem repetição de linhas
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

    }
}
