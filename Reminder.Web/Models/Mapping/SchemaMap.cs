using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Reminder.Web.Models.Mapping
{
    public class SchemaMap : EntityTypeConfiguration<Schema>
    {
        public SchemaMap()
        {
            // Primary Key
            this.HasKey(t => t.Version);

            // Properties
            this.Property(t => t.Version)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Schema", "HangFire");
            this.Property(t => t.Version).HasColumnName("Version");
        }
    }
}
