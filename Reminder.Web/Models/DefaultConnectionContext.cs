using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Reminder.Web.Models.Mapping;

namespace Reminder.Web.Models
{
    public partial class DefaultConnectionContext : DbContext
    {
        static DefaultConnectionContext()
        {
            Database.SetInitializer<DefaultConnectionContext>(null);
        }

        public DefaultConnectionContext()
            : base("Name=DefaultConnection")
        {
        }

        public DbSet<AspNetRole> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        //public DbSet<Counter> Counters { get; set; }
        //public DbSet<Hash> Hashes { get; set; }
        //public DbSet<Job> Jobs { get; set; }
        //public DbSet<JobParameter> JobParameters { get; set; }
        //public DbSet<JobQueue> JobQueues { get; set; }
        //public DbSet<List> Lists { get; set; }
        //public DbSet<Schema> Schemata { get; set; }
        //public DbSet<Server> Servers { get; set; }
        //public DbSet<Set> Sets { get; set; }
        //public DbSet<State> States { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AspNetRoleMap());
            modelBuilder.Configurations.Add(new AspNetUserClaimMap());
            modelBuilder.Configurations.Add(new AspNetUserLoginMap());
            modelBuilder.Configurations.Add(new AspNetUserMap());
            //modelBuilder.Configurations.Add(new CounterMap());
            //modelBuilder.Configurations.Add(new HashMap());
            //modelBuilder.Configurations.Add(new JobMap());
            //modelBuilder.Configurations.Add(new JobParameterMap());
            //modelBuilder.Configurations.Add(new JobQueueMap());
            //modelBuilder.Configurations.Add(new ListMap());
            //modelBuilder.Configurations.Add(new SchemaMap());
            //modelBuilder.Configurations.Add(new ServerMap());
            //modelBuilder.Configurations.Add(new SetMap());
            //modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new MessageMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
