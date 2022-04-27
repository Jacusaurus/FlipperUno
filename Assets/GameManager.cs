using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int current_player_id;
    public Character CurrentPlayer;
    public BaseCard currentCard;
    public Color current_color;
    public Type current_type;
    public int current_number;
    public bool clockwise;
    public float card_width;
    // public Transform initial_hand_position;


    public enum GameState
    {
        MENU,
        CONFIGURE,
        DEAL,
        PLAY,
        SCORE,
        OVER
    }

    public enum PlayState
    {
        DRAW,
        LAY,
        ACTION,
    }
    [Header("Card Type Stats")]
    public int Number = 700;
    public int DrawTwo = 75;
    public int Reverse = 75;
    public int Skip = 75;
    public int Wild = 37;
    public int WildDrawFour = 37;

    [Header("Card Color Stats")]
    public int Red = 25;
    public int Blue = 25;
    public int Green = 25;
    public int Yellow = 25;

    [Header("Game Config Settings")]
    public int numberOfPlayers;





    [Header("Game State")]
    public GameState gamestate;
    public PlayState playstate;
    public int rotation;//0 clockwise, 1 counterclockwise

    public List<Character> players = new List<Character>();
    public Stack<GameObject> pile = new Stack<GameObject>();
    
    public CardGenerator cardGenerator;
    private float timeTester;
    private float timeInterval = 10.0f;
    private PlayPileScript playpile;
    public Deck deck;




    public void SetupPlayers()
    {
        players.Add(gameObject.AddComponent<CharacterPlayer>());
        for (int i = numberOfPlayers - 1; i > 0; i--)
        {
            players.Add(gameObject.AddComponent<CharacterNPC>());
        }
    }

    

    public void ChooseFirstPlayer()
    {

    }

    public void configure()
    {
        cardGenerator.ConfigureGenerator(Number, DrawTwo, Reverse, Skip, Wild, WildDrawFour, Red, Blue, Green, Yellow);
    }

    //public void AddToHand(GameObject card, Character player)
    //{
    //    player.hand.Add(card);
    //    HorizontalLayoutGroup HandArea = GameObject.Find("PlayerHand").GetComponent<HorizontalLayoutGroup>();
    //    float width = HandArea.GetComponent<RectTransform>().rect.width;
    //    float middle = width / 2;
    //    float cardWidth = card.GetComponent<RectTransform>().rect.width;
        
    //}

    public void AddToHand(GameObject card, Character player)
    {
        GridLayoutGroup HandArea;
        GameObject HandObject;
        if (player == players[0])
        {
            HandObject = GameObject.Find("PlayerHand");
        }
        else if (player == players[1])
        {
            HandObject = GameObject.Find("EnemyHand1");
        }
        else if (player == players[2])
        {
            HandObject = GameObject.Find("EnemyHand2");
        }
        else
        {
            HandObject = GameObject.Find("EnemyHand3");
        }
        HandArea = HandObject.GetComponent<GridLayoutGroup>();
        player.hand.Add(card);
        //float width = HandObject.transform.GetChild(0).gameObject.GetComponent<CardFabtory>().rect.width;
        float width = HandArea.cellSize.x;
        card_width = width;
        // set the card size according to cell size
        DynamicResize resizer = HandObject.GetComponent<DynamicResize>();
        if (resizer.CheckCardAddition(card_width, HandArea.transform.childCount))
        {
            resizer.ResizeGridShrink(card_width, HandArea.transform.childCount);
        }
        card.transform.SetParent(HandArea.transform, false);
        
        
    }

    public void Deal()
    {
        Character thisPlayer;
        for (int i = 0; i < numberOfPlayers; i++)
        {
            thisPlayer = players[i];
            for (int j = 0; j < 7; j++)
            {
                GameObject NewCard = cardGenerator.CreateCard();
                AddToHand(NewCard, thisPlayer);
            }
            
        }
    }

    // TODO: Use this for drawing if we decide to go with a pile system
    //public void Draw()
    //{
    //    if (pile.Count > 0)
    //    {
    //        players[current_player].hand.Add(pile.Pop());
    //    }
    //}

    public void Draw()
    {
        players[current_player_id].hand.Add(cardGenerator.CreateCard());
    }

    public void AdvancePlayer()
    {
        if (clockwise)
        {
            current_player_id++;
            if (current_player_id >= numberOfPlayers)
            {
                current_player_id = 0;
            }
        }
        else
        {
            current_player_id--;
            if (current_player_id < 0)
            {
                current_player_id = numberOfPlayers - 1;
            }
        }
    }

    // iterate through cards in the specified player's hand and check if they're playable.  Should be performed at beginning of turn
    public void FindPlayable(int player_number)
    {
        if (players[player_number].hand.Count > 0)
        {
            for (int i = 0; i < players[player_number].hand.Count; i++)
            {
                CardFabtory ThisCard = players[player_number].hand[i].GetComponent<CardFabtory>();
                BaseCard ThisCardData = ThisCard.CardData;
                
                if (ThisCardData is NumberCard numberCard && (numberCard.Number == current_number || numberCard.color == current_color))
                {
                    ThisCard.playable = true;
                }
                else if (ThisCardData is DrawTwoCard drawTwoCard && current_type == Type.DRAWTWO)
                {
                    ThisCard.playable = true;
                }
                else if (ThisCardData is SkipCard skipCard && current_type == Type.SKIP)
                {
                    ThisCard.playable = true;
                }
                else if (ThisCardData is ReverseCard reverseCard && current_type == Type.REVERSE)
                {
                    ThisCard.playable = true;
                }
                else if (ThisCardData is WildCard wildCard)
                {
                    ThisCard.playable = true;
                }
                else if (ThisCardData is WildDrawFourCard wildDrawFourCard)
                {
                    ThisCard.playable = true;
                }
                else if (ThisCardData.color == current_color)
                {
                    ThisCard.playable = true;
                }
            }
        }
    }

    // change color, number, and type of the current card
    public void UpdateCardData(BaseCard PlacedCard)
    {
        if (PlacedCard.type == Type.NUMBER)
        {
            NumberCard numb = (NumberCard)PlacedCard;
            current_number = numb.Number;
        }
        else
        {
            current_number = -1;
        }
        current_color = PlacedCard.color;
        current_type = PlacedCard.type;
        currentCard = PlacedCard;
        playpile.ChangeCurrentGraphic(PlacedCard);
    }

    public void RemoveFromHand(int card_number, int player_number)
    {
        players[player_number].hand.RemoveAt(card_number);
    }

    //public void PlayCard(int card_number, int player_number)
    //{
    //    if (players[player_number].hand[card_number].GetComponent<CardFabtory>().playable)
    //    {
    //        players[player_number].hand[card_number].GetComponent<CardFabtory>().CardData.OnPlay();
    //        UpdateCardData(players[player_number].hand[card_number].GetComponent<CardFabtory>().CardData);
    //        players[player_number].hand.RemoveAt(card_number);
    //    }
    //}

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameController");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        gamestate = GameState.MENU;
        numberOfPlayers = 4;
        //gameObject.AddComponent<CardGenerator>();
        cardGenerator = GetComponent<CardGenerator>();
        playpile = GameObject.Find("PlayPile").GetComponent<PlayPileScript>();
        configure();
        started = false;
        playstate = PlayState.LAY;
    }

    public void EnemyTurn()
	{
        if (current_player_id == 1 || current_player_id == 2 || current_player_id == 3)
        {
            bool done = false;
            GameObject player = GameObject.Find("EnemyHand1");
            switch (current_player_id)
            {

                case 1:
                    player = GameObject.Find("EnemyHand1");
                    break;
                case 2:
                    player = GameObject.Find("EnemyHand2");
                    break;
                case 3:
                    player = GameObject.Find("EnemyHand3");
                    break;

            }
			//while (!done)
			//{
			if (timeTester > timeInterval)
			{

			}
			else
			{
                timeTester += Time.deltaTime;
			}
                foreach (Transform child in player.transform)
                {
                    done = child.GetComponent<CardScript>().IsPlayable();

                    if (done)
                    {
                        child.GetComponent<CardScript>().SetPlayCard();
                    }


                }
                deck.OnDeckClick();
                    //GameObject NewCard = cardGenerator.CreateCard();
                    //AddToHand(NewCard, players[current_player_id]);
                

            //}
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (started == false)
        {
            SetupPlayers();
            Deal();
            started = true;
        }
        EnemyTurn();
        
        //if (timeTester > timeInterval)
        //{
        //    GameObject newCard = cardGenerator.CreateCard();
        //    GameObject handResizer = GameObject.Find("PlayerHand");
        //    bool tooMuch = handResizer.GetComponent<DynamicResize>().CheckCardAddition(newCard, players[0].hand.Count);
        //    if (tooMuch)
        //    {
        //        Debug.Log("Limit exceeded.  Test failed, which is expected");
        //    }
        //    AddToHand(newCard, players[0]);
        //    timeTester = 0.0f;
        //} else
        //{
        //    timeTester += Time.deltaTime;
        //}
    }

    //public void NextPlayer()
    //{
    //    if (gclockwise == true)
    //    {
    //        if (gameManager.current_player_id < gameManager.players.Count - 1)
    //        {
    //            gameManager.current_player_id += 1;
    //        }
    //        else
    //        {
    //            gameManager.current_player_id = 0;
    //        }
    //    }
    //    else
    //    {
    //        if (gameManager.current_player_id == 0)
    //        {
    //            gameManager.current_player_id = gameManager.players.Count - 1;
    //        }
    //        else
    //        {
    //            gameManager.current_player_id -= 1;
    //        }
    //    }
    //}


}
public class GameObjectUtil
{
    public delegate void ChildHandler(GameObject child);

    /// <summary>
    /// Iterates all children of a game object
    /// </summary>
    /// <param name="gameObject">A root game object</param>
    /// <param name="childHandler">A function to execute on each child</param>
    /// <param name="recursive">Do it on children? (in depth)</param>
    public static void IterateChildren(GameObject gameObject, ChildHandler childHandler, bool recursive)
    {
        DoIterate(gameObject, childHandler, recursive);
    }

    /// <summary>
    /// NOTE: Recursive!!!
    /// </summary>
    /// <param name="gameObject">Game object to iterate</param>
    /// <param name="childHandler">A handler function on node</param>
    /// <param name="recursive">Do it on children?</param>
    private static void DoIterate(GameObject gameObject, ChildHandler childHandler, bool recursive)
    {
        foreach (Transform child in gameObject.transform)
        {
            childHandler(child.gameObject);
            if (recursive)
                DoIterate(child.gameObject, childHandler, true);
        }
    }
}
