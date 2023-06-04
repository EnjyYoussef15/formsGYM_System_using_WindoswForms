using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinGYM
{
    internal class Datacontext :DbContext
    {
        public Datacontext():base("name=GYMCodeFirstConnection") 
        { }
        public DbSet<Manger> Mangers { get; set; }

        public DbSet<Classes> Classes { get; set; }
        public DbSet<Coach> Choachs { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Equipments> Equipments { get; set; }
        public DbSet<Trainee> Trainees { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Trainee>()
            //    .HasRequired(t => t.coach)
            //    .WithMany(c => c.trainees)
            //    .HasForeignKey(t => t.coachID)
            //    .WillCascadeOnDelete(true);

            modelBuilder.Entity<Coach>()
                .HasMany(c => c.trainees)
                .WithRequired(t => t.coach)
                .HasForeignKey(t => t.coachID)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Classes>()
               .HasMany(c => c.trainees)
               .WithRequired(t => t.clas)
               .HasForeignKey(t => t.clasID)
               .WillCascadeOnDelete(true);

            //    //modelBuilder.Entity<Trainee>()
            //    //.HasRequired(c => c.clas)
            //    //.WithMany(t => t.trainees)
            //    //.HasForeignKey(c => c.classId);

        }


    }
}
