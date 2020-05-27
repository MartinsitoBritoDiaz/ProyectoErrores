using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using ProyectoErrorBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoErrorBlazor.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Errores> Errores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\Error.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Errores>().HasData(new Errores
            {
                errorId = 1,
                fecha = DateTime.Now,
                hallazgo = "El css esta mal",
                ruta = "https://localhost:5001/counter",
                importancia = 2
            });
        }
    }
}
