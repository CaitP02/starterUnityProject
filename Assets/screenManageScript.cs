using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenManageScript : MonoBehaviour
{
    public TMP_Text winorloseText;
    public TMP_Text highscoreText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WinOrLose();
        displayScore();
        timeDisplay.timeRunning = false; // Now static
        timeDisplay.startTimer = 0f;     // Now static
}

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartGame()
    {
        Debug.Log("Restarting game...");
        SceneManager.LoadScene("mainScene");
        //Time.timeScale = 1;
        //pointsDisplay.totalPoints = 0;

    }
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
    public void WinOrLose()
    {
        winorloseText.text = "test";
        if (pointsDisplay.totalPoints >= 60)
        {
            winorloseText.text = "You Win!";
        }
        else if (pointsDisplay.totalPoints <= -60)
        {
            winorloseText.text = "You Lose!";
        }
        else
        {
            winorloseText.text = "Game Ended!";
        }
    }
    public void displayScore()
    {
        //pointsDisplay.totalPoints = 5;
        highscoreText.text = "Your Score: " + pointsDisplay.totalPoints;
    }
}
