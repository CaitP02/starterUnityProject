// Instantiates 10 copies of Prefab each 2 units apart from each other

using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Circle;
    public GameObject Imposter;
    public GameObject Bonus;
    public GameObject BadGuy;
    
    public void StartSpawning()
    {
        // Call the method to start spawning objects
        StartCoroutine(Spawner());
        spawnBad();
        spawnBad();

    }
    IEnumerator Spawner()
    {
       

        while(pointsDisplay.gameEnd == false)
       
            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    spawnImposter();
                    spawnCircle();

                }
               
                spawnBonus();
                
                yield return new WaitForSeconds(5);
            }
    


    }
    void spawnCircle()
    {
        Camera cam = Camera.main;
        float z = 0f;

        // Get camera bounds in world space
        float camHeight = 2f * cam.orthographicSize;
        float camWidth = camHeight * cam.aspect;

        float minX = cam.transform.position.x - camWidth / 2f;
        float maxX = cam.transform.position.x + camWidth / 2f;
        float minY = cam.transform.position.y - camHeight / 2f;
        float maxY = cam.transform.position.y + camHeight / 2f;

        float x = Random.Range(minX, maxX);
        float y = minY - 1f;

        Vector3 worldPos = new Vector3(x, y, z);
        Debug.Log($"Spawned circle at x: {worldPos.x}, y: {worldPos.y}");
        Instantiate(Circle, worldPos, Quaternion.identity);
    }
    void spawnImposter()
    {
        Camera cam = Camera.main;
        float z = 0f;

        float camHeight = 2f * cam.orthographicSize;
        float camWidth = camHeight * cam.aspect;

        float minX = cam.transform.position.x - camWidth / 2f;
        float maxX = cam.transform.position.x + camWidth / 2f;
        float minY = cam.transform.position.y - camHeight / 2f;
        float maxY = cam.transform.position.y + camHeight / 2f;

        float x = Random.Range(minX, maxX);
        float y = minY - 1f;

        Vector3 worldPos = new Vector3(x, y, z);
        Debug.Log($"Spawned imposter at x: {worldPos.x}, y: {worldPos.y}");
        Instantiate(Imposter, worldPos, Quaternion.identity);
    }
    void spawnBonus()
    {
        Camera cam = Camera.main;
        float z = 0f;

        float camHeight = 2f * cam.orthographicSize;
        float camWidth = camHeight * cam.aspect;

        float minX = cam.transform.position.x - camWidth / 2f;
        float maxX = cam.transform.position.x + camWidth / 2f;
        float minY = cam.transform.position.y - camHeight / 2f;
        float maxY = cam.transform.position.y + camHeight / 2f;

        float x = Random.Range(minX, maxX);
        float y = maxY + 1f;

        Vector3 worldPos = new Vector3(x, y, z);
        Debug.Log($"Spawned imposter at x: {worldPos.x}, y: {worldPos.y}");
        Instantiate(Bonus, worldPos, Quaternion.identity);
    }
    void spawnBad()
    {
        Camera cam = Camera.main;
        float z = 0f;

        float camHeight = 2f * cam.orthographicSize;
        float camWidth = camHeight * cam.aspect;

        float minX = cam.transform.position.x - camWidth / 2f;
        float maxX = cam.transform.position.x + camWidth / 2f;
        float minY = cam.transform.position.y - camHeight / 2f;
        float maxY = cam.transform.position.y + camHeight / 2f;

        float x = Random.Range(minX, maxX);
        float y = maxY + 1f;

        Vector3 worldPos = new Vector3(x, y, z);
        Debug.Log($"Spawned imposter at x: {worldPos.x}, y: {worldPos.y}");
        Instantiate(BadGuy, worldPos, Quaternion.identity);
    }




}