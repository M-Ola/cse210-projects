// Author  Monsuru Oladipo. CSE 210, Week 03 Fractions


public class Fraction
{

    private int _topNum;
    private int _bottonNum;

    public Fraction()
    {
        _topNum = 1;
        _bottonNum = 1;
    }
    public Fraction(int wholeNum)
    {
        _bottonNum = 1;
        _topNum = wholeNum;
    }
    public Fraction(int top, int bottom)
    {
        _topNum = top;
        _bottonNum = bottom;
    }
    public int GetTop()
    {

        return _topNum;
    }

    public void SetTop(int topNum)
    {
        _topNum = topNum;

    }

    public int GetBottom()
    {

        return _bottonNum;
    }
    public void SetBottom(int bottonNum)
    {
        _bottonNum = bottonNum;

    }

    public string GetFractionString()
    {

        return $"{_topNum}/{_bottonNum}";
    }

    public double GetDecimalValue()
    {

        return (double)_topNum / (double)_bottonNum;


    }

}