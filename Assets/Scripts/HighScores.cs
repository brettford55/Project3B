using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{
    public Text highScoreText;
    public Text highScore2Text;
    public Text highScore3Text;
    public Text highScore4Text;
    public Text highScore5Text;

    // Start is called before the first frame update
    void Start()
    {

        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore");
        highScore2Text.text = "Highscore 2: " + PlayerPrefs.GetInt("Highscore2");
        highScore3Text.text = "Highscore 3: " + PlayerPrefs.GetInt("Highscore3");
        highScore4Text.text = "Highscore 4: " + PlayerPrefs.GetInt("Highscore4");
        highScore5Text.text = "Highscore 5: " + PlayerPrefs.GetInt("Highscore5");
    }
}
