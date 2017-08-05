using System.Data.Entity.ModelConfiguration;
using DeveloperUniversity.Models;

namespace DeveloperUniversity.Mapping
{
    public class CourseMapping : EntityTypeConfiguration<Course>
    {
        public CourseMapping()
        {
            HasKey(p => p.Id);

            Property(p => p.Title).IsRequired();
            Property(p => p.Credits).IsRequired();
            Property(p => p.ProgramId).IsRequired();
           // HasMany(p => p.Enrollments);
        }
    }
}