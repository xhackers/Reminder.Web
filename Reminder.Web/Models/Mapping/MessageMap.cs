using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Reminder.Web.Models.Mapping
{
    public class MessageMap : EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            // Primary Key
            this.HasKey(t => t.GUID);

            // Properties
            this.Property(t => t.GUID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserGUID)
                .HasMaxLength(50);

            this.Property(t => t.Message1)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Messages");
            this.Property(t => t.GUID).HasColumnName("GUID");
            this.Property(t => t.UserGUID).HasColumnName("UserGUID");
            this.Property(t => t.DateOFBirth).HasColumnName("DateOFBirth");
            this.Property(t => t.Message1).HasColumnName("Message");
            this.Property(t => t.Notify).HasColumnName("Notify");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasOptional(t => t.User)
                .WithMany(t => t.Messages)
                .HasForeignKey(d => d.UserGUID);

        }
    }
}
