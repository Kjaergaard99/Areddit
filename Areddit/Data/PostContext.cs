using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Data
{
    public class PostContext : DbContext
    {
        public DbSet<Post> Posts => Set<Post>();
        public DbSet<Comment> Comments => Set<Comment>();
        public string DbPath { get; }

        public PostContext(DbContextOptions<PostContext> options)
            : base(options)
        {
            
        }

    }
}

//Ses