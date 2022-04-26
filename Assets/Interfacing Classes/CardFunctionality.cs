using System;

public class CardFunctionality
{

    public void NextPlayer()
    {
        if (clockwise == true)
        {
            if (current_player_id < players.length - 1)
            {
                current_player_id += 1;
            }
            else
            {
                current_player_id = 0;
            }
        }
        else
        {
            if (current_player_id == 0)
            {
                current_player_id = players.length - 1;
            }
            else
            {
                current_player_id -= 1;
            }
        }
    }

    public void Draw2Function()
    {
        int next;
        if (clockwise == true)
        {
            if (current_player_id < players.length - 1)
            {
                next = current_player_id + 1;
            }
            else
            {
                next = 0;
            }
        }
        else
        {
            if (current_player_id == 0)
            {
                next = players.length - 1;
            }
            else
            {
                next = current_player_id + 1;
            }
        }
        players[next].hand.Add(cardGenerator.CreateCard());
        players[next].hand.Add(cardGenerator.CreateCard());
        NextPlayer();
    }

    public void ReverseFunction()
    {
        if (clockwise == false)
        {
            clockwise = true;
        }
        else
        {
            clockwise = false;
        }
    }

    public void SkipFunction()
    {
        NextPlayer();
    }

    public void WildFunction()
    {
        int reds = 0;
        int blues = 0;
        int greens = 0;
        int yellows = 0;
        int rand = 0;
        Random rnd = new Random();
        while (i < players.length())
        {
            if (numberCard.color == RED)
            {
                reds += 1;
            }
            else if (numberCard.color == BLUE)
            {
                blues += 1;
            }
            else if (numberCard.color == GREEN)
            {
                greens += 1;
            }
            else if (numberCard.color == YELLOW)
            {
                yellows += 1;
            }

            i += 1;
        }

        if (reds > blues && reds > greens && reds > yellows)
        {
            current_color = RED;
        }
        else if (blues > reds && blues > greens && blues > yellows)
        {
            current_color = BLUE;
        }
        else if (greens > reds && greens > blues && greens > yellows)
        {
            current_color = GREEN;
        }
        else if (yellows > reds && yellows > blues && yellows > greens)
        {
            current_color = YELLOW;
        }
        else if (reds == blues && reds > greens && reds > yellows)
        {
            rand = rnd.Next(1, 3);
            if (rand == 1)
            {
                current_color = RED;
            }
            else
            {
                current_color = BLUE;
            }
        }
        else if (reds == greens && reds > blues && reds > yellows)
        {
            rand = rnd.Next(1, 3);
            if (rand == 1)
            {
                current_color = RED;
            }
            else
            {
                current_color = GREEN;
            }
        }
        else if (reds == yellows && reds > blues && reds > greens)
        {
            rand = rnd.Next(1, 3);
            if (rand == 1)
            {
                current_color = RED;
            }
            else
            {
                current_color = YELLOW;
            }
        }
        else if (reds == blues == greens && reds > yellows)
        {
            rand = rnd.Next(1, 4);
            if (rand == 1)
            {
                current_color = RED;
            }
            else if (rand == 2)
            {
                current_color = BLUE;
            }
            else
            {
                current_color = GREEN;
            }
        }
        else if (reds == blues == yellows && reds > greens)
        {
            rand = rnd.Next(1, 4);
            if (rand == 1)
            {
                current_color = RED;
            }
            else if (rand == 2)
            {
                current_color = BLUE;
            }
            else
            {
                current_color = YELLOW;
            }
        }
        else if (reds == greens == yellows && reds > blues)
        {
            rand = rnd.Next(1, 4);
            if (rand == 1)
            {
                current_color = RED;
            }
            else if (rand == 2)
            {
                current_color = YELLOW;
            }
            else
            {
                current_color = GREEN;
            }
        }
        else if (reds == blues == greens == yellows)
        {
            rand = rnd.Next(1, 5);
            if (rand == 1)
            {
                current_color = RED;
            }
            else if (rand == 2)
            {
                current_color = BLUE;
            }
            else if (rand == 3)
            {
                current_color = GREEN;
            }
            else
            {
                current_color = YELLOW;
            }
        }
        else if (blues == greens && blues > reds && blues > yellows)
        {
            rand = rnd.Next(1, 3);
            if (rand == 1)
            {
                current_color = BLUE;
            }
            else
            {
                current_color = GREEN;
            }
        }
        else if (blues == yellows && blues > reds && blues > greens)
        {
            rand = rnd.Next(1, 3);
            if (rand == 1)
            {
                current_color = BLUE;
            }
            else
            {
                current_color = YELLOW;
            }
        }
        else if (blues == greens == yellows && blues > reds)
        {
            rand = rnd.Next(1, 4);
            if (rand == 1)
            {
                current_color = BLUE;
            }
            else if (rand == 2)
            {
                current_color = GREEN;
            }
            else
            {
                current_color = YELLOW;
            }
        }
        else if (greens == yellows && greens > blues && greens > reds)
        {
            rand = rnd.Next(1, 3);
            if (rand == 1)
            {
                current_color = YELLOW;
            }
            else
            {
                current_color = GREEN;
            }
        }

    }

    public void Draw4Function()
    {
        int next;
        if (PlayDirection == Direction.CLOCKWISE)
        {
            if (current_player_id < TotalPlayers - 1)
            {
                next = current_player_id + 1;
            }
            else
            {
                next = 0;
            }
        }
        else
        {
            if (current_player_id == 0)
            {
                next = TotalPlayers - 1;
            }
            else
            {
                next = current_player_id + 1;
            }
        }
        players[next].hand.Add(cardGenerator.CreateCard());
        players[next].hand.Add(cardGenerator.CreateCard());
        players[next].hand.Add(cardGenerator.CreateCard());
        players[next].hand.Add(cardGenerator.CreateCard());
        NextPlayer();
    }
}
