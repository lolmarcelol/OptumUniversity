using OptumUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OptumUniversity.DAL
{
    public class UniversityContext : DbContext
    {

        public UniversityContext() : base("UniversityContext")
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos{ get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AD> AD { get; set; }
        public DbSet<DC> DC { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}