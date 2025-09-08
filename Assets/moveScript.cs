using UnityEngine;

public class moveScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector3 direction = Vector3.up + Vector3.left;

    void Update()
    {
        transform.position += direction * moveSpeed * Time.deltaTime;

        // Get camera bounds
        Camera cam = Camera.main;
        float camHeight = 2f * cam.orthographicSize;
        float camWidth = camHeight * cam.aspect;
        float minX = cam.transform.position.x - camWidth / 2f;
        float maxX = cam.transform.position.x + camWidth / 2f;
        float minY = cam.transform.position.y - camWidth / 2f;
        float maxY = cam.transform.position.y + camWidth / 2f;

        // Bounce off left/right edges
        if (transform.position.x < minX || transform.position.x > maxX)
        {
            direction.x *= -1;
        }
        if (transform.position.y < minY || transform.position.y > maxY)
        {            direction.y *= -1;
        }
    }
}