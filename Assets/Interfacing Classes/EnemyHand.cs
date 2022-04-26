using System;

public class EnemyHand
{
	public GameManager gameManager;

    // Start is called before the first frame update
    void Play()
    {
        gameManager.FindPlayable(current_player_id);
        int j = 0;
        for (int i = 0; i < players[current_player_id].hand.Count; i++)
        {
            while (j == 0)
            {
                CardFabtory ThisCard = players[player_number].hand[i].GetComponent<CardFabtory>();
                BaseCard ThisCardData = ThisCard.CardData;

                if (ThisCard.playable == true)
                {
                    //PlayCard();
                    j = 1;
                    i = players[current_player_id].hand.Count;
                }
                else
                {
                    i += 1;
                }
            }
        }

    }


}
