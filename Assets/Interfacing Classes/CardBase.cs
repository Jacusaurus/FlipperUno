using Unity;
public abstract class BaseCard : ICard
{
    public int Color { get; set; }
    public string Type { get; set; }
    public float Rarity { get; set; }
    public UnityEngine.Sprite CardSprite { get; set; }

    public BaseCard CreateCard(int color, int number, string type)
    {
        BaseCard card;
        if (type == "number")
        {
            card = new NumberCard(color, number);
        } else if (type == "draw_two")
        {
            card = new DrawTwoCard(color);
        } else if (type == "skip")
        {
            card = new SkipCard(color);
        } else if (type == "reverse")
        {
            card = new ReverseCard(color);
        } else if (type == "wild")
        {
            card = new WildCard();
        } else if (type == "draw_four")
        {
            card = new DrawFourCard();
        } else
        {
            card = new NumberCard(color, number);
        }
        return card;
    }

    public virtual void OnPlay()
    {
        // int current_color = GameManager.Instance.CurrentPlayer.Color;
        int current_color = Color;
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

