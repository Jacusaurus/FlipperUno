using Unity;
public abstract class BaseCard : ICard
{
    public string Name { get; set; }
    public int Color { get; set; }
    public string Type { get; set; }
    public float Rarity { get; set; }
    public UnityEngine.Sprite CardSprite { get; set; }

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
        UnityEngine.Debug.Log("Played " + Name);
    }
}