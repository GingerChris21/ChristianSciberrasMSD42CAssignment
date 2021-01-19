using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    int score = 0;

    public int GetScore()
    {
        return score;
    }

    public void AddToScore(int scoreValue)
    {

        score += scoreValue;
        //print("Score is " + score);
        if (score >= 100)
        {
            Level.LoadWinner();
        }
    }
    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
