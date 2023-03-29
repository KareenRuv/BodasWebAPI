using Eventos.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Eventos.Data
{
    public class EventosContext : DbContext
    {
        public EventosContext(DbContextOptions<EventosContext> bdContextOptions) : base(bdContextOptions) 
        {
        }
        public EventosContext()
        {
        }
        public DbSet<Boda> Boda { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Pareja> Pareja { get; set; }
        public DbSet<Invitados> Invitados { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<Asistencia> Asistencia { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Edades> Edades { get; set; }
        public DbSet<Sexo>Sexo { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Boda>(entity =>
            {
                entity.HasIndex(i => new { i.Id_Boda }).IsUnique(true);
                entity.HasIndex(i => new { i.Id_Usuario });
                entity.HasIndex(i=> new { i.Id_Pareja });
            });
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasIndex(i => new { i.Id_Usuario }).IsUnique(true);
            });
            modelBuilder.Entity<Pareja>(entity =>
            {
                entity.HasIndex(i => new { i.Id_Pareja }).IsUnique(true);
            });
            modelBuilder.Entity<Invitados>(entity =>
            { 
                entity.HasIndex(i => new {i.Id_Invitados}).IsUnique(true);
                entity.HasIndex(i => new {i.Id_Asistencia });
                entity.HasIndex(i => new { i.Id_Edad });
                entity.HasIndex(i => new { i.Id_Sexo });
                entity.HasIndex(i => new { i.Id_Menu });
            });
            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.HasIndex(i => new { i.Id_Proveedor }).IsUnique(true);
            });
            modelBuilder.Entity<Asistencia>(entity =>
            {
                entity.HasIndex(i => new { i.Id_Asistencia }).IsUnique(true);
            });
            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasIndex(i => new { i.Id_Menu }).IsUnique(true);
            });
            modelBuilder.Entity<Edades>(entity =>
            {
                entity.HasIndex(i => new { i.Id_Edad }).IsUnique(true);
            });
            modelBuilder.Entity<Sexo>(entity =>
            {
                entity.HasIndex(i => new {i.Id_Sexo }).IsUnique(true);
            });
        }
    }
}