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
                db.Posts.Add(new Post { Title = "Hugo Boss", Text = "Han designede nazi-uniformer", User = "Hugo Helmig", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Spaghetti og kødsovs", Text = "Det min livret", User = "SpaghettiFan12", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Lasagne", Text = "Det smager bedre", User = "SpaghettiHater12", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Test7", Text = "Hey", User = "Yo", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Test8", Text = "nummer 8", User = "User8", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Test9", Text = "num 9", User = "nummer 9 gutten", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Reddit", Text = "Jeg foretrækker Areddit over Reddit", User = "FuckReddit", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Areddit", Text = "Jeg foretrækker også Areddit", User = "Aredditlover44", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Kat vs Hund", Text = "Jeg kan bedst lide hunde", User = "Ching", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Wallpapers", Text = "Pepe", User = "Pepe", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Messi", Text = "The Goat", User = "Lionel", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Sui", Text = "SUIIIIII", User = "Ronaldo", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Wiscounsin", Text = "Volleyball Team Leak", User = "Coach", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Tiktok", Text = "Jeg kan godt lide tiktok", User = "Tiktokelsker", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Rollo", Text = "Han nakker HDMI stik", User = "Mads", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Trump", Text = "Make America Great Again", User = "MAGA", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Obama", Text = "Han var en god præsident", User = "Barack", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Yndlingsfarve", Text = "Min er sort", User = "Min sjæl", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Aftensmads ideer", Text = "Wraps med bearnaise", User = "BearnaiseEnjoyer", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Bedre aftensmads ideer", Text = "Spaghetti med medister", User = "Mads-Emil", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Misfits Festival", Text = "Banger musik", User = "Fitsmis", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Det tager en evighed at ramme 50 posts", Text = "CTRL c + CTRL v", User = "IngenHænder", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Smukfest", Text = "Sjovt", User = "Hans Hansen", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Arsenal best in prem", Text = "Not up for debate", User = "Klog mand", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Norwich worst in championship", Text = "Facts", User = "Klogere mand", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Sukkkerfar", Text = "Hvad er det her for noget lorte musik", User = "Mads K", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Koldskål", Text = "Goated om sommeren", User = "KoldskålErBanger", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Fedt", Text = "Jeg spiser meget fedt", User = "FedtMand", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Lofi Hip Hop", Text = "Beats to relax/study to", User = "Mirk", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Skanderborg", Text = "Bedre end Vejen", User = "Mig", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "VM", Text = "Danmark > alle andre", User = "Verdensmand", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "EM", Text = "Sterling divede", User = "JegHaderSterling", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "EM v2", Text = "It's coming Rome", User = "IngenKanLideEngland", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Kamel", Text = "Jeg ryger Camel", User = "CamelSmoker", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Nummer 38 tror jeg?", Text = "Næsten done", User = "Arbejdshest", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "SoMe", Text = "Sociale medier", User = "MeSo", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "background-image", Text = "url", User = "position", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "CRTL", Text = "+", User = "Q", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Emilia Hult", Text = "Hun er lækker", User = "Dev1ce", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Frugt", Text = "Banan er goatet", User = "Monkey", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Jamal", Text = "Jamal", User = "Jamal", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Kesi", Text = "Tiden står stille", User = "Ft en eller anden", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Højre", Text = "Venstre", User = "Fremad", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Add", Text = "new", User = "Post", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "48", Text = "48", User = "49", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Test3", Text = "Dette er en test", User = "Mads", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Jeg elsker at poste", Text = "Jeg har gjort det mange gange nu", User = "Postmand", Date = DateTime.Now });
                db.Posts.Add(new Post { Title = "Sidste post", Text = "Ses", User = "Nemt nemt nemt", Date = DateTime.Now });
            }

            db.SaveChanges();
        }



        // post aktioner
        public List<Post> GetPosts()
        {
            List<Post> posts = db.Posts.ToList();
            return posts;
        }

        public Post GetPost(int id)
        {
            Post post = db.Posts.FirstOrDefault(a => a.PostId == id);
            List<Comment> postComments = db.Comments.Where(a => a.PostId == id).ToList();
            post.Comments = postComments;
            return post;
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
        public string CreateComment(string CommentText, string CommentUser, int PostId)
        {
            Post commentPost = db.Posts.FirstOrDefault(a => a.PostId == PostId);
            Comment newComment = new Comment { CommentText = CommentText, CommentUser = CommentUser, PostId = commentPost.PostId };
            db.Comments.Add(newComment);
            db.SaveChanges();
            return "Comment added";
        }

        public Comment UpvoteComment(int id)
        {
            Comment upvotedComment = db.Comments.FirstOrDefault(a => a.CommentId == id);
            upvotedComment.UpvoteComment();
            db.SaveChanges();
            return upvotedComment;
        }

        public Comment DownvoteComment(int id)
        {
            Comment downvotedComment = db.Comments.FirstOrDefault(a => a.CommentId == id);
            downvotedComment.DownvoteComment();
            db.SaveChanges();
            return downvotedComment;
        }
    }
}

//mit push virker
// - the goat