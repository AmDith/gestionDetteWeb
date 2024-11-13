using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionDette.ism.entities;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace gestionDetteWeb.Core.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=gestionclient;User ID=root;Password=;", ServerVersion.AutoDetect("Server=localhost;Port=3306;Database=gestionclient;"));
        }
    }
}
