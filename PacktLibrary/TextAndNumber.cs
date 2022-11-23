public class TextAndNumber
{
    public string? Text;
    public int Number;
}
public class Processor
{
    public TextAndNumber GetTheData()

    {
      return new TextAndNumber 
      {
        Text = "What's the meaning of life",
        Number =42
      };
    }
}