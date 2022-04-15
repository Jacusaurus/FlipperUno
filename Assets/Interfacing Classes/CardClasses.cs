public class NumberCard : BaseCard
{
    private int Number { get; set; }

    public NumberCard(int color, int number)
    {
        Number = number;
        Color = color;
        Type = "number";
        Rarity = 5.0f;
    }
}

public class WildCard : BaseCard
{
    public WildCard()
    {
        Color = 0;
        Type = "wild";
        Rarity = 1.0f;
    }
}

public class DrawTwoCard : BaseCard
{
    public DrawTwoCard(int color)
    {
        Color = color;
        Type = "draw_two";
        Rarity = 2.0f;
    }
}

public class DrawFourCard : WildCard
{
    public DrawFourCard() : base()
    {
        Type = "draw_four";
        Rarity = 3.0f;
    }
}