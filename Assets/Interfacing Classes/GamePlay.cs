using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    CLOCKWISE,
    COUNTERCLOCKWISE
}

public class GamePlay : MonoBehaviour
{
    //Subject to change
    public Color CurrentColor;
    public Type CurrentType;
    public int CurrentPlayer = 0; //0 is user 1-X are NPCs
    public Direction PlayDirection = Direction.CLOCKWISE;
    public int TotalPlayers = 4;
    public int GameOver = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Play()
    {
        while (GameOver == 0) {

            //CurrentColor = Color.color;
            //CurrentType = Type.type;

            if (CurrentType == Type.DRAWTWO)
            {
                Draw2Function();
            }
            else if (CurrentType == Type.REVERSE)
            {
                ReverseFunction();
            }
            else if (CurrentType == Type.SKIP)
            {
                SkipFunction();
            }
            else if (CurrentType == Type.WILD)
            {
                WildFunction();
            }
            else if (CurrentType == Type.WILDDRAWFOUR)
            {
                WildFunction();
                Draw4Function();
            }
            /*
            else if (CurrentType == Type.NUMBER)
            {
                if (CardNum == 0)
                {
                   RotateFunction();
                }
                else if (CardNum == 7)
                {
                    SwapFunction();
                }
            }
            else if (CurrentType == Type.CHALLENGE)
            {
                ChallengeFunction();
            }
            else if (CurrentType == Type.COMMUNISM)
            {
                CommunismFunction();
            }
             */

            //Continue to next player
            if (PlayDirection == Direction.CLOCKWISE)
            {
                if (CurrentPlayer < TotalPlayers - 1)
                {
                    CurrentPlayer += 1;
                }
                else
                {
                    CurrentPlayer = 0;
                }
            }
            else
            {
                if (CurrentPlayer == 0)
                {
                    CurrentPlayer = TotalPlayers - 1;
                }
                else
                {
                    CurrentPlayer -= 1;
                }
            }

            //Check for win
            /*
            if (CurrentPlayerHand.length == 0)
            {
                GameOver = 1; 
                Winner = CurrentPlayer
            }
             */

        }

        //Winner is *WINNER*
        //Send back to menu

    }

    public void Draw()
    {
        //Draw card
        //Add to hand
        //hand.Add();
    }

    public void NullFunction()
    {
        //Move on to next player
        //Next()
    }

    public void Draw2Function()
    {
        //Identify next player based on rotation of play
        //playerX
        //Force that player to pick up two cards
        //playerX.draw x2
        //Once cards picked up, skip that player
        //next player +=2
    }

    public void ReverseFunction()
    {
        if (PlayDirection == Direction.COUNTERCLOCKWISE)
        {
            PlayDirection = Direction.CLOCKWISE;
        }
        else
        {
            PlayDirection = Direction.COUNTERCLOCKWISE;
        }
        //Change rotation of play
        //Move on to next player
        //next player += 1
    }

    public void SkipFunction()
    {
        //Skip next player
        //next player +=2
    }

    public void WildFunction()
    {
        //Bring up UI to allow player to pick a color
        //Move on to next player
        //next player +=1
    }

    public void Draw4Function()
    {
        //Identify next player based on rotation of play
        //playerX
        //Force that player to pick up four cards
        //playerX.draw x4
        //Once cards picked up, skip that player
        //next player +=2
    }

    public void ChallengeFunction()
    {
        //Bring up UI to allow player to pick another player
        //playerX
        //Bring up UI for the challenge
        //Mark loser and give out punishment
        //Move on to next player from the one that played the card
        //next player +=1
    }

    public void CommunismFunction()
    {
        //Collect all cards at the table
        //Re-deal clockwise from left of the card player
        //Move on to next player
        //next player +=1
    }

    public void SwapFunction()
    {
        //Bring up UI to allow player to pick another player
        //playerX
        //Switch the hands
        //Move on to next player
        //next player +=1
    }

    public void RotateFunction()
    {
        //Rotate all hand clockwise
        //Move on to next player
        //next player +=1
    }

}