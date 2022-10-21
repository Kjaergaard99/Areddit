using System;
namespace Model
{
    public class Comment
    {
        public long CommentId { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; } = DateTime.Now;
        public double CommentVotes { get; set; } = 0;

        public string CommentUser { get; set; }

        public int PostId { get; set; }

        public void UpVoteComment()
        {
            CommentVotes = CommentVotes + 1;
        }

        public void DownVoteComment()
        {
            CommentVotes = CommentVotes - 1;
        }


        public Comment()
        {

        }
    }
}

