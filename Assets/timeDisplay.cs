using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class timeDisplay : MonoBehaviour
{
    public TMP_Text timeText;
    public TMP_Text winText;
    public static bool timeRunning = false; // Made static
    public static float startTimer = 0f;    // Made static

    public void Update()
    {
        if (timeRunning) // Fixed assignment to comparison
        {
            timeText.text = (Time.time - startTimer).ToString("F2");
        }
        if (!pointsDisplay.gameEnd && (Time.time - startTimer) >= 60f)
        {
            winText.text = "You Lose!";
            pointsDisplay.gameEnd = true;
            // Time.timeScale = 0;
            SceneManager.LoadScene("endScene");
        }
    }
    public void startTime()
    {
        timeRunning = true;
        startTimer = Time.time;
    }
}

