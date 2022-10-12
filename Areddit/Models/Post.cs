using System;
using System.Xml.Linq;

namespace Model
{
    public class Post
    {
        public long PostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public double Votes { get; set; }

        public string User { get; set; }
        public List<Comment> Comments { get; set; }


        public override string ToString()
        {
            return $"Id: {PostId}, Title: {Title}, Text: {Text}, Date: {Date}, Votes: {Votes}, User: {User}";
        }
    }
}

