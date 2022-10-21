﻿using Microsoft.EntityFrameworkCore;
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
            return db.Posts.FirstOrDefault(a => a.PostId == id);
        }

        public string CreatePost(string title, string text, string user)
        {
            db.Posts.Add(new Post { Title = title, Text = text, User = user });
            db.SaveChanges();
            return "Post created";
        }

        public string CreateComment(string CommentText, string CommentUser, int id)
        {
            db.Comments.Add(new Comment { CommentText = CommentText, CommentUser = CommentUser, PostId = id});
            db.SaveChanges();
            return "Comment added";
        }

    }
}

//mit push virker
// - the goat