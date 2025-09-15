using UnityEngine;
using System.Collections;


public class BombClick : MonoBehaviour
{
    public static int points;
    AudioSource boom;
    Renderer objRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boom = GetComponent<AudioSource>();
        objRenderer = GetComponent<Renderer>();
        Debug.Log("ImposterClick Open!");
    }

    // Update is called once per frame
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
    Debug.Log("Bomb clicked!" + " " + points);

    yield return new WaitForSeconds(1f); // Wait 5 seconds before adding points

    points = -100;

    if (boom.clip != null)
    {
        Destroy(gameObject, boom.clip.length);
    }
    else
    {
        Destroy(gameObject);
    }
}


}
