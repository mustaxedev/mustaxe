using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mustaxe.Models;

namespace Mustaxe.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //INITIAL DATA SEED
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole
            //{
            //    Name = "Admin",
            //    NormalizedName = "ADMIN"
            //});

            //var hasher = new PasswordHasher<ApplicationUser>();
            //builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            //{
            //    UserName = "marcos",
            //    NormalizedUserName = "MARCOS",
            //    PasswordHash = hasher.HashPassword(null, "@Trocar01"),
            //    Email = "mfernandes@idutto.com",
            //    NormalizedEmail = "MFERNANDES@IDUTTO.COM",
            //    NomeCompleto = "Marcos Fernandes",
            //    Ativo = true,
            //    DataCadastro = DateTime.Now
            //});

            base.OnModelCreating(builder);
        }
    }
}
