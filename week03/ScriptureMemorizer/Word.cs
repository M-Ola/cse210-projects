public class Word
{

    private string _text;
    private bool _isHidden;

    public Word(string text)
    {

        _text = text;

        _isHidden = false;
}
    public string GetText()
    {
        return _text;

    }

    public void SetText(string text)
    {

        _text = text;

    }

    public bool IsWordHidden()
    {
        return _isHidden;

    }

    public void Hide()
    {

        _isHidden = true;

    }

    public string GetDisplayText()
    {

        return _isHidden ? "___" : _text;

    }
    




    }