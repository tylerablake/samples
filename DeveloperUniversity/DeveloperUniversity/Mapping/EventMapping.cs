using System.Data.Entity.ModelConfiguration;
using DeveloperUniversity.Models;

namespace DeveloperUniversity.Mapping
{
    public class EventMapping : EntityTypeConfiguration<Event>
    {
        public EventMapping()
        {
            HasKey(p => p.id);

            Property(p => p.text);
            Property(p => p.start_date).IsOptional();
            Property(p => p.end_date).IsRequired();
        }
    }
}