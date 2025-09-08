using UnityEngine;
using UnityEngine.UIElements;

public class imposterClick : MonoBehaviour
{
    public static int points;
    AudioSource pop;
    Renderer objRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pop = GetComponent<AudioSource>();
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
                objRenderer.enabled = false;
                pop.Play();
                points++;
                Debug.Log("Imposter clicked!" + " " + points);
                if (pop.clip != null)
                {
                    Destroy(gameObject, pop.clip.length);
                }

            }
        }

        }
    }

