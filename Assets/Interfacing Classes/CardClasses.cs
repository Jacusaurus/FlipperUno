public class NumberCard : BaseCard
{
    private int Number { get; set; }

    public NumberCard(int color, int number)
    {
        Number = number;
        Color = color;
        Type = "number";
    }

}

public class WildCard : BaseCard
{
    public WildCard()
    {
        Color = 0;
        Type = "wild";
    }
}

public class DrawTwoCard : BaseCard
{
    public DrawTwoCard(int color)
    {
        Color = color;
        Type = "draw_two";
    }
}

public class DrawFourCard : BaseCard
{
    public DrawFourCard()
    {
        Color = 0;
        Type = "draw_four";
    }
}

public class SkipCard : BaseCard
{
    public SkipCard(int color)
    {
        Color = color;
        Type = "skip";
    }
}

public class ReverseCard : BaseCard
{
    public ReverseCard(int color)
    {
        Color = color;
        Type = "reverse";
    }
}

public enum Color
{
    WILD,
    RED,
    BLUE,
    GREEN,
    YELLOW
}