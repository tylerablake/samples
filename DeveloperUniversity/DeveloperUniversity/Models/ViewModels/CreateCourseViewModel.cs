using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeveloperUniversity.Models.ViewModels
{
    public class CreateCourseViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string CatalogNumber { get; set; }
        public int Credits { get; set; }
        public int ProgramId { get; set; }
        public int CampusId { get; set; }
        public virtual Program Program { get; set; }
    }
}