using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pointsDisplay : MonoBehaviour
{

    public TMP_Text pointsText;
    public static int totalPoints = 0;
    public TMP_Text winText;
    public static bool gameEnd = false;
    public void Start()
    {
      
        gameEnd = false;
        totalPoints = 0;
        EnemyClick.points = 0;
        Click.points = 0;
        BonusClick.points = 0;
        BombClick.points = 0;


    }



    public void Update()
    {
        totalPoints = Click.points + EnemyClick.points + BonusClick.points + BombClick.points;
        pointsText.text = "Points: " + totalPoints;

       /* if (!gameEnd && pointsDisplay.totalPoints >= 60)
        {
            winText.text = "You Win!";
            gameEnd = true;
            //Time.timeScale = 0;
            SceneManager.LoadScene("endScene");
    }*/
        if (!gameEnd && pointsDisplay.totalPoints <= -60)
        {
            winText.text = "You Lose!";
            gameEnd = true;
           // Time.timeScale = 0;
            SceneManager.LoadScene("endScene");
        }



    }
}

