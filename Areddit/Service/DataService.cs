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



        // post aktioner
        public List<Post> GetPosts()
        {
            return db.Posts.ToList();
        }

        public Post GetPost(int id)
        {
            return db.Posts.FirstOrDefault(a => a.PostId == id);
        }

        public string CreatePost(string title, string text, string user)
        {
            db.Posts.Add(new Post { Title = title, Text = text, User = user });
            db.SaveChanges();
            return "Post created";
        }

        public Post UpvotePost(int id)
        {
            Post upvotedPost = db.Posts.FirstOrDefault(a => a.PostId == id);
            upvotedPost.Upvote();
            db.SaveChanges();
            return db.Posts.FirstOrDefault(a => a.PostId == id);
        }

        public Post DownvotePost(int id)
        {
            Post upvotedPost = db.Posts.FirstOrDefault(a => a.PostId == id);
            upvotedPost.Downvote();
            db.SaveChanges();
            return db.Posts.FirstOrDefault(a => a.PostId == id);
        }

        // comment aktioner
        public string CreateComment(string CommentText, string CommentUser, int id)
        {
            Post commentPost = db.Posts.FirstOrDefault(a => a.PostId == id);
            Comment newComment = new Comment { CommentText = CommentText, CommentUser = CommentUser };
            db.Comments.Add(newComment);
            commentPost.Comments.Add(newComment);
            db.SaveChanges();
            return "Comment added";
        }

        public Comment UpvoteComment()
        {

        }

        public Comment DownvoteComment()
        {

        }
    }
}

//mit push virker
// - the goat