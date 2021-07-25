using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class shipGame : MonoBehaviour
{
    public static shipGame instance;
    float currentScore = 0;
    float highscore = 0;

    public Text hud_score;
    public Text highscoreText;
    //public Text scoreText;
    //public Text hscoreT;

    
    public float pointsPerSecond;
    public bool scoreInceasing;

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        highscore = PlayerPrefs.GetFloat("highscore", 0);
        hud_score.text = "Meters " + Mathf.Round(currentScore);
        highscoreText.text = "Highscore " + Mathf.Round(highscore);
    }

    // Update is called once per frame
    public void Update()
    {
        if(scoreInceasing)
        {
            currentScore += 1 * Time.deltaTime;
            hud_score.text = "Meters " + Mathf.Round(currentScore);
            if (highscore < currentScore)
            {
                PlayerPrefs.SetFloat("highscore", currentScore);
            }
            //PlayerPrefs.SetFloat("highscore", currentScore);

        }
        
        

        //scoreText.text = "meter " + Mathf.Round(scoreCount);
        //hscoreT.text = "hscore " + Mathf.Round(HiScoreCount);
    }


    /*public void AddScore()
    {
        currentScore += 1;
        hud_score.text = currentScore.ToString() + " Points";
        if (highscore < currentScore)
        {
            PlayerPrefs.SetInt("highscore", currentScore);
        }

    }*/
}
