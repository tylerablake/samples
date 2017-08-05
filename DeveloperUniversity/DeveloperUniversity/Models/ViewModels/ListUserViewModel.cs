using System.Collections.Generic;

namespace DeveloperUniversity.Models.ViewModels
{
    public class ListUserViewModel
    {
        public IList<ApplicationUser> Users { get; set; }
        public IList<string> Roles { get; set; }
    }
}