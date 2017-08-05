using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeveloperUniversity.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int StudentNumber { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }        
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        public string Standing { get; set; }
        public bool HasGraduated { get; set; }
        public int CampusId { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}