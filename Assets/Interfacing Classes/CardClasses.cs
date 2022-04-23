public enum Color
{
    WILD,
    RED,
    BLUE,
    GREEN,
    YELLOW
}

public class NumberCard : BaseCard
{
    public int Number { get; set; }

    public NumberCard(Color colorin, int numberin)
    {
        Number = numberin;
        color = colorin;
        type = Type.NUMBER; ;
    }

}

public class DrawTwoCard : BaseCard
{
    public DrawTwoCard(Color colorin)
    {
        color = colorin;
        type = Type.DRAWTWO;
    }
}

public class ReverseCard : BaseCard
{
    public ReverseCard(Color colorin)
    {
        color = colorin;
        type = Type.REVERSE;
    }
}

public class SkipCard : BaseCard
{
    public SkipCard(Color colorin)
    {
        color = colorin;
        type = Type.SKIP;
    }
}

public class WildCard : BaseCard
{
    public WildCard()
    {
        color = Color.WILD;
        type = Type.WILD;
    }
}

public class WildDrawFourCard : BaseCard
{
    public WildDrawFourCard()
    {
        color = Color.WILD;
        type = Type.WILDDRAWFOUR;
    }
}
/*
public class ChallengeCard : BaseCard
{
    public ChallengeCard()
    {
        color = Color.WILD;
        type = Type.CHALLENGE;
    }
}

public class CommunismCard : BaseCard
{
    public CommunismCard()
    {
        color = Color.WILD;
        type = Type.COMMUNISM;
    }
}*/