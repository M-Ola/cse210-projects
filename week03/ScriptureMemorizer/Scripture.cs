
// Author: Monsuru Oladipo. CSE 230


public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    private Random _random;



    public Scripture(Reference reference, String text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        foreach (var word in text.Split(" "))
            _words.Add(new Word(word));

    }




    public Reference GetReference()
    {

        return _reference;
    }


    public void SetReference(Reference reference)
    {

        _reference = reference;

    }


    public List<Word> GetWords()
    {

        return _words;
    }


    public void SetWords(List<Word> words)
    {

        _words = words;

    }

    public Random GetRandom()
    {

        return _random;
    }


    public void SetRandom(Random random)
    {

        _random = random;

    }

    public void HideRandomWords()
    {
        List<Word> visibleWords = _words.FindAll(word => !word.IsWordHidden());

        if (visibleWords.Count > 0)
        {
            Word wordToHide = visibleWords[_random.Next(visibleWords.Count)];
            wordToHide.Hide();

        }
    }

    public bool AllWordsHidden()
    {

        return _words.TrueForAll(Word => Word.IsWordHidden());

    }

    public string GetDisplayText()
    {


        string scriptureText = string.Join(" ", _words.ConvertAll(word => word.GetDisplayText()));

        return $"{_reference.GetDisplayText()}\n{scriptureText}";


    }


}