using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Reminder.Web.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.GUID);

            // Properties
            this.Property(t => t.GUID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Token)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.FirstName)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.LastName)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Users");
            this.Property(t => t.GUID).HasColumnName("GUID");
            this.Property(t => t.Token).HasColumnName("Token");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
        }
    }
}
