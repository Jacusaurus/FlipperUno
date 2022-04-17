using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFabtory : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Sprite sprite;

    public bool playable;
    public BaseCard CardData;
    public List<Sprite> cardFaces;

    public void SetCard(BaseCard card)
    {
        
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
            sprite = cardFaces[number_offset + color_offset];

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
        }
        else if (card is WildCard wildCard)
        {
            sprite = cardFaces[52];
        }
        else if (card is WildDrawFourCard wildDrawFourCard)
        {
            sprite = cardFaces[53];
        }
        spriteRenderer.sprite = sprite;
        CardData = card;
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
