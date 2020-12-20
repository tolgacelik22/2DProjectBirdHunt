using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    public Spawner spawner;
    public int ScoreKazan()
    {
        score += 1;
        return score;
    }

    public void endGame()
    {
        spawner.isGameStart = false;
    }
}
