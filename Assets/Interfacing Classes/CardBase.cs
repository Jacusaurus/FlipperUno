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

    public virtual void OnPlay()
    {
        // int current_color = GameManager.Instance.CurrentPlayer.Color;
        //Color current_color = color;
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


