using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using GroupT.Models.Tables;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace GroupT.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

        //Properties
        public string Id_Number { get; set; }
        public string Licence_Code { get; set; }
        public string Gender { get; set; }
        public DateTime Created_On { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //Properties
        public DbSet<Instructors> Instructor { get; set; }
        public DbSet<Learners> Learners { get; set; }
        public DbSet<Vehicles> Vehicles { get; set; }
        public DbSet<DrivingGrounds> DrivingGrounds { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<Administrators> Administrators { get; set; }
        //Constructors
        public ApplicationDbContext(): base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        //Methods
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}