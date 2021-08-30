using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    // take in both scripts for either players or their tag handlers, 
    // use in this script.
    Timer matchTimer;
    public float matchLength = 180f;

    PlayerControls[] players = new PlayerControls[2];
    int player1Score;
    int player2Score;

    public Text scoreCountText;

    void Start()
    {
        players[0] = GetComponent<PlayerControls>();
        players[1] = GetComponent<PlayerControls>();

        player1Score = players[0].personalScore;
        player2Score = players[1].personalScore;
    }

    // needs to visibly display score.
    void Update()
    {
        matchTimer.DisplayTime(matchTimer.remainingTime);
        scoreCountText.text = player1Score + "/" + player2Score;

        if (matchTimer.remainingTime <= 0)
        {
            //disable player controls
            //reset playing field
            CalculateScore();
            matchTimer.ResetTimer();
        }
    }

    public void StartMatch()
    {
        matchTimer.SetTimerLength(matchLength); //ideally this variable would be adjustable in game settings
        matchTimer.BeginCountdown();

        // if the game is exited from a pause menu resettimer should be called,
        // but that should be a separate function for a separate script. 
    }

    void CalculateScore()
    {

        if (player1Score > player2Score)
        {
            // player 1 wins! fanfare, etc.
            // text here should be displayed in a textmeshpro.
            Debug.Log("Player 1 wins! Congrats! The score is: " + player1Score + " vs " + player2Score);
        }
        else if (player1Score < player2Score)
        {
            // player 2 wins! fanfare, etc.
            // text here should be displayed in a textmeshpro.
            Debug.Log("Player 2 wins! Congrats! The score is: " + player1Score + " vs " + player2Score);
        }
        else if (player1Score == player2Score)
        {
            // it's a draw! fanfare, etc.
            // text here should be displayed in a textmeshpro.
            Debug.Log("The match is a draw! The score is: " + player1Score + " vs " + player2Score);
        }
    }
}
