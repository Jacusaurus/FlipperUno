using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardFabtory : MonoBehaviour
{
    private Image sprite_image;

    public bool playable;
    public BaseCard CardData;
    public List<Sprite> cardFaces;
    
    public void SetCard(BaseCard card)
    {
        Debug.Log("SetCard" + card.type);
        Sprite sprite = cardFaces[0];
        if (card is NumberCard numberCard)
        {
            int number_offset = numberCard.Number * 4;
            int color_offset = 0;
            switch (numberCard.color)
            {
                case Color.BLUE:
                    color_offset = 0;
                    break;
                case Color.GREEN:
                    color_offset = 1;
                    break;
                case Color.RED:
                    color_offset = 2;
                    break;
                case Color.YELLOW:
                    color_offset = 3;
                    break;
                default:
                    break;
            }
        }

        else if (card is DrawTwoCard drawTwoCard)
        {
            int color_offset = 0;
            switch (drawTwoCard.color)
            {
                case Color.BLUE:
                    color_offset = 0;
                    break;
                case Color.GREEN:
                    color_offset = 1;
                    break;
                case Color.RED:
                    color_offset = 2;
                    break;
                case Color.YELLOW:
                    color_offset = 3;
                    break;
                default:
                    break;
            }
            sprite = cardFaces[color_offset + 48];
            Debug.Log("DrawTwoCard" + (color_offset + 48));
        }

        else if (card is SkipCard skipCard)
        {
            int color_offset = 0;
            switch (skipCard.color)
            {
                case Color.BLUE:
                    color_offset = 0;
                    break;
                case Color.GREEN:
                    color_offset = 1;
                    break;
                case Color.RED:
                    color_offset = 2;
                    break;
                case Color.YELLOW:
                    color_offset = 3;
                    break;
                default:
                    break;
            }
            sprite = cardFaces[color_offset + 44];
            Debug.Log("SkipCard" + (color_offset + 44));
        }

        else if (card is ReverseCard reverseCard)
        {
            int color_offset = 0;
            switch (reverseCard.color)
            {
                case Color.BLUE:
                    color_offset = 0;
                    break;
                case Color.GREEN:
                    color_offset = 1;
                    break;
                case Color.RED:
                    color_offset = 2;
                    break;
                case Color.YELLOW:
                    color_offset = 3;
                    break;
                default:
                    break;
            }
            sprite = cardFaces[color_offset + 40];
            Debug.Log("ReverseCard" + (color_offset + 40));
        }

        else if (card is WildCard wildCard)
        {
            sprite = cardFaces[52];
            Debug.Log("WildCard" + 52);
        }

        else if (card is WildDrawFourCard wildDrawFourCard)
        {
            sprite = cardFaces[53];
            Debug.Log("WildDrawFourCard" + 53);
        }
        /*
         else if (card is ChallengeCard challengeCard
        {
            sprite = cardFaces[54];
        }

        else if (card is CommunismCard communismCard)
        {
            sprite = cardFaces[55];
        }
         */
		 
        CardData = card;
        sprite_image.sprite = sprite;
        sprite_image.enabled = true;
    }

    private void Awake()
    {
        sprite_image = GetComponent<Image>();
        sprite_image.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
