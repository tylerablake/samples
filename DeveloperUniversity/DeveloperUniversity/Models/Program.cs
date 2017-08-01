using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeveloperUniversity.Models
{
    public class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}