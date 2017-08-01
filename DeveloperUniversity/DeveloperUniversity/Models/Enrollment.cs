using System.ComponentModel.DataAnnotations;
using DeveloperUniversity.Models.ViewModels;

namespace DeveloperUniversity.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public int ProgramId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
        public virtual Program Program { get; set; }
        //[EnumDataType(typeof(Grade))]
        //public Grade? Grade { get; set; }
    }

    //public enum Grade
    //{
    //    A,B,C,D,F
    //}
}