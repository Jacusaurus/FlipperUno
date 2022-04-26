using Unity;
using UnityEngine;
using UnityEngine.UI;
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

    public Sprite sprite_image { get; set; }
    public Color color { get; set; }
    public Type type { get; set; }
    public UnityEngine.Sprite CardSprite { get; set; }
    public int GameOver = 0;

    // TODO: ***IMPORTANT*** - Add method to GameManager that plays card, like below, and also override method below in subclasses
    public virtual void OnPlay()
    {
        

    }

}