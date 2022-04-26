using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    //public CardFabtory cardFabtory;

	public void ChangeCurrentGraphic(BaseCard incomingCard)
	{
        this.GetComponent<Image>().sprite = incomingCard.sprite_image;
	}

}
