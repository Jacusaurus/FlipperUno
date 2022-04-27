using UnityEngine.UI;
using UnityEngine;
using Unity;

public enum Color
{
    WILD,
    RED,
    BLUE,
    GREEN,
    YELLOW
}

public class NumberCard : BaseCard
{
    public int Number { get; set; }

    public NumberCard(Color colorin, int numberin)
    {
       
        Number = numberin;
        color = colorin;
        type = Type.NUMBER;
        getSprite(colorin, numberin);
        
        
    }

    public void getSprite(Color color, int number)
	{
       
		switch (number)
		{
            case 0:
				switch (color)
				{
                    case Color.BLUE:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno0 Blue");
                        break;
                    case Color.GREEN:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno0 Green");
                        break;
                    case Color.RED:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno0 Red");
                        break;
                    case Color.YELLOW:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno0 Yellow");
                        break;
				}
                break;
            case 1:
                switch (color)
                {
                    case Color.BLUE:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno1 Blue");
                        break;
                    case Color.GREEN:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno1 Green");
                        break;
                    case Color.RED:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno1 Red");
                        break;
                    case Color.YELLOW:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno1 Yellow");
                        break;
                }
                break;
            case 2:
                switch (color)
                {
                    case Color.BLUE:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno2 Blue");
                        break;
                    case Color.GREEN:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno2 Green");
                        break;
                    case Color.RED:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno2 Red");
                        break;
                    case Color.YELLOW:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno2 Yellow");
                        break;
                }
                break;
            case 3:
                switch (color)
                {
                    case Color.BLUE:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno3 Blue");
                        break;
                    case Color.GREEN:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno3 Green");
                        break;
                    case Color.RED:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno3 Red");
                        break;
                    case Color.YELLOW:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno3 Yellow");
                        break;
                }
                break;
            case 4:
                switch (color)
                {
                    case Color.BLUE:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno4 Blue");
                        break;
                    case Color.GREEN:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno4 Green");
                        break;
                    case Color.RED:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno4 Red");
                        break;
                    case Color.YELLOW:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno4 Yellow");
                        break;
                }               
                break;
            case 5:
                switch (color)
                {
                    case Color.BLUE:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno5 Blue");
                        break;
                    case Color.GREEN:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno5 Green");
                        break;
                    case Color.RED:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno5 Red");
                        break;
                    case Color.YELLOW:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno5 Yellow");
                        break;
                }
                break;
            case 6:
                switch (color)
                {
                    case Color.BLUE:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno6 Blue");
                        break;
                    case Color.GREEN:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno6 Green");
                        break;
                    case Color.RED:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno6 Red");
                        break;
                    case Color.YELLOW:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno6 Yellow");
                        break;
                }
                break;
            case 7:
                switch (color)
                {
                    case Color.BLUE:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno7 Blue");
                        break;
                    case Color.GREEN:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno7 Green");
                        break;
                    case Color.RED:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno7 Red");
                        break;
                    case Color.YELLOW:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno7 Yellow");
                        break;
                }              
                break;
            case 8:
                switch (color)
                {
                    case Color.BLUE:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno8 Blue");
                        break;
                    case Color.GREEN:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno8 Green");
                        break;
                    case Color.RED:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno8 Red");
                        break;
                    case Color.YELLOW:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno8 Yellow");
                        break;
                }
                break;
            case 9:
                switch (color)
                {
                    case Color.BLUE:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno9 Blue");
                        break;
                    case Color.GREEN:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno9 Green");
                        break;
                    case Color.RED:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno9 Red");
                        break;
                    case Color.YELLOW:
                        sprite_image = Resources.Load<Sprite>("Sprites/Uno9 Yellow");
                        break;
                }
                break;
           



		}
        
	}

}

public class DrawTwoCard : BaseCard
{
    public DrawTwoCard(Color colorin)
    {
        color = colorin;
        type = Type.DRAWTWO;
        getsprite(colorin);
    }

    public void getsprite(Color color)
	{
        switch (color)
        {
            case Color.BLUE:
                sprite_image = Resources.Load<Sprite>("Sprites/Uno+2 Blue");
                break;
            case Color.GREEN:
                sprite_image = Resources.Load<Sprite>("Sprites/Uno+2 Green");
                break;
            case Color.RED:
                sprite_image = Resources.Load<Sprite>("Sprites/Uno+2 Red");
                break;
            case Color.YELLOW:
                sprite_image = Resources.Load<Sprite>("Sprites/Uno+2 Yellow");
                break;
        }
    }
}

public class ReverseCard : BaseCard
{
    public ReverseCard(Color colorin)
    {
        color = colorin;
        type = Type.REVERSE;
        getsprite(colorin);
    }

    public void getsprite(Color color)
	{
        switch (color)
        {
            case Color.BLUE:
                sprite_image = Resources.Load<Sprite>("Sprites/UnoReverse Blue");
                break;
            case Color.GREEN:
                sprite_image = Resources.Load<Sprite>("Sprites/UnoReverse Green");
                break;
            case Color.RED:
                sprite_image = Resources.Load<Sprite>("Sprites/UnoReverse Red");
                break;
            case Color.YELLOW:
                sprite_image = Resources.Load<Sprite>("Sprites/UnoReverse Yellow");
                break;
        }
    }

}

public class SkipCard : BaseCard
{
    public SkipCard(Color colorin)
    {
        color = colorin;
        type = Type.SKIP;
        getsprite(colorin);
    }

    public void getsprite(Color color)
	{
        switch (color)
        {
            case Color.BLUE:
                sprite_image = Resources.Load<Sprite>("Sprites/UnoSkip Blue");
                break;
            case Color.GREEN:
                sprite_image = Resources.Load<Sprite>("Sprites/UnoSkip Green");
                break;
            case Color.RED:
                sprite_image = Resources.Load<Sprite>("Sprites/UnoSkip Red");
                break;
            case Color.YELLOW:
                sprite_image = Resources.Load<Sprite>("Sprites/UnoSkip Yellow");
                break;
        }
    }
}

public class WildCard : BaseCard
{
    public WildCard()
    {
        color = Color.WILD;
        type = Type.WILD;
        getsprite();

    }

    public void getsprite()
	{
        sprite_image = Resources.Load<Sprite>("Sprites/UnoWild");
	}


}

public class WildDrawFourCard : BaseCard
{
    public WildDrawFourCard()
    {
        color = Color.WILD;
        type = Type.WILDDRAWFOUR;
        getSprite();
    }

    public void getSprite()
	{
        sprite_image = Resources.Load<Sprite>("Sprites/UnoWildDraw4");
    }
}
/*
public class ChallengeCard : BaseCard
{
    public ChallengeCard()
    {
        color = Color.WILD;
        type = Type.CHALLENGE;
    }
}

public class CommunismCard : BaseCard
{
    public CommunismCard()
    {
        color = Color.WILD;
        type = Type.COMMUNISM;
    }
}

public class SwapCard : BaseCard
{
    public SwapCard()
    {
        color = colorin;
        type = Type.SWAP;
    }
}

public class RotateCard : BaseCard
{
    public RotateCard()
    {
        color = colorin;
        type = Type.ROTATE;
    }
}
 
 */