using System;
using System.Collections.Generic;

namespace StringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comments)
        {
            Comments.Add(comments);
        }

        public void RemoveComment(Comment comments)
        {
            Comments.Remove(comments);
        }

        public override string ToString()
        {
            System.Text.StringBuilder temp = new System.Text.StringBuilder();
            temp.AppendLine(Title);
            temp.Append(Likes);
            temp.Append(" Likes - ");
            temp.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            temp.AppendLine(Content);
            temp.AppendLine("Comments:");
            foreach(Comment c in Comments)
            {
                temp.AppendLine(c.Text);
            }

            return temp.ToString();
        }
    }
}
