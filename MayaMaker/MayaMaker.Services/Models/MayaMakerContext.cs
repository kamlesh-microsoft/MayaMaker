using Microsoft.EntityFrameworkCore;

namespace MayaMaker.Services.Models
{
    public class MayaMakerContext : DbContext
    {
        public MayaMakerContext(DbContextOptions<MayaMakerContext> options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Encounter> Encounters { get; set; }
        public DbSet<Scenario> Scenarios { get; set; }
        public DbSet<PatientKin> PatientKins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().ToTable("Patient");
            modelBuilder.Entity<Hospital>().ToTable("Hospital");
            modelBuilder.Entity<Doctor>().ToTable("Doctor");
            modelBuilder.Entity<Encounter>().ToTable("Encounter");
            modelBuilder.Entity<Scenario>().ToTable("Scenario");
            modelBuilder.Entity<PatientKin>().ToTable("PatientKin");
            base.OnModelCreating(modelBuilder);
        }
    }
}
