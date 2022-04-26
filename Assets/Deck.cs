using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameManager gameManager;
    public CardGenerator cardGenerator;


    public void OnDeckClick()
	{
        if (gameManager.current_player_id == 0)
        {
            gameManager.AddToHand(cardGenerator.CreateCard(), gameManager.players[0]);
        }
	}
}
