using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SINACO_ERP.Areas.Security.Models
{
    public class MyUser : IdentityUser<int, MyLogin, MyUserRole, MyClaim>
    {
        //public override string Email { get; set; }

        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> PageSize { get; set; }
        public int CompanyId { get; set; }
        public int EmployeeId { get; set; }
    }

    public class MyUserRole : IdentityUserRole<int> { }
    public class MyRole : IdentityRole<int, MyUserRole> { }
    public class MyLogin : IdentityUserLogin<int>
    { }

    public class MyClaim : IdentityUserClaim<int>
    { }

    public class ApplicationDbContext : IdentityDbContext<MyUser, MyRole, int, MyLogin, MyUserRole, MyClaim>
    {
        public ApplicationDbContext()
            : base("conLogin")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MyUser>().ToTable("AspNetUsers");
            modelBuilder.Entity<MyUserRole>().ToTable("AspNetUserRoles");
            modelBuilder.Entity<MyRole>().ToTable("AspNetRoles");
            modelBuilder.Entity<MyLogin>().ToTable("AspNetUserLogins");
            modelBuilder.Entity<MyClaim>().ToTable("AspNetUserClaims");
            modelBuilder.Entity<MyUser>().Property(r => r.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<MyRole>().Property(r => r.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<MyClaim>().Property(r => r.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }

        public System.Data.Entity.DbSet<SINACO_ERP.Areas.Security.Models.RegisterViewModel> RegisterViewModels { get; set; }
    }
}