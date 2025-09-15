using UnityEngine;
using System.Collections;

public class EnemyClick : MonoBehaviour
{
    public static int points;
    AudioSource boom;
    Renderer objRenderer;

    void Start()
    {
        boom = GetComponent<AudioSource>();
        objRenderer = GetComponent<Renderer>();
        Debug.Log("EnemyClick Open!");
        Destroy(gameObject, 10f); // Destroy the enemy after 5 seconds if not clicked
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                StartCoroutine(DestroyObj());
            }
        }
    }

    public IEnumerator DestroyObj()
    {
        objRenderer.enabled = false;
        boom.Play();
        Debug.Log("Enemy clicked! " + points);
        if (boom.clip != null)
        {
            points += -1; 
            Destroy(gameObject, boom.clip.length);
            yield return new WaitForSeconds(boom.clip.length);
        }
        else
        {
            Destroy(gameObject);
            yield break;
        }
    }
}
