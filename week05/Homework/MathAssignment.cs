

public class MathAssignment : Assignment
{

    private string _textBookSection;
    private string _problems;



    public MathAssignment(string studentName, string topic,  string textaBookSection, string problems): base(studentName, topic)
    {
        _textBookSection = textaBookSection;
        _problems = problems;


}

    public  string GetHomeWorkList()
    {


        return $"{_textBookSection} - {_problems}";
    }




}