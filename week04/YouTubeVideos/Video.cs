using System.ComponentModel.DataAnnotations;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comment = new List<Comment>();
    public static List<Video> _videos =  new List<Video>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _videos.Add(this);
    }
    public void AddComment(string name, string text){
        _comment.Add(new Comment(name,text));    
    }

    public int CountComments()
    {
        return _comment.Count;
    }


    public static void DisplayAll()
    {
        foreach(Video v in _videos)
        {
            Console.WriteLine($"Title : {v._title}");
            Console.WriteLine($"Author: {v._author}");
            Console.WriteLine($"Length: {v._length}");
            Console.WriteLine($"Comments: {v.CountComments()}");
            Console.WriteLine("Comments: ");
            foreach(var comment in v._comment)
            {
                Console.WriteLine($"\t -{comment._name}:{comment._text}");
            }
            Console.WriteLine();
        }
    }

}