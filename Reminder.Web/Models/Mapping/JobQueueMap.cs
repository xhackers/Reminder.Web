using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Reminder.Web.Models.Mapping
{
    public class JobQueueMap : EntityTypeConfiguration<JobQueue>
    {
        public JobQueueMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Queue)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("JobQueue", "HangFire");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.JobId).HasColumnName("JobId");
            this.Property(t => t.Queue).HasColumnName("Queue");
            this.Property(t => t.FetchedAt).HasColumnName("FetchedAt");
        }
    }
}
