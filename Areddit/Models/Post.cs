using System;
using System.Xml.Linq;

namespace Model
{
    public class Post
    {
        public long PostId { get; set; } = 0;
        public string Title { get; set; } = "";
        public string Text { get; set; } = "";
        public DateTime Date { get; set; } = DateTime.Now;
        public double Votes { get; set; } = 0;

        public string User { get; set; } = "";

        public List<Comment> Comments { get; set; }


        public void UpVote()
        {
            Votes = Votes + 1;
        }

        public void DownVote()
        {
            Votes = Votes - 1;
        }


        public Post()
        {

        }


        public override string ToString()
        {
            return $"Id: {PostId}, Title: {Title}, Text: {Text}, Date: {Date}, Votes: {Votes}, User: {User}";
        }
    }
}

