using Do_An_1.DomainClass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_1
{
    public class UniversityContext : DbContext
    {
        public UniversityContext() : base("Name=UniversityDB-ConnectionString")
        {
            Database.SetInitializer<UniversityContext>(new UniversityDBInitializer());
            //Database.SetInitializer<UniversityContext>(new DropCreateDatabaseIfModelChanges<UniversityContext>());
            //Database.SetInitializer<UniversityContext>(new DropCreateDatabaseAlways<UniversityContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // Defualt Schema
            modelBuilder.HasDefaultSchema("dbo");

            // Primary Key 
            modelBuilder.Entity<Student>().HasKey(s => s.StudentID);
            modelBuilder.Entity<Department>().HasKey(s => s.DepartmentID);
            modelBuilder.Entity<DomainClass.Subject>().HasKey(s => s.SubjectID);
            modelBuilder.Entity<Professor>().HasKey(s => s.ProfessorID);
            modelBuilder.Entity<DomainClass.Class>().HasKey(s => s.ClassID);
            modelBuilder.Entity<Grade>().HasKey(s => new { s.StudentID, s.ClassID });

            // Foreign Key Constraint
            modelBuilder.Entity<Department>().Property(p => p.DepartmentID).HasColumnOrder(100);
            modelBuilder.Entity<Student>()
                .HasRequired<Department>(s => s.Department)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.DepartmentID);

            modelBuilder.Entity<DomainClass.Class>()
                .HasRequired<Professor>(s => s.Professor)
                .WithMany(g => g.Classes)
                .HasForeignKey(s => s.ProfessorID);

            modelBuilder.Entity<DomainClass.Class>()
                .HasRequired<DomainClass.Subject>(s => s.Subject)
                .WithMany(g => g.Classes)
                .HasForeignKey(s => s.SubjectID);

            modelBuilder.Entity<Grade>()
                .HasRequired<DomainClass.Class>(s => s.Class)
                .WithMany(g => g.Grades)
                .HasForeignKey(s => s.ClassID);

            modelBuilder.Entity<Grade>()
                .HasRequired<Student>(s => s.Student)
                .WithMany(g => g.Grades)
                .HasForeignKey(s => s.StudentID);

            //Other
            modelBuilder.Entity<Department>()
                .Property(s => s.PhoneNumber)
                .HasMaxLength(10).IsFixedLength();
            modelBuilder.Entity<Subject>()
                .Property(s => s.SubjectID)
                .HasMaxLength(6).IsFixedLength();

            //modelBuilder.Entity<Grade>().MapToStoredProcedures();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<DomainClass.Class> Classes { get; set; }
        public DbSet<DomainClass.Subject> Subjects { get; set; }
    }
}
