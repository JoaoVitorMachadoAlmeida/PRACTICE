using System;
using System.Text;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    Comment c1 = new Comment("Have a nice trip!");
    Comment c2 = new Comment("Wow that's awesome!");
    Comment c3 = new Comment("Good night");
    Comment c4 = new Comment("May the Force be with you");
    
    
    Post p1 = new Post(
        DateTime.ParseExact("20/08/2024 09:51:54", "dd/MM/yyyy HH:mm:ss", null),
        "Traveling to New Zealand",
        "I'm going to visit this wonderful country!",
        12
        );
    p1.AddComment(c1); 
    p1.AddComment(c2);
    
    Post p2 = new Post(
        DateTime.ParseExact("17/08/2024 10:32:10", "dd/MM/yyyy HH:mm:ss", null),
        "Good night guys",
        "See you tomorrow",
        5
        );
    p2.AddComment(c3);
    p2.AddComment(c4);
    
    Console.WriteLine(p1);
    Console.WriteLine(p2);
  }
}
/***************************************************/
class Comment
{
    public string Text{get;set;}
    
    public Comment()
    {
    }
    
    public Comment(string text)
    {
        Text = text;
    }
}
/******************************************************/
class Post
{
    public DateTime Moment {get;set;}
    public string Title {get;set;}
    public string Content{get;set;}
    public int Likes {get;set;}
    public List<Comment> Comments {get;set;} = new List <Comment>();
    
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
   public void AddComment(Comment comment)
   {
       Comments.Add(comment);
   }
   public void RemoveComment(Comment comment)
   {
       Comments.Remove(comment);
   }
   
   public override string ToString()
   {
       StringBuilder sb = new StringBuilder();
       sb.AppendLine(Title);
       sb.Append(Likes);
       sb.Append(" Likes - ");
       sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
       sb.AppendLine(Content);
       sb.AppendLine("Comments:");
       foreach(Comment c in Comments)
       {
           sb.AppendLine(c.Text);
       }
       
       return sb.ToString();
       
   }
}
