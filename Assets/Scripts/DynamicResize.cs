using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicResize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // check if card addition will go outside the GridLayout
    public bool CheckCardAddition(GameObject card, int numCards)
    {
        // get the card's size
        float cardSize = card.GetComponent<RectTransform>().rect.width;
        // get the card's position
        Vector2 cardPos = card.GetComponent<RectTransform>().anchoredPosition;
        // get the grid's size
        float gridSize = GetComponent<RectTransform>().rect.width;
        // get the grid's position
        Vector2 gridPos = GetComponent<RectTransform>().anchoredPosition;

        Debug.Log("Size of card: " + cardSize);
        Debug.Log("Size of grid: " + gridSize);

        // check if the card will go outside the grid
        if (cardSize * (numCards + 1) > gridSize)
        {
            Debug.Log("Width if not resized: " + (cardSize * (numCards + 1)));
            return true;
        }
        else
        {
            return false;
        }
    }
}
