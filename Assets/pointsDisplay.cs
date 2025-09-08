using UnityEngine;
using TMPro;


public class pointsDisplay : MonoBehaviour
{

    public TMP_Text pointsText;
    public static int totalPoints = 0;
    public TMP_Text winText;


    public void Update()
    {
        totalPoints = imposterClick.points + CircleClick.points + BonusClick.points + BadClick.points;
        pointsText.text = "Points: " + totalPoints;

        if (pointsDisplay.totalPoints >= 30)
        {
            winText.text = "You Win!";
            Time.timeScale = 0;
        }
        if (pointsDisplay.totalPoints <= -30)
        {
            winText.text = "You Lose!";
            Time.timeScale = 0;
        }



    }
}

