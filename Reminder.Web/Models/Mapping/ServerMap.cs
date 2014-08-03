using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Reminder.Web.Models.Mapping
{
    public class ServerMap : EntityTypeConfiguration<Server>
    {
        public ServerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Server", "HangFire");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Data).HasColumnName("Data");
            this.Property(t => t.LastHeartbeat).HasColumnName("LastHeartbeat");
        }
    }
}
