﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeveloperUniversity.Models
{
    public class Post
    {
        public virtual int Id { get; set; }

        public virtual string Title { get; set; }

        [DisplayName("Short Description")]
        public virtual string ShortDescription { get; set; }

        public virtual string Description { get; set; }

        public virtual string Meta { get; set; }

        public virtual string UrlSlug { get; set; }

        public virtual bool Published { get; set; }
        
        public virtual DateTime PostedOn { get; set; }

        public virtual DateTime? Modified { get; set; }

        public virtual Category Category { get; set; }

        public virtual IList<Tag> Tags { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}