using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Reminder.Web.Models.Mapping
{
    public class HashMap : EntityTypeConfiguration<Hash>
    {
        public HashMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Key)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Field)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Hash", "HangFire");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Key).HasColumnName("Key");
            this.Property(t => t.Field).HasColumnName("Field");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.ExpireAt).HasColumnName("ExpireAt");
        }
    }
}
