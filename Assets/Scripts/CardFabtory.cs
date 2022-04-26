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
    public int color_offset = 0;

    public void SetCard(BaseCard card)
    {
        Sprite sprite = cardFaces[0];
        if (card.type == Type.NUMBER)
        {
            NumberCard numbercard = (NumberCard)card;
            int number_offset = numbercard.Number * 4;
            color_offset = 0;
            switch (numbercard.color)
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

        else if (card.type  == Type.DRAWTWO)
        {
            int color_offset = 0;
            switch (card.color)
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
        }

        else if (card.type == Type.SKIP)
        {
            int color_offset = 0;
            switch (card.color)
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
        }

        else if (card.type == Type.REVERSE)
        {
            int color_offset = 0;
            switch (card.color)
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
        }

        else if (card is WildCard wildCard)
        {
            sprite = cardFaces[52];
        }

        else if (card is WildDrawFourCard wildDrawFourCard)
        {
            sprite = cardFaces[53];
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
