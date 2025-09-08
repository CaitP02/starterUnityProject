using Unity.VisualScripting;
using UnityEngine;

public class CircleClick : MonoBehaviour
{
    public static int points;
    AudioSource pop;
    Renderer objRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pop = GetComponent<AudioSource>();
        objRenderer = GetComponent<Renderer>();
        Debug.Log("CircleClick Open!");
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
                objRenderer.enabled = false;
                pop.Play();
                points += -1;
                Debug.Log("Hazard clicked!" + " " + points);
                if(pop.clip != null)
                {
                    Destroy(gameObject, pop.clip.length);
                   }
                
            }

        }
    }
}
