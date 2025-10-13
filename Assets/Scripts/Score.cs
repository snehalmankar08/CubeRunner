using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalScoreText;

    int myScore = 0;
    void Update()
    {
        scoreText.text = myScore.ToString();
        finalScoreText.text = "Score: "+myScore.ToString();

    }
    public void AddScore(int score)
    {
        myScore = myScore + score;
    }
}
