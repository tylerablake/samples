﻿using DeveloperUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeveloperUniversity.Repositories
{
    public class BlogRepository
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        public IList<Post> Posts(int pageNo, int pageSize)
        {
            var posts = _db.Posts
                                  .Where(p => p.Published)
                                  .OrderByDescending(p => p.PostedOn)
                                  .Skip(pageNo * pageSize)
                                  .Take(pageSize)
                                  //.Fetch(p => p.Category)
                                  .ToList();

            var postIds = posts.Select(p => p.Id).ToList();

            return _db.Posts
                  .Where(p => postIds.Contains(p.Id))
                  .OrderByDescending(p => p.PostedOn)
                  //.FetchMany(p => p.Tags)
                  .ToList();
        }

        public int TotalPosts()
        {
            return _db.Posts.Where(p => p.Published != null).Count();
        }
    }
}