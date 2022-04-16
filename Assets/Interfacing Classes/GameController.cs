using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
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
    public Stack<BaseCard> pile = new Stack<BaseCard>();
    public CardGenerator cardGenerator;


    // Start is called before the first frame update
    void Start()
    {
        gamestate = GameState.MENU;
        numberOfPlayers = 4;
        
        
    }

    // Update is called once per frame
    void Update()
    {

    }

	public void SetupPLayers() 
    {
        players.Add(new CharacterPlayer());
        for (int i = numberOfPlayers - 1; i > 0; i--)
        {
            players.Add(new CharacterNPC());
        }
    }
	

	public void ChooseFirstPlayer()
	{

	}

    public void configure()
	{
        cardGenerator = new CardGenerator(Number, DrawTwo, Reverse, Skip, Wild, WildDrawFour, Red, Blue, Green, Yellow);
    }




   
    

    
}
