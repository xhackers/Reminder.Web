using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Reminder.Web.Models.Mapping
{
    public class SetMap : EntityTypeConfiguration<Set>
    {
        public SetMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Key)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("Set", "HangFire");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Key).HasColumnName("Key");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.ExpireAt).HasColumnName("ExpireAt");
        }
    }
}
