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

	class Range
	{
		public int lower;
		public int upper;

	}

	public int NumberCard;
	public int DrawTwo;
	public int Reverse;
	public int Skip;

	public int Wild;
	public int WildDrawFour; 

	public int Red;
	public int Blue;
	public int Green;
	public int Yellow;


	public enum Color
	{
		WILD,
		RED,
		BLUE,
		GREEN,
		YELLOW
	}

	


    public BaseCard GetNewCard()
	{
		int type = Random.Range(1, NumberCard + DrawTwo + Reverse + Skip + Wild + WildDrawFour);
		int color = Random.Range(1, Red + Blue + Green + Yellow);
		int number = Random.Range(0, 10);

		BaseCard NewCard = new BaseCard();





		return NewCard;
	}

	int string GetType()
	{

	}


	private Color GetColor(int rand)
	{
		Color color;

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
