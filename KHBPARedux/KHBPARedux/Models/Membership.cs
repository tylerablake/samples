using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KHBPARedux.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}