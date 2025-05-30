public class Reference
{

    private string _book;
    private int _chapter;

    private int _startVerse;

    private int _endVerse;


    public string GetBook()
    {
        return _book;

    }

    public void SetBook(string book)
    {

        _book = book;

    }


    public int GeChapter()
    {
        return _chapter;

    }

    public void SetChapter(int chapter)
    {

        _chapter = chapter;
    }

    public int GetStartVerse()
    {
        return _startVerse;

    }

    public void SetStartVerse(int startVerse)
    {

        _startVerse = startVerse;

    }

    public int GetEndVerse()
    {
        return _endVerse;

    }

    public void SetEndVerse(int endVerse)
    {

        _endVerse = endVerse;

    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {

        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;


    }

    public Reference(string book, int chapter, int verse)
    {

        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;

    }

    public string GetDisplayText()
    {


        return _startVerse == _endVerse ? $"{_book} {_chapter} : {_startVerse} " :
         $"{_book} {_chapter}:{_startVerse}-{_endVerse}";

    }





}