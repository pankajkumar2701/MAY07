using Microsoft.EntityFrameworkCore;
using MAY07.Entities;

namespace MAY07.Data
{
    /// <summary>
    /// Represents the database context for the application.
    /// </summary>
    public class MAY07Context : DbContext
    {
        /// <summary>
        /// Configures the database connection options.
        /// </summary>
        /// <param name="optionsBuilder">The options builder used to configure the database connection.</param>
        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-GFUVFUP;Initial Catalog=T754323_MAY07;Persist Security Info=True;user id=pankazz;password=123456;Integrated Security=false;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;");
        }

        /// <summary>
        /// Configures the model relationships and entity mappings.
        /// </summary>
        /// <param name="modelBuilder">The model builder used to configure the database model.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInRole>().HasKey(a => a.Id);
            modelBuilder.Entity<UserToken>().HasKey(a => a.Id);
            modelBuilder.Entity<RoleEntitlement>().HasKey(a => a.Id);
            modelBuilder.Entity<Entity>().HasKey(a => a.Id);
            modelBuilder.Entity<Tenant>().HasKey(a => a.Id);
            modelBuilder.Entity<User>().HasKey(a => a.Id);
            modelBuilder.Entity<Role>().HasKey(a => a.Id);
            modelBuilder.Entity<Patient>().HasKey(a => a.Id);
            modelBuilder.Entity<Doctor>().HasKey(a => a.Id);
            modelBuilder.Entity<Appointment>().HasKey(a => a.Id);
            modelBuilder.Entity<BloodGroup>().HasKey(a => a.Id);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.RoleId_Role).WithMany().HasForeignKey(c => c.RoleId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.UserId_User).WithMany().HasForeignKey(c => c.UserId);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<UserInRole>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<UserToken>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<UserToken>().HasOne(a => a.UserId_User).WithMany().HasForeignKey(c => c.UserId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.RoleId_Role).WithMany().HasForeignKey(c => c.RoleId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.EntityId_Entity).WithMany().HasForeignKey(c => c.EntityId);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<RoleEntitlement>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<Entity>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Entity>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<Entity>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<User>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Role>().HasOne(a => a.TenantId_Tenant).WithMany().HasForeignKey(c => c.TenantId);
            modelBuilder.Entity<Role>().HasOne(a => a.CreatedBy_User).WithMany().HasForeignKey(c => c.CreatedBy);
            modelBuilder.Entity<Role>().HasOne(a => a.UpdatedBy_User).WithMany().HasForeignKey(c => c.UpdatedBy);
            modelBuilder.Entity<Patient>().HasOne(a => a.BloodGroup_BloodGroup).WithMany().HasForeignKey(c => c.BloodGroup);
            modelBuilder.Entity<Doctor>().HasOne(a => a.BloodGroup_BloodGroup).WithMany().HasForeignKey(c => c.BloodGroup);
            modelBuilder.Entity<Appointment>().HasOne(a => a.PatientId_Patient).WithMany().HasForeignKey(c => c.PatientId);
        }

        /// <summary>
        /// Represents the database set for the UserInRole entity.
        /// </summary>
        public DbSet<UserInRole> UserInRole { get; set; }

        /// <summary>
        /// Represents the database set for the UserToken entity.
        /// </summary>
        public DbSet<UserToken> UserToken { get; set; }

        /// <summary>
        /// Represents the database set for the RoleEntitlement entity.
        /// </summary>
        public DbSet<RoleEntitlement> RoleEntitlement { get; set; }

        /// <summary>
        /// Represents the database set for the Entity entity.
        /// </summary>
        public DbSet<Entity> Entity { get; set; }

        /// <summary>
        /// Represents the database set for the Tenant entity.
        /// </summary>
        public DbSet<Tenant> Tenant { get; set; }

        /// <summary>
        /// Represents the database set for the User entity.
        /// </summary>
        public DbSet<User> User { get; set; }

        /// <summary>
        /// Represents the database set for the Role entity.
        /// </summary>
        public DbSet<Role> Role { get; set; }

        /// <summary>
        /// Represents the database set for the Patient entity.
        /// </summary>
        public DbSet<Patient> Patient { get; set; }

        /// <summary>
        /// Represents the database set for the Doctor entity.
        /// </summary>
        public DbSet<Doctor> Doctor { get; set; }

        /// <summary>
        /// Represents the database set for the Appointment entity.
        /// </summary>
        public DbSet<Appointment> Appointment { get; set; }

        /// <summary>
        /// Represents the database set for the BloodGroup entity.
        /// </summary>
        public DbSet<BloodGroup> BloodGroup { get; set; }
    }
}