using System.Transactions;

public class Video
{



    public List<Comment> _comments;

    public string _title;
    public string _author;
    public int _length;

    public Video(string title, string author, int length)
    {

        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();


    }


    public int GetNumberOfComment()
    {
        return _comments.Count;


}

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }



    public void displayVideoInfo()
    {

        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_author}");
        Console.WriteLine($"{_length}");

        foreach (Comment comment in _comments)
        {

            Console.WriteLine($"{comment._name} : {comment._text}");

        }




    }






}