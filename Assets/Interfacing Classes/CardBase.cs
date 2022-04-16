using Unity;


public enum Type
{
    NUMBER,
    DRAWTWO,
    REVERSE,
    SKIP,
    WILD,
    WILDDRAWFOUR
}
public abstract class BaseCard : ICard
{



    public Color color { get; set; }
    public Type type { get; set; }
    public UnityEngine.Sprite CardSprite { get; set; }

    public BaseCard CreateCard(Color colorin, int numberin, Type typein)
    {
        BaseCard card;
        if (typein == Type.NUMBER)
        {
            card = new NumberCard(colorin, numberin);
        } else if (typein == Type.DRAWTWO)
        {
            card = new DrawTwoCard(colorin);
        } else if (typein == Type.SKIP)
        {
            card = new SkipCard(colorin);
        } else if (typein == Type.REVERSE)
        {
            card = new ReverseCard(colorin);
        } else if (typein == Type.WILD)
        {
            card = new WildCard();
        } else if (typein == Type.WILDDRAWFOUR)
        {
            card = new DrawFourCard();
        } else
        {
            card = new NumberCard(colorin, numberin);
        }
        return card;
    }

    public virtual void OnPlay()
    {
        // int current_color = GameManager.Instance.CurrentPlayer.Color;
        Color current_color = color;
        //if (current_color == Color)
        //{
        //    GameManager.Instance.CurrentPlayer.AddCard(this);
        //}
        //else
        //{
        //    GameManager.Instance.CurrentPlayer.AddCard(this);
        //    GameManager.Instance.CurrentPlayer.AddCard(this);
        //}
    }
}


