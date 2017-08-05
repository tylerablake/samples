﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeveloperUniversity.Models.ViewModels.Enrollment
{
    public class CreateEnrollmentViewModel
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public int ProgramId { get; set; }
        public SelectList CourseDropDownList { get; set; }
        public SelectList StudentDropDownList { get; set; }
        public SelectList ProgramDropDownList { get; set; }

        //public virtual Course Course { get; set; }
        //public virtual Student Student { get; set; }
        //public virtual Program Program { get; set; }
    }
}