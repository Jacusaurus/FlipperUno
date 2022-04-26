using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
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

            //if (current_type == Type.DRAWTWO)
            //{
            //    Draw2Function();
            //}
            //else if (current_type == Type.REVERSE)
            //{
            //    ReverseFunction();
            //}
            //else if (current_type == Type.SKIP)
            //{
            //    SkipFunction();
            //}
            //else if (current_type == Type.WILD)
            //{
            //    WildFunction();
            //}
            //else if (current_type == Type.WILDDRAWFOUR)
            //{
            //    WildFunction();
            //    Draw4Function();
            //}

            //if ( players[current_player_id].hand.length == 0)
            //{
            //    GameOver = 1;
            //}
            //else
            //{
            //    NextPlayer();
            //}

        }

        Application.Quit();

    }

}