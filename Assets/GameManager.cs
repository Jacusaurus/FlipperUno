using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int current_player_id;
    public Character CurrentPlayer;
    public Color current_color;
    public Type current_type;
    public int current_number;
    public bool clockwise;
    // public Transform initial_hand_position;

    private bool started;

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
    public int rotaion;//0 clockwise, 1 counterclockwise

    public List<Character> players = new List<Character>();
    public Stack<GameObject> pile = new Stack<GameObject>();
    public CardGenerator cardGenerator;


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
        cardGenerator = new CardGenerator(Number, DrawTwo, Reverse, Skip, Wild, WildDrawFour, Red, Blue, Green, Yellow);
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
        player.hand.Add(card);
        GridLayoutGroup HandArea = GameObject.Find("HandTemp").GetComponent<GridLayoutGroup>();
        card.transform.SetParent(HandArea.transform, false);

    }

    public void Deal()
    {
        for (int i = 0; i < numberOfPlayers; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                GameObject NewCard = cardGenerator.CreateCard();
                players[i].hand.Add(NewCard);
                Character thisPlayer = players[i];
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
        current_player_id++;
        if (current_player_id >= numberOfPlayers)
        {
            current_player_id = 0;
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
        if (PlacedCard is NumberCard numberCard)
        {
            current_number = numberCard.Number;
        }
        else
        {
            current_number = -1;
        }
        current_color = PlacedCard.color;
        current_type = PlacedCard.type;
    }

    public void RemoveFromHand(int card_number, int player_number)
    {
        players[player_number].hand.RemoveAt(card_number);
    }

    public void PlayCard(int card_number, int player_number)
    {
        if (players[player_number].hand[card_number].GetComponent<CardFabtory>().playable)
        {
            players[player_number].hand[card_number].GetComponent<CardFabtory>().CardData.OnPlay();
            UpdateCardData(players[player_number].hand[card_number].GetComponent<CardFabtory>().CardData);
            players[player_number].hand.RemoveAt(card_number);
        }
    }

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
        cardGenerator = new CardGenerator(Number, DrawTwo, Reverse, Skip, Wild, WildDrawFour, Red, Blue, Green, Yellow); 
        started = false;
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
    }
}
