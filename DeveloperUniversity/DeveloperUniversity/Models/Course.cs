using System.Collections.Generic;

namespace DeveloperUniversity.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string CatalogNumber { get; set; }
        public int Credits { get; set; }
        public int ProgramId { get; set; }
        public int CampusId { get; set; }       

        //public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}