using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Reminder.Web.Models.Mapping
{
    public class JobMap : EntityTypeConfiguration<Job>
    {
        public JobMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.StateName)
                .HasMaxLength(20);

            this.Property(t => t.InvocationData)
                .IsRequired();

            this.Property(t => t.Arguments)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Job", "HangFire");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StateId).HasColumnName("StateId");
            this.Property(t => t.StateName).HasColumnName("StateName");
            this.Property(t => t.InvocationData).HasColumnName("InvocationData");
            this.Property(t => t.Arguments).HasColumnName("Arguments");
            this.Property(t => t.CreatedAt).HasColumnName("CreatedAt");
            this.Property(t => t.ExpireAt).HasColumnName("ExpireAt");
        }
    }
}
