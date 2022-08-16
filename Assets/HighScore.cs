using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    static public int score = 1000;
    void Awake() {
        if(PlayerPrefs.HasKey("Highscore")){
            score = PlayerPrefs.GetInt("Highscore");
        }
        PlayerPrefs.SetInt("Highscore", score);
    }

    void Update()
    {
        TMP_Text scoreText = GetComponent<TMP_Text>();
        scoreText.text = "High Score: " + score;

        if(score > PlayerPrefs.GetInt("Highscore")){
            PlayerPrefs.SetInt("Highscore", score);
        }
    }
}
