using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenManageScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartGame()
    {
        Debug.Log("Restarting game...");
        SceneManager.LoadScene("mainScene");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
