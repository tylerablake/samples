using System;
using System.ComponentModel.DataAnnotations;

namespace DeveloperUniversity.Models.ViewModels
{
    public class AbsenceViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Absence Date")]
        public DateTime AbsenceDate { get; set; }
        [Display(Name = "Student First Name")]
        public string StudentFirstName { get; set; }
        [Display(Name = "Student Last Name")]
        public string StudentLastName { get; set; }
        [Display(Name = "Course Title")]
        public string CourseTitle { get; set; }

        public int StudentId { get; set; }
        public int CourseId { get; set; }

    }
}