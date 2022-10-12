using System;
namespace Model
{
    public class Comment
    {
        public long CommentId { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public double CommentVotes { get; set; }

        public string User { get; set; }
        public Comment()
        {

        }
    }
}

