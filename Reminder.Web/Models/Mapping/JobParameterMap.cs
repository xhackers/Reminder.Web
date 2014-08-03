using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Reminder.Web.Models.Mapping
{
    public class JobParameterMap : EntityTypeConfiguration<JobParameter>
    {
        public JobParameterMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("JobParameter", "HangFire");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.JobId).HasColumnName("JobId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.Job)
                .WithMany(t => t.JobParameters)
                .HasForeignKey(d => d.JobId);

        }
    }
}
