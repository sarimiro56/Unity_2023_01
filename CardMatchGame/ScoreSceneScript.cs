using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSceneScript : MonoBehaviour
{
    public Text scoreText;
    public Text attemptsText;

    private void Start()
    {
        int score = PlayerPrefs.GetInt("Score");
        int attempts = PlayerPrefs.GetInt("Attempts");

        scoreText.text = "ÃÑ Á¡¼ö: " + score;
        attemptsText.text = "½Ãµµ È½¼ö: " + attempts;
    }
}
