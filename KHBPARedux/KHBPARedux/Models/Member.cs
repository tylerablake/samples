using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KHBPARedux.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        //This is a navigation property and will cause our Members to have a relationship to Memberships
        public Membership Membership { get; set; }
    }
}