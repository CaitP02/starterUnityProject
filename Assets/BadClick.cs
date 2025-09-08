using UnityEngine;

public class BadClick : MonoBehaviour
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
                objRenderer.enabled = false;
                boom.Play();
                points += -100;
                Debug.Log("Bomb clicked!" + " " + points);
                if (boom.clip != null)
                {
                    Destroy(gameObject, boom.clip.length);
                }
            }

        }
    }
}
