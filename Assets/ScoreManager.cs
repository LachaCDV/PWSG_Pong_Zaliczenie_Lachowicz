using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI leftPlayerScoreText;
    public TextMeshProUGUI rightPlayerScoreText;

    public int leftPlayerScoreValue;
    public int rightPlayerScoreValue;

    private void Start()
    {
        leftPlayerScoreValue = 0;
        rightPlayerScoreValue = 0;
        leftPlayerScoreText.text = leftPlayerScoreValue.ToString();
        rightPlayerScoreText.text = rightPlayerScoreValue.ToString();
    }

    public void IncrementLeftPlayerScore()

    {
        leftPlayerScoreValue++;
        leftPlayerScoreText.text = leftPlayerScoreValue.ToString();
    }
    public void IncrementRightPlayerScore()

    {
        rightPlayerScoreValue++;
        rightPlayerScoreText.text = rightPlayerScoreValue.ToString();
    }
}