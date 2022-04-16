using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public int Number = 700;
	public int DrawTwo = 75;
	public int Reverse = 75;
	public int Skip = 75;

	public int Wild = 37;
	public int WildDrawFour = 37;

	public int Red = 25;
	public int Blue = 25;
	public int Green = 25;
	public int Yellow = 25;

	public CardGenerator(int Number, int DrawTwo, int Reverse, int Skip, int Wild, int WildDrawFour, int Red, int Blue, int Green, int Yellow)
	{

		this.Number = Number;
		this.DrawTwo = DrawTwo;
		this.Reverse = Reverse;
		this.Skip = Skip;

		this.Wild = Wild;
		this.WildDrawFour = WildDrawFour;

		this.Red = Red;
		this.Blue = Blue;
		this.Green = Green;
		this.Yellow = Yellow;

	}

	public CardGenerator()
	{

	}

	class Range
	{
		public int lower;
		public int upper;

	}




	

    public BaseCard GetNewCard()
	{
		int typerand = Random.Range(1, Number + DrawTwo + Reverse + Skip + Wild + WildDrawFour + 1);
		int colorrand = Random.Range(1, Red + Blue + Green + Yellow + 1);
		int number = Random.Range(0, 10);

		Type type = GetType(typerand);
		Color color = GetColor(colorrand);

		BaseCard NewCard = CreateCard(color, number, type);
		return NewCard;
	}

	public BaseCard CreateCard(Color colorin, int numberin, Type typein)
	{
		BaseCard card;
		if (typein == Type.NUMBER)
		{
			card = new NumberCard(colorin, numberin);
		}
		else if (typein == Type.DRAWTWO)
		{
			card = new DrawTwoCard(colorin);
		}
		else if (typein == Type.SKIP)
		{
			card = new SkipCard(colorin);
		}
		else if (typein == Type.REVERSE)
		{
			card = new ReverseCard(colorin);
		}
		else if (typein == Type.WILD)
		{
			card = new WildCard();
		}
		else if (typein == Type.WILDDRAWFOUR)
		{
			card = new DrawFourCard();
		}
		else
		{
			card = new NumberCard(colorin, numberin);
		}
		return card;
	}

	private Type GetType(int rand)
	{
		Type type = Type.NUMBER;

		Range numberRange = new Range();
		Range drawTwoRange = new Range();
		Range reverseRange = new Range();
		Range skipRange = new Range();
		Range wildRange = new Range();
		Range wildDrawFourRange = new Range();

		int i = 0;
		numberRange.lower = 1;
		i += Number;
		numberRange.upper = i;

		drawTwoRange.lower = i + 1;
		i += DrawTwo;
		drawTwoRange.upper = i;

		reverseRange.lower = i + 1;
		i += Reverse;
		reverseRange.upper = i;

		skipRange.lower = i + 1;
		i += Skip;
		skipRange.upper = i;

		wildRange.lower = i + 1;
		i += Wild;
		wildRange.upper = i;

		wildDrawFourRange.lower = i + 1;
		i += WildDrawFour;
		wildDrawFourRange.upper = i;

		if (rand >= numberRange.lower && rand <= numberRange.upper)
		{
			type = Type.NUMBER;
		}
		if (rand >= drawTwoRange.lower && rand <= drawTwoRange.upper)
		{
			type = Type.DRAWTWO;
		}
		if (rand >= reverseRange.lower && rand <= reverseRange.upper)
		{
			type = Type.REVERSE;
		}
		if (rand >= skipRange.lower && rand <= skipRange.upper)
		{
			type = Type.SKIP;
		}
		if (rand >= wildRange.lower && rand <= wildRange.upper)
		{
			type = Type.WILD;
		}
		if (rand >= wildDrawFourRange.lower && rand <= wildDrawFourRange.upper)
		{
			type = Type.WILDDRAWFOUR;
		}
		return type;
	}


	private Color GetColor(int rand)
	{
		Color color = Color.RED;

		Range redRange = new Range();
		Range blueRange = new Range();
		Range greenRange = new Range();
		Range yellowRange = new Range();

		int i = 0;
		redRange.lower = 1;
		i += Red; ;
		redRange.upper = i;

		blueRange.lower = i + 1;
		i += Blue;
		blueRange.upper = i;

		greenRange.lower = i + 1;
		i += Green;
		greenRange.upper = i;

		yellowRange.lower = i + 1;
		i += Yellow;
		yellowRange.upper = i;



		if( rand >= redRange.lower && rand <= redRange.upper)
		{
			color = Color.RED;
		}
		if (rand >= blueRange.lower && rand <= blueRange.upper)
		{
			color = Color.BLUE;
		}
		if (rand >= greenRange.lower && rand <= greenRange.upper)
		{
			color = Color.GREEN;
		}
		if (rand >= yellowRange.lower && rand <= yellowRange.upper)
		{
			color = Color.YELLOW;
		}
		return color;
	}
}
