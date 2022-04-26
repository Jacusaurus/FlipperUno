using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPileScript : MonoBehaviour
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

	public void ChangeCurrentGraphic(BaseCard incomingCard)
	{
        cardFabtory.SetCard(gameManager.currentCard);
	}

}
