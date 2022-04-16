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
        OVER
    }

    public int numberOfPlayers { get; set; }

    public int rotaion;//0 clockwise, 1 counterclockwise
    public GameState gamestate;
    List<Character> players = new List<Character>();
    Stack<BaseCard> pile = new Stack<BaseCard>();

    // Start is called before the first frame update
    void Start()
    {
        gamestate = GameState.MENU;

        
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


   
    

    
}
