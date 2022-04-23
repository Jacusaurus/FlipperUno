using Unity;

public enum Type
{
    NUMBER,
    DRAWTWO,
    REVERSE,
    SKIP,
    WILD,
    WILDDRAWFOUR//,
    //CHALLENGE,
    //COMMUNISM
}
public abstract class BaseCard : ICard
{

    public Color color { get; set; }
    public Type type { get; set; }
    public UnityEngine.Sprite CardSprite { get; set; }

    // TODO: ***IMPORTANT*** - Add method to GameManager that plays card, like below, and also override method below in subclasses
    public virtual void OnPlay()
    {
        //if (current_color == Color)
        //{
        //    GameManager.Instance.CurrentPlayer.AddCard(this); or GameManager.Instance.PlayCard()
        //}
        //else
        //{
        //    GameManager.Instance.CurrentPlayer.AddCard(this); or GameManager.Instance.PlayCard()
        //}
    }
}


