using System.Data.Entity.ModelConfiguration;
using DeveloperUniversity.Models;

namespace DeveloperUniversity.Mapping
{
    public class EnrollmentMapping : EntityTypeConfiguration<Enrollment>
    {
        public EnrollmentMapping()
        {
            HasKey(p => p.Id);

            Property(p => p.CourseId).IsRequired();
            //Property(p => p.Grade).IsOptional();
            Property(p => p.StudentId).IsRequired();
            Property(p => p.ProgramId).IsRequired();

            HasRequired(p => p.Course);
            HasRequired(p => p.Student);
            HasRequired(p => p.Program);           
        }
    }
}