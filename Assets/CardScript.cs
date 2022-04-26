using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public GameManager gameManager;
    public CardFabtory cardFabtory;

	public void SetGameManager(GameManager gameManager) 
    {
        this.gameManager = gameManager;
	}

	public void SetPlayCard() 
    {
        if (gameManager.current_player_id == 0 && gameManager.playstate == GameManager.PlayState.LAY && IsPlayable())
        {
            gameManager.UpdateCardData(cardFabtory.CardData);

        }
		
    }

    public bool IsPlayable()
    {
        if (gameManager.currentCard.color == cardFabtory.CardData.color) 
        {
            return true;
        }
        if (gameManager.currentCard.type == Type.NUMBER && cardFabtory.CardData.type == Type.NUMBER) 
        {
            NumberCard gameNumberCard = (NumberCard)gameManager.currentCard;
            NumberCard fabNumberCard = (NumberCard)cardFabtory.CardData;
            if(gameNumberCard.Number == fabNumberCard.Number) 
            {
                return true;
            }
        }
        if(cardFabtory.CardData.type == Type.WILD) 
        {
            return true;
        }

        return false;

    }
}
