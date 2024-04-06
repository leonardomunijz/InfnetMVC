using InfnetMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoMVCEntityIdenty.Models;

namespace ProjetoMVCEntityIdenty.DAL
{
    public class InfnetDbContext : IdentityDbContext
    {
        public InfnetDbContext(DbContextOptions<InfnetDbContext> options) : base (options) 
        {
            
        }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }

    }
}
