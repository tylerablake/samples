using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeveloperUniversity.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Student> StudentsList { get; set; }
        public IEnumerable<Event> TodosList { get; set; }
    }
}