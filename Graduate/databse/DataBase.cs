namespace Graduate.databse
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataBase : DbContext
    {
        public DataBase()
            : base("name=DataBase")
        {
        }

        public virtual DbSet<freeWork> freeWork { get; set; }
        public virtual DbSet<logs> logs { get; set; }
        public virtual DbSet<persons> persons { get; set; }
        public virtual DbSet<persToWork> persToWork { get; set; }
        public virtual DbSet<role> role { get; set; }
        public virtual DbSet<typeQualification> typeQualification { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<usersRole> usersRole { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<freeWork>()
                .HasMany(e => e.persToWork)
                .WithOptional(e => e.freeWork)
                .HasForeignKey(e => e.idFreeWork)
                .WillCascadeOnDelete();

            modelBuilder.Entity<persons>()
                .HasMany(e => e.persToWork)
                .WithOptional(e => e.persons)
                .HasForeignKey(e => e.idPers)
                .WillCascadeOnDelete();

            modelBuilder.Entity<persToWork>()
                .Property(e => e.verificationArrival)
                .IsFixedLength();

            modelBuilder.Entity<role>()
                .HasMany(e => e.usersRole)
                .WithOptional(e => e.role)
                .HasForeignKey(e => e.idRole);

            modelBuilder.Entity<typeQualification>()
                .HasMany(e => e.persons)
                .WithOptional(e => e.typeQualification)
                .HasForeignKey(e => e.idTypeQualification);

            modelBuilder.Entity<users>()
                .HasMany(e => e.logs)
                .WithOptional(e => e.users)
                .HasForeignKey(e => e.idUser);

            modelBuilder.Entity<users>()
                .HasMany(e => e.usersRole)
                .WithOptional(e => e.users)
                .HasForeignKey(e => e.idUser);
        }
    }
}
