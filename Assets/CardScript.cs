using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    
}

    // Update is called once per frame
    void Update()
    {
        
    }
    //public int player_id = 0;
    public GameManager gameManager;
    //public CardFabtory cardFabtory;
    private Image sprite_image;

    public bool playable;
    public BaseCard CardData;
    public List<Sprite> cardFaces;
    public int color_offset = 0;


    public void SetGameManager(GameManager gameManager) 
    {
        this.gameManager = gameManager;
	}

	public void SetPlayCard() 
    {
        int playerid = GetComponentInParent<PlayerScript>().player_id;
        if (gameManager.current_player_id == playerid && gameManager.playstate == GameManager.PlayState.LAY && IsPlayable() )
        {
            gameManager.UpdateCardData(CardData);
            if(CardData.type == Type.NUMBER)
			{
                gameManager.AdvancePlayer();
			}
            if(CardData.type == Type.DRAWTWO)
			{
                Draw2Function();
			}
            if (CardData.type == Type.REVERSE)
            {
                ReverseFunction();
            }
            if (CardData.type == Type.SKIP)
            {
                SkipFunction();
            }
            if (CardData.type == Type.WILD)
            {
                WildFunction();
            }
            if (CardData.type == Type.WILDDRAWFOUR)
            {
                Draw4Function();
            }
            Destroy(gameObject);



        }
		
    }

    public bool IsPlayable()
    {
        if (CardData.type == Type.WILD || CardData.type == Type.WILDDRAWFOUR)
        {
            return true;
        }
        else {
            if (gameManager.currentCard.color == CardData.color)
            {
                return true;
            }
            else { 
                if (gameManager.currentCard.type == Type.NUMBER && CardData.type == Type.NUMBER)
                {
                    NumberCard gameNumberCard = (NumberCard)gameManager.currentCard;
                    NumberCard fabNumberCard = (NumberCard)CardData;
                    if (gameNumberCard.Number == fabNumberCard.Number)
                    {
                        return true;
                    }
                }
            }
        }

        return false;

    }

    public void Draw2Function()
    {
        int next;
        if (gameManager.clockwise == true)
        {
            if (gameManager.current_player_id < gameManager.players.Count - 1)
            {
                next = gameManager.current_player_id + 1;
            }
            else
            {
                next = 0;
            }
        }
        else
        {
            if (gameManager.current_player_id == 0)
            {
                next = gameManager.players.Count - 1;
            }
            else
            {
                next = gameManager.current_player_id + 1;
            }
        }

        
        GameObject NewCard = gameManager.cardGenerator.CreateCard();
        gameManager.AddToHand(NewCard, gameManager.players[next]);
        NewCard = gameManager.cardGenerator.CreateCard();
        gameManager.AddToHand(NewCard, gameManager.players[next]);
        gameManager.AdvancePlayer();
        gameManager.AdvancePlayer();
    }

    public void ReverseFunction()
    {
        if (gameManager.clockwise == false)
        {
            gameManager.clockwise = true;
        }
        else
        {
            gameManager.clockwise = false;
        }
        gameManager.AdvancePlayer();
    }

    public void SkipFunction()
    {
        gameManager.AdvancePlayer();
        gameManager.AdvancePlayer();
    }

    public void WildFunction()
    {
        //int i = 0;
        int reds = 0;
        int blues = 0;
        int greens = 0;
        int yellows = 0;
        int rand = 0;
        GameObject gameObject = GameObject.Find("PlayerHand");
        
        //foreach (Transform child in gameObject.transform)
        //{
        //    if ( == Color.RED)
        //    {
        //        reds += 1;
        //    }
        //    else if (gamenumberCard.color == BLUE)
        //    {
        //        blues += 1;
        //    }
        //    else if (numberCard.color == GREEN)
        //    {
        //        greens += 1;
        //    }
        //    else if (numberCard.color == YELLOW)
        //    {
        //        yellows += 1;
        //    }

        //    i += 1;
        //}

        if (reds > blues && reds > greens && reds > yellows)
        {
            gameManager.current_color = Color.RED;
        }
        else if (blues > reds && blues > greens && blues > yellows)
        {
            gameManager.current_color = Color.BLUE;
        }
        else if (greens > reds && greens > blues && greens > yellows)
        {
            gameManager.current_color = Color.GREEN;
        }
        else if (yellows > reds && yellows > blues && yellows > greens)
        {
            gameManager.current_color = Color.YELLOW;
        }
        else if (reds == blues && reds > greens && reds > yellows)
        {
            rand = Random.Range(1, 3);
            if (rand == 1)
            {
                gameManager.current_color = Color.RED;
            }
            else
            {
                gameManager.current_color = Color.BLUE;
            }
        }
        else if (reds == greens && reds > blues && reds > yellows)
        {
            rand = Random.Range(1, 3);
            if (rand == 1)
            {
                gameManager.current_color = Color.RED;
            }
            else
            {
                gameManager.current_color = Color.GREEN;
            }
        }
        else if (reds == yellows && reds > blues && reds > greens)
        {
            rand = Random.Range(1, 3);
            if (rand == 1)
            {
                gameManager.current_color = Color.RED;
            }
            else
            {
                gameManager.current_color = Color.YELLOW;
            }
        }
        else if (reds == blues && reds == greens && blues == greens && reds > yellows)
        {
            rand = Random.Range(1, 4);
            if (rand == 1)
            {
                gameManager.current_color = Color.RED;
            }
            else if (rand == 2)
            {
                gameManager.current_color = Color.BLUE;
            }
            else
            {
                gameManager.current_color = Color.GREEN;
            }
        }
        else if ( reds == blues && reds == yellows && blues == yellows && reds > greens)
        {
            rand = Random.Range(1, 4);
            if (rand == 1)
            {
                gameManager.current_color = Color.RED;
            }
            else if (rand == 2)
            {
                gameManager.current_color = Color.BLUE;
            }
            else
            {
                gameManager.current_color = Color.YELLOW;
            }
        }
        else if (reds == greens && reds == yellows &&  greens == yellows && reds > blues)
        {
            rand = Random.Range(1, 4);
            if (rand == 1)
            {
                gameManager.current_color = Color.RED;
            }
            else if (rand == 2)
            {
                gameManager.current_color = Color.YELLOW;
            }
            else
            {
                gameManager.current_color = Color.GREEN;
            }
        }
        else if (reds == blues && reds ==  greens && reds == yellows && blues == greens && blues == yellows && greens == yellows)
        {
            rand = Random.Range(1, 5);
            if (rand == 1)
            {
                gameManager.current_color = Color.RED;
            }
            else if (rand == 2)
            {
                gameManager.current_color = Color.BLUE;
            }
            else if (rand == 3)
            {
                gameManager.current_color = Color.GREEN;
            }
            else
            {
                gameManager.current_color = Color.YELLOW;
            }
        }
        else if (blues == greens && blues > reds && blues > yellows)
        {
            rand = Random.Range(1, 3);
            if (rand == 1)
            {
                gameManager.current_color = Color.BLUE;
            }
            else
            {
                gameManager.current_color = Color.GREEN;
            }
        }
        else if (blues == yellows && blues > reds && blues > greens)
        {
            rand = Random.Range(1, 3);
            if (rand == 1)
            {
                gameManager.current_color = Color.BLUE;
            }
            else
            {
                gameManager.current_color = Color.YELLOW;
            }
        }
        else if (blues == greens &&  blues == yellows && greens == yellows && blues > reds)
        {
            rand = Random.Range(1, 4);
            if (rand == 1)
            {
                gameManager.current_color = Color.BLUE;
            }
            else if (rand == 2)
            {
                gameManager.current_color = Color.GREEN;
            }
            else
            {
                gameManager.current_color = Color.YELLOW;
            }
        }
        else if (greens == yellows && greens > blues && greens > reds)
        {
            rand = Random.Range(1, 3);
            if (rand == 1)
            {
                gameManager.current_color = Color.YELLOW;
            }
            else
            {
                gameManager.current_color = Color.GREEN;
            }
        }
        gameManager.AdvancePlayer();

    }

    public void Draw4Function()
    {
        int next;
        if (gameManager.clockwise == true)
        {
            if (gameManager.current_player_id < gameManager.players.Count - 1)
            {
                next = gameManager.current_player_id + 1;
            }
            else
            {
                next = 0;
            }
        }
        else
        {
            if (gameManager.current_player_id == 0)
            {
                next = gameManager.players.Count - 1;
            }
            else
            {
                next = gameManager.current_player_id + 1;
            }
        }
        GameObject NewCard = gameManager.cardGenerator.CreateCard();
        gameManager.AddToHand(NewCard, gameManager.players[next]);
        NewCard = gameManager.cardGenerator.CreateCard();
        gameManager.AddToHand(NewCard, gameManager.players[next]);
        NewCard = gameManager.cardGenerator.CreateCard();
        gameManager.AddToHand(NewCard, gameManager.players[next]);
        NewCard = gameManager.cardGenerator.CreateCard();
        gameManager.AddToHand(NewCard, gameManager.players[next]);
        gameManager.AdvancePlayer();
        gameManager.AdvancePlayer();
    }
}
