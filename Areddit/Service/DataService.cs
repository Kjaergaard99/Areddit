using Microsoft.EntityFrameworkCore;
using System;
using Model;
using Data;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using Microsoft.Extensions.Hosting;

namespace Service
{
    public class DataService
    {
        private PostContext db { get; }




        public DataService(PostContext db)

        {
            this.db = db;
        }

        public void SeedData()
        {

            Post post = db.Posts.FirstOrDefault()!;
            if (post == null)
            {
                db.Posts.Add(new Post { Title = "Test1", Text = "Det her er nummer 1", User = "Mads-Emil", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Test2", Text = "Det her er nummer 2", User = "Daniel", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Test3", Text = "Dette er en test", User = "Mads", Date = DateTime.Now });
            }
            db.SaveChanges();
        }




        public List<Post> GetPosts()
        {
            return db.Posts.ToList();
        }
        public Post GetPost(int id)
        {
            return db.Posts.Include(t => t.Comments).FirstOrDefault(t => t.PostId == id);
        }
    }
}

