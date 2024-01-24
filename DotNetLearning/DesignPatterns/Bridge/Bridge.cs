public interface ILanguage
{
    string Translate(string text);
}

public abstract class Subject
{
    protected ILanguage language;
    public Subject(ILanguage language)
    {
        this.language = language;
    }
    public abstract void DisplayContent();
}

public class English : ILanguage
{
    public string Translate(string text)
    {
        return text;
    }
}

public class Math : Subject
{
    public Math(ILanguage language) : base(language) { }
    public override void DisplayContent()
    {
        string text = "This is from Math";
        Console.WriteLine(language.Translate(text));
    }
}

//class Program
//{
//    static void Main()
//    {
//        ILanguage english = new English();

//        Subject mathInEnglish = new Math(english);
//        mathInEnglish.DisplayContent();
//    }
//}