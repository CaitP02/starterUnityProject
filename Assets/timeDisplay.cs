using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class timeDisplay : MonoBehaviour
{

    public TMP_Text timeText;
    public TMP_Text winText;
    private bool timeRunning = false;
    private float startTimer = 0f;

    public void Update()
    {
        if (timeRunning = true){
            timeText.text = (Time.time - startTimer).ToString("F2");
        }
        if (Time.time - startTimer >= 60f)
        {
            winText.text = "You Lose!";
            Time.timeScale = 0;
            SceneManager.LoadScene("endScene");
        }

    }
    public void startTime()
    {
        timeRunning = true;
        startTimer = Time.time;
    }
}

