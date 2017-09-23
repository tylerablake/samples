using System.Collections.Generic;

namespace DeveloperUniversity.Models.ViewModels
{
    public class BlogListViewModel
    {
        public IList<Post> Posts { get; set; }

        public int TotalPosts { get; set; }
    }
}